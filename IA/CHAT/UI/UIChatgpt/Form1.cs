using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIChatgpt
{
    public partial class Form1 : Form
    {
        private readonly ChatGptClient _chatClient;
        private readonly List<(string role, string content)> _history = new List<(string role, string content)>();
        private const int MaxHistoryTurns = 10;
        private const int MaxPromptLength = 1000;
        private bool _sending = false;
        private string _lastAssistantMessage = "";

        public Form1()
        {
            InitializeComponent();
            _chatClient = new ChatGptClient(new HttpClient());
            lblEstado.Text = "Listo";
            txtPrompt.Focus();
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            await EnviarAsync();
        }

        private async Task EnviarAsync()
        {
            if (_sending) return; // evitar duplicados
            string prompt = (txtPrompt.Text ?? "").Trim();

            // Validaciones
            if (string.IsNullOrWhiteSpace(prompt))
            {
                MessageBox.Show("El mensaje está vacío.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (prompt.Length > MaxPromptLength)
            {
                MessageBox.Show($"El mensaje supera {MaxPromptLength} caracteres. Se enviará recortado.", "Longitud", MessageBoxButtons.OK, MessageBoxIcon.Information);
                prompt = prompt.Substring(0, MaxPromptLength);
            }

            // Estado y bloqueo
            _sending = true;
            btnEnviar.Enabled = false;
            lblEstado.Text = "Enviando…";

            // Mostrar turno de usuario en historial
            AppendChatLine("Tú", prompt);

            // Actualizar memoria corta
            _history.Add(("user", prompt));
            TruncateHistory();

            // Preparar system prompt opcional (puedes personalizarlo)
            string systemPrompt = "Eres un asistente útil y conciso. Responde claramente en español.";

            try
            {
                // Concatenar contexto para envío (últimos N turnos)
                string contextualUserQuestion = BuildContextualPrompt(_history);

                // Sanitizar nuevas líneas a \n si fuera necesario para la API
                contextualUserQuestion = NormalizeNewlines(contextualUserQuestion);

                string respuesta = await _chatClient.AskAsync(contextualUserQuestion, systemPrompt);

                _lastAssistantMessage = respuesta ?? "";
                AppendChatLine("Asistente", _lastAssistantMessage);

                // Guardar respuesta en memoria
                _history.Add(("assistant", _lastAssistantMessage));
                TruncateHistory();
            }
            catch (HttpRequestException httpEx)
            {
                // Decodificar algunos estados comunes
                string msg = httpEx.Message;
                if (msg.Contains("401"))
                    AppendError("API key inválida o ausente.");
                else if (msg.Contains("429"))
                    AppendError("Límite alcanzado, espera unos segundos.");
                else if (msg.Contains("5") && msg.Contains("OpenAI error"))
                    AppendError("Servicio ocupado. Reintentar.");
                else
                    AppendError("No se pudo conectar. Intenta de nuevo.");
            }
            catch (TaskCanceledException)
            {
                AppendError("No se pudo conectar. Intenta de nuevo.");
            }
            catch (Exception ex)
            {
                AppendError("Error inesperado: " + ex.Message);
            }
            finally
            {
                // Restaurar estado
                _sending = false;
                btnEnviar.Enabled = true;
                lblEstado.Text = "Listo";
                txtPrompt.Text = "";
                txtPrompt.Focus();
            }
        }

        private void txtPrompt_Click(object sender, EventArgs e)
        {
            if (txtPrompt.Text == "Inicia con un mensaje...")
                txtPrompt.Text = "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtChat.Clear();
            txtPrompt.Clear();
            _history.Clear();
            _lastAssistantMessage = "";
            lblEstado.Text = "Listo";
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_lastAssistantMessage))
            {
                Clipboard.SetText(_lastAssistantMessage);
                MessageBox.Show("Última respuesta copiada al portapapeles.", "Copiar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay respuesta del asistente para copiar.", "Copiar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtPrompt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Shift) // Enter para enviar, Shift+Enter para nueva línea
            {
                e.SuppressKeyPress = true; // evita el beep y el salto de línea en TextBox
                _ = EnviarAsync();
            }
        }

        private void AppendChatLine(string speaker, string message)
        {
            // Historial visible
            txtChat.AppendText($"{speaker}: {message}{Environment.NewLine}{Environment.NewLine}");
        }

        private void AppendError(string error)
        {
            lblEstado.Text = "Error";
            txtChat.AppendText($"Error: {error}{Environment.NewLine}{Environment.NewLine}");
        }

        private void TruncateHistory()
        {
            // Mantener últimos MaxHistoryTurns elementos
            if (_history.Count > MaxHistoryTurns)
            {
                int removeCount = _history.Count - MaxHistoryTurns;
                _history.RemoveRange(0, removeCount);
            }
        }

        private string BuildContextualPrompt(List<(string role, string content)> history)
        {
            // Envía últimos turnos como texto concatenado. Alternativamente podrías
            // construir una estructura messages[] role=user/assistant en el cliente.
            var sb = new StringBuilder();
            foreach (var (role, content) in history)
            {
                sb.AppendLine($"{role}: {content}");
            }
            return sb.ToString();
        }

        private string NormalizeNewlines(string text)
        {
            // Normalizar CRLF a LF si fuese necesario
            return text.Replace("\r\n", "\n");
        }
    }
}