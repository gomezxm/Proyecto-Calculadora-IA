using System.Data;
using System.Windows.Forms;
using System.Linq;
using System;

namespace ProyectCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_MostrarDatos.KeyPress += txt_MostrarDatos_KeyPress;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_CalculadoraBasica_Click(object sender, EventArgs e)
        {

        }

        private void btn_LimpiarTodo_Click(object sender, EventArgs e)
        {
            txt_MostrarDatos.Clear();
        }

        private void txt_MostrarDatos_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            bool blValidarOperadoresConsecutivos = validarOperadoresConsecutivos(); // VALIDAR QUE NO HAYA OPERADORES CONSECUTIVOS
            bool blUnPuntoDecimal = unPuntoDecimal(); // VALIDAR LA CANTIDAD DE DECIMALES
            bool blValidarCeroDivision = validarCeroDivision(); // VALIDAR QUE NO HAYA DIVISION ENTRE CERO
            bool blValidarInicioCero = validarInicioCero(); // VALIDAR QUE NO INICIE CON CERO

            bool blValidarEspaciosVacios = validarEspaciosVacios(); // VALIDAR QUE NO HAYA ESPACIOS VACIOS
            bool blValidarCaracteresInvalidos = validarCaracteresInvalidos(); // VALIDAR QUE NO HAYA CARACTERES INVALIDOS
            bool blValidarSoloOperadores = valSoloOperadores(); // VALIDAR QUE NO HAYA SOLO OPERADORES
            bool blValidarLongitud = limitarLongitud(); // VALIDAR LA LONGITUD MAXIMA DE DIGITOS
            bool blvalidarEmpezarDigito = validarEmpezarDigito(); // VALIDAR QUE EMPIECE CON UN DIGITO
            bool blContarDiferencia = contarDiferencia(); // VALIDAR QUE LA CANTIDAD DE OPERADORES NO SEA MAYOR O IGUAL A LA
            if (blUnPuntoDecimal && blValidarInicioCero && blValidarOperadoresConsecutivos && blValidarCeroDivision && blValidarEspaciosVacios && blValidarCaracteresInvalidos && blValidarSoloOperadores && blValidarLongitud && blvalidarEmpezarDigito
                && blContarDiferencia)
            {
                operacion();
            }
        }
        private void btn_punto_Click(object sender, EventArgs e)
        {
            string texto = txt_MostrarDatos.Text;
            
            // 1. MEJORA: Validar si el campo está vacío o si la última parte es un operador.
            // Si el texto está vacío, añade "0." directamente.
            if (string.IsNullOrEmpty(texto)) 
            {
                txt_MostrarDatos.AppendText("0.");
                return; // Termina la función aquí.
            }
            
            // Si el último carácter es un operador, añade "0." después del operador.
            char ultimoCaracter = texto.LastOrDefault();
            if ("+-*/".Contains(ultimoCaracter))
            {
                txt_MostrarDatos.AppendText("0.");
                return; // Termina la función aquí.
            }

            // 2. Lógica existente: Evitar múltiples puntos en el mismo número.
            string[] partes = texto.Split(new char[] { '+', '-', '*', '/' });
            string ultimaParte = partes.LastOrDefault();

            if (ultimaParte != null && !ultimaParte.Contains("."))
            {
                txt_MostrarDatos.AppendText(".");
            }
        }

        private void btn_uno_Click(object sender, EventArgs e)
        {
            txt_MostrarDatos.AppendText("1");
        }

        private void btn_dos_Click(object sender, EventArgs e)
        {
            txt_MostrarDatos.AppendText("2");
        }

        private void btn_tres_Click(object sender, EventArgs e)
        {
            txt_MostrarDatos.AppendText("3");
        }

        private void btn_cuatro_Click(object sender, EventArgs e)
        {
            txt_MostrarDatos.AppendText("4");
        }

        private void btn_cinco_Click(object sender, EventArgs e)
        {
            txt_MostrarDatos.AppendText("5");
        }

        private void btn_seis_Click(object sender, EventArgs e)
        {
            txt_MostrarDatos.AppendText("6");
        }

        private void btn_siete_Click(object sender, EventArgs e)
        {
            txt_MostrarDatos.AppendText("7");
        }

        private void btn_ocho_Click(object sender, EventArgs e)
        {
            txt_MostrarDatos.AppendText("8");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_MostrarDatos.AppendText("9");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_cero_Click(object sender, EventArgs e)
        {
            txt_MostrarDatos.AppendText("0");
        }

        // Función de Lógica Unificada para Operadores (MEJORADA)
        private void HandleOperatorClick(string newOperator)
        {
            string texto = txt_MostrarDatos.Text;
            char ultimoCaracter = texto.LastOrDefault();
            string operadores = "+-*/";

            // CASO 1: Campo vacío
            if (string.IsNullOrEmpty(texto))
            {
                // Solo permitimos el signo de resta (-) para iniciar con un número negativo.
                if (newOperator == "-")
                {
                    txt_MostrarDatos.AppendText(newOperator);
                }
                return;
            }

            // CASO 2: El último carácter es un operador
            if (operadores.Contains(ultimoCaracter))
            {
                // 2.1. Permitir la inserción de un signo negativo (-) después de OTRO operador 
                // (Ej: 5* a 5*- para indicar un número negativo. ESTO ES UN COMPORTAMIENTO AVANZADO Y OPCIONAL)
                if (newOperator == "-" && ultimoCaracter != '-')
                {
                    // Verificamos si ya tenemos dos operadores (Ej: 5*-), para evitar 5*--
                    // Esto evita operadores triples o más (como 5*--3)
                    if (texto.Length >= 2 && operadores.Contains(texto[texto.Length - 2]))
                    {
                        return; // Ya hay dos operadores consecutivos, bloqueamos.
                    }

                    // Si la secuencia actual es (Operador)(Número), permitimos (Operador)(Negativo)
                    // Ya que el último es un operador (Ej: 5*), añadimos el negativo (-> 5*-)
                    txt_MostrarDatos.AppendText(newOperator);
                    return;
                }

                // 2.2. Si el nuevo operador es CUALQUIER OTRA COSA (o es un segundo '-'), REEMPLAZAMOS el último operador.
                // Ej: 5+ a 5*, o 5*- a 5*
                txt_MostrarDatos.Text = texto.Remove(texto.Length - 1) + newOperator;
                return;
            }

            // CASO 3: El último carácter es un número o punto decimal (inserción normal)
            txt_MostrarDatos.AppendText(newOperator);
        }
        private void btn_suma_Click(object sender, EventArgs e)
        {
            // Llama a la lógica unificada de validación y reemplazo
            HandleOperatorClick("+");
        }

        private void btn_restar_Click(object sender, EventArgs e)
        {
            // Llama a la lógica unificada de validación y reemplazo
            HandleOperatorClick("-");
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            // Llama a la lógica unificada de validación y reemplazo
            HandleOperatorClick("*");
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            // Llama a la lógica unificada de validación y reemplazo
            HandleOperatorClick("/");
        }
        private void btn_borrar_Click(object sender, EventArgs e)
        {
            borrarUltimoCaracter();
        }

      // Función para borrar el último carácter
        public void borrarUltimoCaracter()
        {
            try
            {
                string txt = txt_MostrarDatos.Text;
                // Si hay texto, lo borra
                if (txt.Length > 0)
                {
                    txt_MostrarDatos.Text = txt.Remove(txt.Length - 1);
                }
            }
            catch (Exception e)
            {
                // Ignora la excepción si el campo está vacío al borrar.
            }
        }

        bool unPuntoDecimal()
        {
            string[] porOperaciones;
            porOperaciones = txt_MostrarDatos.Text.Split(new char[] { '+', '-', '*', '/' });

            foreach (string s in porOperaciones)
            {
                int cont = s.Count(s => s == '.');
                if (cont > 1)
                {
                    MessageBox.Show("No se permiten mas de un punto decimal por numero");
                    return false;
                }
            }
            return true;
        }

        bool validarInicioCero()
        {
            if (txt_MostrarDatos.Text.StartsWith("."))
            {
                MessageBox.Show("El numero no puede iniciar con un punto decimal");
                return false;
            }
            return true;
        }

        bool validarOperadoresConsecutivos()
        {
            string operadores = "+-*/";
            for (int i = 0; i < txt_MostrarDatos.Text.Length - 1; i++)
            {
                if (operadores.Contains(txt_MostrarDatos.Text[i]) && operadores.Contains(txt_MostrarDatos.Text[i + 1]))
                {
                    MessageBox.Show("No se permiten operadores consecutivos");
                    return false;
                }

            }
            return true;
        }

        bool validarCeroDivision()
        {
            string divisionPorCero = "/0";
            if (txt_MostrarDatos.Text.Contains(divisionPorCero))
            {
                MessageBox.Show("No se puede dividir entre cero");
                return false;
            }
            return true;
        }
        bool validarEspaciosVacios()
        {
            string espaciosVacios = " ";
            if (string.IsNullOrWhiteSpace(txt_MostrarDatos.Text))
            {
                MessageBox.Show("No se permiten espacios vacios");
                return false;
            }
            else
            {
                foreach (char c in txt_MostrarDatos.Text)
                {
                    if (espaciosVacios.Contains(c))
                    {
                        MessageBox.Show("1 No se permiten espacios vacios");
                        return false;
                    }
                }
            }
            return true;
        }
        bool validarCaracteresInvalidos()
        {
            string caracteresInvalidos = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&_=<>?";
            foreach (char c in txt_MostrarDatos.Text)
            {
                if (caracteresInvalidos.Contains(c))
                {
                    MessageBox.Show("Se han ingresado caracteres invalidos");
                    return false;
                }
            }
            return true;
        }

        bool valSoloOperadores()
        {
            // string operadores = "+-*/";
            int cantidadOperadores = txt_MostrarDatos.Text.Count(C => C == ('+') || C == ('-') || C == ('*') || C == ('/'));
            int cantidadNumeros = txt_MostrarDatos.Text.Count(C => char.IsDigit(C));

            if (cantidadOperadores > 0 && cantidadNumeros == 0)
            {
                return false;
            }
            return true;
        }

        bool limitarLongitud()
        {
            int cantidadNumeros = txt_MostrarDatos.Text.Count(C => char.IsDigit(C));
            if (cantidadNumeros > 12)
            {
                MessageBox.Show("Se ha excedido la cantidad maxima de digitos permitidos (12)");
                return false;
            }
            return true;
        }

        bool validarEmpezarDigito()
        {
            string operadores = "+-*/";
            if (operadores.Contains(txt_MostrarDatos.Text[0]))
            {
                MessageBox.Show("Debe empezar con un digito no operando");
                return false;
            }
            return true;
        }

        bool contarDiferencia()
        {
            int cantidadOperadores = txt_MostrarDatos.Text.Count(C => C == ('+') || C == ('-') || C == ('*') || C == ('/'));
            int cantidadNumeros = txt_MostrarDatos.Text.Count(C => char.IsDigit(C));

            if (cantidadOperadores >= cantidadNumeros)
            {
                MessageBox.Show("La cantidad de operadores no puede ser mayor o igual a la de numeros");
                return false;
            }
            return true;
        }

       // Manejador de eventos para restringir la entrada directa por teclado.
        // Manejador de eventos para restringir la entrada directa por teclado.
private void txt_MostrarDatos_KeyPress(object sender, KeyPressEventArgs e)
{
    char tecla = e.KeyChar;
    string texto = txt_MostrarDatos.Text;

    // 1. **VALIDACIÓN EXTREMADAMENTE ESTRICTA**:
    // Permitir SÓLO: Dígitos, Operadores (+-*/), Punto decimal (.), y Teclas de Control (Backspace, Enter).
    // Esto BLOQUEARÁ los guiones bajos, letras, paréntesis y cualquier otro símbolo.
    if (!char.IsDigit(tecla) && !"+-*/.".Contains(tecla) && !char.IsControl(tecla))
    {
        e.Handled = true; 
        return; 
    }
    
    // 2. Si es un operador, bloqueamos la tecla y llamamos a la lógica centralizada.
    if ("+-*/".Contains(tecla))
    {
        e.Handled = true; 
        HandleOperatorClick(tecla.ToString());
        return; 
    }
    
    // 3. Lógica específica para el punto decimal (Mantenida)
    if (tecla == '.')
    {
        e.Handled = true; 
        
        string[] partes = texto.Split(new char[] { '+', '-', '*', '/' });
        string ultimaParte = partes.LastOrDefault();
        
        // Inserta "0." si el campo está vacío o después de un operador.
        if (string.IsNullOrEmpty(texto) || "+-*/".Contains(texto.LastOrDefault()))
        {
             if (txt_MostrarDatos.SelectionLength > 0)
             {
                 txt_MostrarDatos.Text = txt_MostrarDatos.Text.Remove(txt_MostrarDatos.SelectionStart, txt_MostrarDatos.SelectionLength);
             }
             txt_MostrarDatos.AppendText("0.");
        }
        // Inserta "." si el número actual no contiene un punto.
        else if (ultimaParte != null && !ultimaParte.Contains("."))
        {
            txt_MostrarDatos.AppendText(".");
        }
    }
}

       void operacion()
        {
            try
            {
                txt_MostrarDatos.Text = new DataTable().Compute(txt_MostrarDatos.Text, null).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la expresión matemática: " + ex.Message, "Error de Cálculo");
                txt_MostrarDatos.Clear(); // Limpia la pantalla después de un error.
            }
        }
    }
    
}