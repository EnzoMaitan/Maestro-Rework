namespace Maestro_Rework.Forms
{
    partial class fmrConfirmarAcessoQuestionario
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPrazo = new System.Windows.Forms.Label();
            this.lblNumeroTentativas = new System.Windows.Forms.Label();
            this.lblTentativasRestantes = new System.Windows.Forms.Label();
            this.lblNotaAnterior = new System.Windows.Forms.Label();
            this.lblRegra = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIniciar.Location = new System.Drawing.Point(440, 471);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(112, 39);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Coral;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btnCancelar.Location = new System.Drawing.Point(290, 471);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 39);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.lblTitulo.Location = new System.Drawing.Point(148, 129);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(89, 33);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Titulo:";
            // 
            // lblPrazo
            // 
            this.lblPrazo.AutoSize = true;
            this.lblPrazo.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.lblPrazo.Location = new System.Drawing.Point(148, 184);
            this.lblPrazo.Name = "lblPrazo";
            this.lblPrazo.Size = new System.Drawing.Size(93, 33);
            this.lblPrazo.TabIndex = 3;
            this.lblPrazo.Text = "Prazo:";
            // 
            // lblNumeroTentativas
            // 
            this.lblNumeroTentativas.AutoSize = true;
            this.lblNumeroTentativas.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.lblNumeroTentativas.Location = new System.Drawing.Point(148, 240);
            this.lblNumeroTentativas.Name = "lblNumeroTentativas";
            this.lblNumeroTentativas.Size = new System.Drawing.Size(312, 33);
            this.lblNumeroTentativas.TabIndex = 4;
            this.lblNumeroTentativas.Text = "Número de tentativas:";
            // 
            // lblTentativasRestantes
            // 
            this.lblTentativasRestantes.AutoSize = true;
            this.lblTentativasRestantes.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.lblTentativasRestantes.Location = new System.Drawing.Point(148, 293);
            this.lblTentativasRestantes.Name = "lblTentativasRestantes";
            this.lblTentativasRestantes.Size = new System.Drawing.Size(289, 33);
            this.lblTentativasRestantes.TabIndex = 5;
            this.lblTentativasRestantes.Text = "Tentativas Restantes:";
            // 
            // lblNotaAnterior
            // 
            this.lblNotaAnterior.AutoSize = true;
            this.lblNotaAnterior.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.lblNotaAnterior.Location = new System.Drawing.Point(148, 342);
            this.lblNotaAnterior.Name = "lblNotaAnterior";
            this.lblNotaAnterior.Size = new System.Drawing.Size(198, 33);
            this.lblNotaAnterior.TabIndex = 6;
            this.lblNotaAnterior.Text = "Nota Anterior:";
            // 
            // lblRegra
            // 
            this.lblRegra.AutoSize = true;
            this.lblRegra.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblRegra.Location = new System.Drawing.Point(250, 524);
            this.lblRegra.Name = "lblRegra";
            this.lblRegra.Size = new System.Drawing.Size(357, 21);
            this.lblRegra.TabIndex = 7;
            this.lblRegra.Text = "Uma vez iniciado, o teste deve ser finalizado!";
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblErro.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblErro.ForeColor = System.Drawing.Color.Coral;
            this.lblErro.Location = new System.Drawing.Point(289, 409);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(57, 21);
            this.lblErro.TabIndex = 8;
            this.lblErro.Text = "label1";
            // 
            // fmrConfirmarAcessoQuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(859, 585);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.lblRegra);
            this.Controls.Add(this.lblNotaAnterior);
            this.Controls.Add(this.lblTentativasRestantes);
            this.Controls.Add(this.lblNumeroTentativas);
            this.Controls.Add(this.lblPrazo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIniciar);
            this.Name = "fmrConfirmarAcessoQuestionario";
            this.Text = "fmrConfirmarAcessoQuestionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPrazo;
        private System.Windows.Forms.Label lblNumeroTentativas;
        private System.Windows.Forms.Label lblTentativasRestantes;
        private System.Windows.Forms.Label lblNotaAnterior;
        private System.Windows.Forms.Label lblRegra;
        private System.Windows.Forms.Label lblErro;
    }
}