namespace UIChatgpt
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.txtPrompt = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(24, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(258, 28);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ChatGPT – Cliente WinForms";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEstado.ForeColor = System.Drawing.Color.DimGray;
            this.lblEstado.Location = new System.Drawing.Point(24, 56);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 20);
            this.lblEstado.TabIndex = 1;
            this.lblEstado.Text = "Listo";
            // 
            // txtChat
            // 
            this.txtChat.Location = new System.Drawing.Point(28, 86);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.ReadOnly = true;
            this.txtChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChat.Size = new System.Drawing.Size(600, 420);
            this.txtChat.TabIndex = 2;
            // 
            // txtPrompt
            // 
            this.txtPrompt.Location = new System.Drawing.Point(28, 520);
            this.txtPrompt.Multiline = true;
            this.txtPrompt.Name = "txtPrompt";
            this.txtPrompt.Size = new System.Drawing.Size(480, 80);
            this.txtPrompt.TabIndex = 3;
            this.txtPrompt.Text = "Inicia con un mensaje...";
            this.txtPrompt.Click += new System.EventHandler(this.txtPrompt_Click);
            this.txtPrompt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrompt_KeyDown);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(520, 520);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(108, 36);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(520, 564);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 36);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCopiar (opcional)
            // 
            this.btnCopiar.Location = new System.Drawing.Point(28, 610);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(108, 30);
            this.btnCopiar.TabIndex = 6;
            this.btnCopiar.Text = "Copiar último";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(664, 660);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtPrompt);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatGPT – Cliente WinForms";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.TextBox txtPrompt;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCopiar;
    }
}
