using System.Data;

namespace ProyectCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            bool blvalidarEmpezarDigito = validarEspaciosVacios(); // VALIDAR QUE EMPIECE CON UN DIGITO
            bool blContarDiferencia = contarDiferencia(); // VALIDAR QUE LA CANTIDAD DE OPERADORES NO SEA MAYOR O IGUAL A LA
            if (blUnPuntoDecimal && blValidarInicioCero && blValidarOperadoresConsecutivos&&blValidarCeroDivision&&blValidarEspaciosVacios&&blValidarCaracteresInvalidos&&blValidarSoloOperadores&&blValidarLongitud&&blvalidarEmpezarDigito
                &&blContarDiferencia)
            {
                operacion();
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

        private void btn_suma_Click(object sender, EventArgs e)
        {
            txt_MostrarDatos.AppendText("+");
        }

        private void btn_restar_Click(object sender, EventArgs e)
        {
            txt_MostrarDatos.AppendText("-");
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            txt_MostrarDatos.AppendText("*");
        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            txt_MostrarDatos.AppendText("/");
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            borrarUltimoCaracter();
        }

        public void borrarUltimoCaracter()
        {
            try
            {
                string txt = txt_MostrarDatos.Text;
                string txt1 = txt_MostrarDatos.Text.Remove(txt.Length - 1);
                txt_MostrarDatos.Clear();
                txt_MostrarDatos.AppendText(txt1);
            }
            catch (Exception ex)
            {
                //AQUI  NADA 
            }
        }

        bool unPuntoDecimal()
        {
            string[] porOperaciones;
            porOperaciones = txt_MostrarDatos.Text.Split(new char[] { '+', '-','*','/' });

            foreach(string s in porOperaciones)
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
            for (int i = 0;i < txt_MostrarDatos.Text.Length - 1; i++)
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
            } else
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
            int cantidadOperadores = txt_MostrarDatos.Text.Count(C => C == ('+') || C == ('-') || C == ('*')|| C == ('/'));
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

       void operacion()
        {
            txt_MostrarDatos.Text = new DataTable().Compute(txt_MostrarDatos.Text, null).ToString();
        }
    }
}
