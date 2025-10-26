namespace ProyectCalculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            button3 = new Button();
            btn_cinco = new Button();
            btn_seis = new Button();
            btn_tres = new Button();
            btn_dos = new Button();
            btn_uno = new Button();
            btn_cuatro = new Button();
            btn_cero = new Button();
            SuspendLayout();
            // 
            // lbl_CalculadoraBasica
            // 
            lbl_CalculadoraBasica.AutoSize = true;
            lbl_CalculadoraBasica.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CalculadoraBasica.Location = new Point(3, 24);
            lbl_CalculadoraBasica.Name = "lbl_CalculadoraBasica";
            lbl_CalculadoraBasica.Size = new Size(210, 32);
            lbl_CalculadoraBasica.TabIndex = 0;
            lbl_CalculadoraBasica.Text = "Calculadora Básica";
            lbl_CalculadoraBasica.Click += lbl_CalculadoraBasica_Click;
            // 
            // txt_MostrarDatos
            // 
            txt_MostrarDatos.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_MostrarDatos.Location = new Point(14, 82);
            txt_MostrarDatos.Name = "txt_MostrarDatos";
            txt_MostrarDatos.Size = new Size(258, 35);
            txt_MostrarDatos.TabIndex = 1;
            txt_MostrarDatos.TextChanged += txt_MostrarDatos_TextChanged;
            // 
            // btn_LimpiarTodo
            // 
            btn_LimpiarTodo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_LimpiarTodo.Location = new Point(14, 137);
            btn_LimpiarTodo.Name = "btn_LimpiarTodo";
            btn_LimpiarTodo.Size = new Size(96, 39);
            btn_LimpiarTodo.TabIndex = 2;
            btn_LimpiarTodo.Text = "C";
            btn_LimpiarTodo.UseVisualStyleBackColor = true;
            btn_LimpiarTodo.Click += btn_LimpiarTodo_Click;
            // 
            // btn_borrar
            // 
            btn_borrar.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_borrar.Location = new Point(116, 137);
            btn_borrar.Name = "btn_borrar";
            btn_borrar.Size = new Size(95, 39);
            btn_borrar.TabIndex = 3;
            btn_borrar.Text = "←";
            btn_borrar.UseVisualStyleBackColor = true;
            // 
            // btn_suma
            // 
            btn_suma.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_suma.Location = new Point(217, 138);
            btn_suma.Name = "btn_suma";
            btn_suma.Size = new Size(55, 38);
            btn_suma.TabIndex = 4;
            btn_suma.Text = "+";
            btn_suma.UseVisualStyleBackColor = true;
            // 
            // btn_div
            // 
            btn_div.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_div.Location = new Point(217, 270);
            btn_div.Name = "btn_div";
            btn_div.Size = new Size(55, 38);
            btn_div.TabIndex = 5;
            btn_div.Text = "/";
            btn_div.UseVisualStyleBackColor = true;
            // 
            // btn_mult
            // 
            btn_mult.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_mult.Location = new Point(217, 226);
            btn_mult.Name = "btn_mult";
            btn_mult.Size = new Size(55, 38);
            btn_mult.TabIndex = 6;
            btn_mult.Text = "x";
            btn_mult.UseVisualStyleBackColor = true;
            // 
            // btn_restar
            // 
            btn_restar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_restar.Location = new Point(217, 182);
            btn_restar.Name = "btn_restar";
            btn_restar.Size = new Size(55, 38);
            btn_restar.TabIndex = 7;
            btn_restar.Text = "-";
            btn_restar.UseVisualStyleBackColor = true;
            // 
            // btn_resultado
            // 
            btn_resultado.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_resultado.Location = new Point(217, 314);
            btn_resultado.Name = "btn_resultado";
            btn_resultado.Size = new Size(55, 38);
            btn_resultado.TabIndex = 8;
            btn_resultado.Text = "=";
            btn_resultado.UseVisualStyleBackColor = true;
            // 
            // btn_siete
            // 
            btn_siete.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_siete.Location = new Point(14, 182);
            btn_siete.Name = "btn_siete";
            btn_siete.Size = new Size(55, 38);
            btn_siete.TabIndex = 9;
            btn_siete.Text = "7";
            btn_siete.UseVisualStyleBackColor = true;
            // 
            // btn_ocho
            // 
            btn_ocho.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_ocho.Location = new Point(84, 182);
            btn_ocho.Name = "btn_ocho";
            btn_ocho.Size = new Size(55, 38);
            btn_ocho.TabIndex = 10;
            btn_ocho.Text = "8";
            btn_ocho.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            button3.Location = new Point(156, 182);
            button3.Name = "button3";
            button3.Size = new Size(55, 38);
            button3.TabIndex = 11;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = true;
            // 
            // btn_cinco
            // 
            btn_cinco.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_cinco.Location = new Point(84, 226);
            btn_cinco.Name = "btn_cinco";
            btn_cinco.Size = new Size(55, 38);
            btn_cinco.TabIndex = 12;
            btn_cinco.Text = "5";
            btn_cinco.UseVisualStyleBackColor = true;
            // 
            // btn_seis
            // 
            btn_seis.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_seis.Location = new Point(156, 226);
            btn_seis.Name = "btn_seis";
            btn_seis.Size = new Size(55, 38);
            btn_seis.TabIndex = 13;
            btn_seis.Text = "6";
            btn_seis.UseVisualStyleBackColor = true;
            // 
            // btn_tres
            // 
            btn_tres.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_tres.Location = new Point(156, 270);
            btn_tres.Name = "btn_tres";
            btn_tres.Size = new Size(55, 38);
            btn_tres.TabIndex = 14;
            btn_tres.Text = "3";
            btn_tres.UseVisualStyleBackColor = true;
            // 
            // btn_dos
            // 
            btn_dos.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_dos.Location = new Point(84, 270);
            btn_dos.Name = "btn_dos";
            btn_dos.Size = new Size(55, 38);
            btn_dos.TabIndex = 15;
            btn_dos.Text = "2";
            btn_dos.UseVisualStyleBackColor = true;
            // 
            // btn_uno
            // 
            btn_uno.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_uno.Location = new Point(14, 270);
            btn_uno.Name = "btn_uno";
            btn_uno.Size = new Size(55, 38);
            btn_uno.TabIndex = 16;
            btn_uno.Text = "1";
            btn_uno.UseVisualStyleBackColor = true;
            // 
            // btn_cuatro
            // 
            btn_cuatro.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_cuatro.Location = new Point(14, 226);
            btn_cuatro.Name = "btn_cuatro";
            btn_cuatro.Size = new Size(55, 38);
            btn_cuatro.TabIndex = 17;
            btn_cuatro.Text = "4";
            btn_cuatro.UseVisualStyleBackColor = true;
            // 
            // btn_cero
            // 
            btn_cero.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btn_cero.Location = new Point(14, 314);
            btn_cero.Name = "btn_cero";
            btn_cero.Size = new Size(197, 38);
            btn_cero.TabIndex = 18;
            btn_cero.Text = "0";
            btn_cero.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 363);
            Controls.Add(btn_cero);
            Controls.Add(btn_cuatro);
            Controls.Add(btn_uno);
            Controls.Add(btn_dos);
            Controls.Add(btn_tres);
            Controls.Add(btn_seis);
            Controls.Add(btn_cinco);
            Controls.Add(button3);
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
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Button button3;
        private Button btn_cinco;
        private Button btn_seis;
        private Button btn_tres;
        private Button btn_dos;
        private Button btn_uno;
        private Button btn_cuatro;
        private Button btn_cero;
    }
}
