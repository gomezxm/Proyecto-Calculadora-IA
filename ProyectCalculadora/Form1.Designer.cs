namespace ProyectCalculadora
{
    // La palabra clave 'partial' indica que la definición de la clase Form1 está dividida 
    // entre este archivo (código de interfaz) y el archivo Form1.cs (código de lógica).
    partial class Form1
    {
        // El bloque /// <summary> se utiliza para la documentación XML (IntelliSense)

        /// <summary>
        /// Variable requerida del diseñador.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpia (descarta) los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true para liberar tanto los recursos administrados como no administrados; false para liberar solo los no administrados.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                // Si 'components' no es nulo y se está descartando, libera sus recursos.
                components.Dispose();
            }
            // Llama al método Dispose de la clase base (Form).
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        // #region es un bloque de código plegable para organizar el código.
        // Todo el código dentro de esta región es generado automáticamente por el Diseñador.

        /// <summary>
        /// Método necesario para el soporte del Diseñador. No modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            // 1. Inicialización de Controles
            // Se crean las instancias de todos los controles de la interfaz (Label, TextBox y Buttons).
            lbl_CalculadoraBasica = new Label();
            txt_MostrarDatos = new TextBox();
            btn_LimpiarTodo = new Button();
            btn_borrar = new Button();
            btn_suma = new Button();
            btn_div = new Button();
            btn_mult = new Button();
            btn_restar = new Button();
            btn_resultado = new Button();
            btn_siete = new Button();
            btn_ocho = new Button();
            btn_nueve = new Button();
            btn_cinco = new Button();
            btn_seis = new Button();
            btn_tres = new Button();
            btn_dos = new Button();
            btn_uno = new Button();
            btn_cuatro = new Button();
            btn_cero = new Button();
            btn_punto = new Button();
            SuspendLayout();

            // 2. Configuración de Propiedades Individuales
            // ----------------------------------------------------------------------------------
            // lbl_CalculadoraBasica
            // ----------------------------------------------------------------------------------
            lbl_CalculadoraBasica.AutoSize = true;
            lbl_CalculadoraBasica.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CalculadoraBasica.Location = new Point(3, 32);
            lbl_CalculadoraBasica.Name = "lbl_CalculadoraBasica";
            lbl_CalculadoraBasica.Size = new Size(261, 40);
            lbl_CalculadoraBasica.TabIndex = 0;
            lbl_CalculadoraBasica.Text = "Calculadora Básica";
            lbl_CalculadoraBasica.Click += lbl_CalculadoraBasica_Click;

            // ----------------------------------------------------------------------------------
            // txt_MostrarDatos (Campo de texto/pantalla de la calculadora)
            // ----------------------------------------------------------------------------------
            txt_MostrarDatos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_MostrarDatos.Location = new Point(16, 109);
            txt_MostrarDatos.Margin = new Padding(3, 4, 3, 4);
            txt_MostrarDatos.Name = "txt_MostrarDatos";
            txt_MostrarDatos.Size = new Size(294, 42);
            txt_MostrarDatos.TabIndex = 1;
            txt_MostrarDatos.TextChanged += txt_MostrarDatos_TextChanged;

            // ----------------------------------------------------------------------------------
            // btn_LimpiarTodo (Botón 'C')
            // ----------------------------------------------------------------------------------
            btn_LimpiarTodo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_LimpiarTodo.Location = new Point(16, 183);
            btn_LimpiarTodo.Name = "btn_LimpiarTodo";
            btn_LimpiarTodo.Size = new Size(110, 52); // Buen tamaño para el ancho
            btn_LimpiarTodo.TabIndex = 2;
            btn_LimpiarTodo.Text = "C";
            btn_LimpiarTodo.UseVisualStyleBackColor = true;
            btn_LimpiarTodo.Click += btn_LimpiarTodo_Click;

            // ----------------------------------------------------------------------------------
            // btn_borrar (Botón '←' o Backspace)
            // ----------------------------------------------------------------------------------
            btn_borrar.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_borrar.Location = new Point(133, 183);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(109, 52); // Buen tamaño para el ancho
            btn_borrar.TabIndex = 3;
            btn_borrar.Text = "←";
            btn_borrar.UseVisualStyleBackColor = true;
            btn_borrar.Click += btn_borrar_Click;

            // ----------------------------------------------------------------------------------
            // Botones de Operadores (+, -, x, /)
            // ----------------------------------------------------------------------------------
            // Los botones de operador ya tenían un Size definido en tu código original, se mantiene.
            btn_suma.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_suma.Location = new Point(248, 184);
            btn_suma.Margin = new Padding(3, 4, 3, 4);
            btn_suma.Name = "btn_suma";
            btn_suma.Size = new Size(63, 51); // <--- Asegurando el tamaño
            btn_suma.TabIndex = 4;
            btn_suma.Text = "+";
            btn_suma.Click += btn_suma_Click;

            btn_restar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_restar.Location = new Point(248, 243);
            btn_restar.Margin = new Padding(3, 4, 3, 4);
            btn_restar.Name = "btn_restar";
            btn_restar.Size = new Size(63, 51); // <--- Asegurando el tamaño
            btn_restar.TabIndex = 7;
            btn_restar.Text = "-";
            btn_restar.Click += btn_restar_Click;

            btn_mult.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_mult.Location = new Point(248, 301);
            btn_mult.Margin = new Padding(3, 4, 3, 4);
            btn_mult.Name = "btn_mult";
            btn_mult.Size = new Size(63, 51); // <--- Asegurando el tamaño
            btn_mult.TabIndex = 6;
            btn_mult.Text = "x";
            btn_mult.Click += btn_mult_Click;

            btn_div.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_div.Location = new Point(248, 360);
            btn_div.Margin = new Padding(3, 4, 3, 4);
            btn_div.Name = "btn_div";
            btn_div.Size = new Size(63, 51); // <--- Asegurando el tamaño
            btn_div.TabIndex = 5;
            btn_div.Text = "/";
            btn_div.Click += btn_div_Click;

            // ----------------------------------------------------------------------------------
            // btn_resultado (Botón '=')
            // ----------------------------------------------------------------------------------
            btn_resultado.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_resultado.Location = new Point(248, 419);
            btn_resultado.Margin = new Padding(3, 4, 3, 4);
            btn_resultado.Name = "btn_resultado";
            btn_resultado.Size = new Size(63, 51);
            btn_resultado.TabIndex = 8;
            btn_resultado.Text = "=";
            btn_resultado.UseVisualStyleBackColor = true;
            btn_resultado.Click += btn_resultado_Click;

            // ----------------------------------------------------------------------------------
            // Botones Numéricos (AÑADIMOS LA PROPIEDAD Size para consistencia)
            // ----------------------------------------------------------------------------------
            // Fila 7, 8, 9
            btn_siete.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_siete.Location = new Point(16, 243);
            btn_siete.Margin = new Padding(3, 4, 3, 4);
            btn_siete.Name = "btn_siete";
            btn_siete.Size = new Size(63, 51); // <--- AÑADIDO
            btn_siete.Text = "7";
            btn_siete.Click += btn_siete_Click;

            btn_ocho.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_ocho.Location = new Point(96, 243);
            btn_ocho.Margin = new Padding(3, 4, 3, 4);
            btn_ocho.Name = "btn_ocho";
            btn_ocho.Size = new Size(63, 51); // <--- AÑADIDO
            btn_ocho.Text = "8";
            btn_ocho.Click += btn_ocho_Click;

            btn_nueve.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_nueve.Location = new Point(178, 243);
            btn_nueve.Margin = new Padding(3, 4, 3, 4);
            btn_nueve.Name = "btn_nueve";
            btn_nueve.Size = new Size(63, 51);
            btn_nueve.TabIndex = 11;
            btn_nueve.Text = "9";
            btn_nueve.UseVisualStyleBackColor = true;
            btn_nueve.Click += button3_Click; // Usa el manejador original

            // Fila 4, 5, 6
            btn_cuatro.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_cuatro.Location = new Point(16, 301);
            btn_cuatro.Margin = new Padding(3, 4, 3, 4);
            btn_cuatro.Name = "btn_cuatro";
            btn_cuatro.Size = new Size(63, 51); // <--- AÑADIDO
            btn_cuatro.Text = "4";
            btn_cuatro.Click += btn_cuatro_Click;

            btn_cinco.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_cinco.Location = new Point(96, 301);
            btn_cinco.Margin = new Padding(3, 4, 3, 4);
            btn_cinco.Name = "btn_cinco";
            btn_cinco.Size = new Size(63, 51); // <--- AÑADIDO
            btn_cinco.Text = "5";
            btn_cinco.Click += btn_cinco_Click;

            btn_seis.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_seis.Location = new Point(178, 301);
            btn_seis.Margin = new Padding(3, 4, 3, 4);
            btn_seis.Name = "btn_seis";
            btn_seis.Size = new Size(63, 51); // <--- AÑADIDO
            btn_seis.Text = "6";
            btn_seis.Click += btn_seis_Click;

            // Fila 1, 2, 3
            btn_uno.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_uno.Location = new Point(16, 360);
            btn_uno.Margin = new Padding(3, 4, 3, 4);
            btn_uno.Name = "btn_uno";
            btn_uno.Size = new Size(63, 51); // <--- AÑADIDO
            btn_uno.Text = "1";
            btn_uno.Click += btn_uno_Click;

            btn_dos.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_dos.Location = new Point(96, 360);
            btn_dos.Margin = new Padding(3, 4, 3, 4);
            btn_dos.Name = "btn_dos";
            btn_dos.Size = new Size(63, 51); // <--- AÑADIDO
            btn_dos.Text = "2";
            btn_dos.Click += btn_dos_Click;

            btn_tres.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_tres.Location = new Point(178, 360);
            btn_tres.Margin = new Padding(3, 4, 3, 4);
            btn_tres.Name = "btn_tres";
            btn_tres.Size = new Size(63, 51); // <--- AÑADIDO
            btn_tres.Text = "3";
            btn_tres.Click += btn_tres_Click;

            // Fila 0, .
            // Botón Cero (Ahora comparte espacio con el punto)
            btn_cero.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_cero.Location = new Point(16, 419);
            btn_cero.Margin = new Padding(3, 4, 3, 4);
            btn_cero.Name = "btn_cero";
            // TAMAÑO REDUCIDO y ajustado para que quepa el botón de punto.
            btn_cero.Size = new Size(155, 51);
            btn_cero.TabIndex = 18;
            btn_cero.Text = "0";
            btn_cero.UseVisualStyleBackColor = true;
            btn_cero.Click += btn_cero_Click;

            // btn_punto (Botón '.')
            btn_punto.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_punto.Location = new Point(178, 419);
            btn_punto.Margin = new Padding(3, 4, 3, 4);
            btn_punto.Name = "btn_punto";
            btn_punto.Size = new Size(63, 51);
            btn_punto.TabIndex = 19;
            btn_punto.Text = ".";
            btn_punto.UseVisualStyleBackColor = true;
            btn_punto.Click += btn_punto_Click;

            // ----------------------------------------------------------------------------------
            // 3. Configuración del Formulario (Form1)
            // ----------------------------------------------------------------------------------
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 484); // Tamaño del área del cliente (el formulario sin bordes).

            // Agrega todos los controles inicializados a la colección de controles del formulario.
            Controls.Add(btn_punto);
            Controls.Add(btn_cero);
            Controls.Add(btn_cuatro);
            Controls.Add(btn_uno);
            Controls.Add(btn_dos);
            Controls.Add(btn_tres);
            Controls.Add(btn_seis);
            Controls.Add(btn_cinco);
            Controls.Add(btn_nueve);
            Controls.Add(btn_ocho);
            Controls.Add(btn_siete);
            Controls.Add(btn_resultado);
            Controls.Add(btn_restar);
            Controls.Add(btn_mult);
            Controls.Add(btn_div);
            Controls.Add(btn_suma);
            Controls.Add(btn_borrar);
            Controls.Add(btn_LimpiarTodo);
            Controls.Add(txt_MostrarDatos);
            Controls.Add(lbl_CalculadoraBasica);

            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Calculadora";
            Load += Form1_Load;

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion // Fin de la región de código generado por el diseñador.
        
        private Label lbl_CalculadoraBasica;
        private TextBox txt_MostrarDatos;
        private Button btn_LimpiarTodo;
        private Button btn_borrar;
        private Button btn_suma;
        private Button btn_div;
        private Button btn_mult;
        private Button btn_restar;
        private Button btn_resultado;
        private Button btn_siete;
        private Button btn_ocho;
        private Button btn_nueve;
        private Button btn_cinco;
        private Button btn_seis;
        private Button btn_tres;
        private Button btn_dos;
        private Button btn_uno;
        private Button btn_cuatro;
        private Button btn_cero;
        private Button btn_punto;
    }
}