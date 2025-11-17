using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

public class ChatGptClient
{
    private readonly HttpClient _http;
    private readonly string _apiKey;

    public ChatGptClient(HttpClient http)
    {
        _http = http;
        _apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY")
                  ?? throw new InvalidOperationException("Falta la variable de entorno OPENAI_API_KEY.");
        _http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _apiKey);
        _http.BaseAddress = new Uri("https://api.openai.com/");
    }

    private const string DefaultModel = "gpt-4o-mini";

    public async Task<string> AskAsync(string userQuestion, string systemPrompt = null, string model = DefaultModel, float temperature = 0.2f)
    {
        var payload = new
        {
            model,
            temperature,
            messages = new object[]
            {
            new { role = "system", content = systemPrompt ?? "Eres un asistente útil y conciso." },
            new { role = "user", content = userQuestion }
            }
        };

        var req = new HttpRequestMessage(HttpMethod.Post, "v1/chat/completions")
        {
            Content = JsonContent.Create(payload, options: new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            })
        };

        var res = await _http.SendAsync(req);
        var json = await res.Content.ReadAsStringAsync();

        if (!res.IsSuccessStatusCode)
        {
            throw new HttpRequestException($"OpenAI error {res.StatusCode}: {json}");
        }

        var doc = JsonDocument.Parse(json);
        var content = doc.RootElement
            .GetProperty("choices")[0]
            .GetProperty("message")
            .GetProperty("content")
            .GetString();

        return content ?? "";
    }
}
