namespace Maestro_Rework.Forms
{
    partial class fmrRecuperarSenha1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAlterarSenha = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.txtEmail.Location = new System.Drawing.Point(237, 193);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(233, 35);
            this.txtEmail.TabIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 17F);
            this.txtCodigo.Location = new System.Drawing.Point(237, 306);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(233, 35);
            this.txtCodigo.TabIndex = 2;
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarEmail.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnEnviarEmail.Location = new System.Drawing.Point(250, 234);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(90, 29);
            this.btnEnviarEmail.TabIndex = 1;
            this.btnEnviarEmail.Text = "Enviar Email";
            this.btnEnviarEmail.UseVisualStyleBackColor = true;
            this.btnEnviarEmail.Click += new System.EventHandler(this.btnEnviarEmail_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnVoltar.Location = new System.Drawing.Point(12, 494);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(176, 39);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnAvancar
            // 
            this.btnAvancar.BackColor = System.Drawing.Color.Transparent;
            this.btnAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvancar.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.btnAvancar.Location = new System.Drawing.Point(540, 494);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(176, 39);
            this.btnAvancar.TabIndex = 3;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.UseVisualStyleBackColor = false;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 22F);
            this.lblEmail.Location = new System.Drawing.Point(243, 153);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(94, 37);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 22F);
            this.lblCodigo.Location = new System.Drawing.Point(243, 266);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(129, 37);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "Código";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(10)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.lblAlterarSenha);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 110);
            this.panel1.TabIndex = 15;
            // 
            // lblAlterarSenha
            // 
            this.lblAlterarSenha.AutoSize = true;
            this.lblAlterarSenha.Font = new System.Drawing.Font("Century Gothic", 40F);
            this.lblAlterarSenha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAlterarSenha.Location = new System.Drawing.Point(201, 19);
            this.lblAlterarSenha.Name = "lblAlterarSenha";
            this.lblAlterarSenha.Size = new System.Drawing.Size(381, 65);
            this.lblAlterarSenha.TabIndex = 0;
            this.lblAlterarSenha.Text = "Alterar Senha";
            // 
            // fmrRecuperarSenha1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(728, 545);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnEnviarEmail);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtEmail);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "fmrRecuperarSenha1";
            this.Text = "fmrRecuperarSenha1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnEnviarEmail;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAlterarSenha;
    }
}