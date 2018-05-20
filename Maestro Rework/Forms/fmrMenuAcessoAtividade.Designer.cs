namespace Maestro_Rework.Forms
{
    partial class fmrMenuAcessoAtividade
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lstAtividadesDisponiveis = new System.Windows.Forms.ListBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.lblAtividadesDesponiveis = new System.Windows.Forms.Label();
            this.txtCodigoAcesso = new System.Windows.Forms.TextBox();
            this.btnDestravar = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lstInformacoes = new System.Windows.Forms.ListBox();
            this.lblErro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.ForeColor = System.Drawing.Color.Black;
            this.lblCodigo.Location = new System.Drawing.Point(117, 122);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(112, 32);
            this.lblCodigo.TabIndex = 16;
            this.lblCodigo.Text = "Código";
            // 
            // lstAtividadesDisponiveis
            // 
            this.lstAtividadesDisponiveis.FormattingEnabled = true;
            this.lstAtividadesDisponiveis.Location = new System.Drawing.Point(438, 121);
            this.lstAtividadesDisponiveis.Name = "lstAtividadesDisponiveis";
            this.lstAtividadesDisponiveis.Size = new System.Drawing.Size(409, 381);
            this.lstAtividadesDisponiveis.TabIndex = 14;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(12, 523);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(145, 50);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAcessar
            // 
            this.btnAcessar.BackColor = System.Drawing.Color.Transparent;
            this.btnAcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcessar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAcessar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAcessar.Location = new System.Drawing.Point(697, 523);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(150, 50);
            this.btnAcessar.TabIndex = 12;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = false;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // lblAtividadesDesponiveis
            // 
            this.lblAtividadesDesponiveis.AutoSize = true;
            this.lblAtividadesDesponiveis.BackColor = System.Drawing.Color.Transparent;
            this.lblAtividadesDesponiveis.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblAtividadesDesponiveis.ForeColor = System.Drawing.Color.Black;
            this.lblAtividadesDesponiveis.Location = new System.Drawing.Point(432, 87);
            this.lblAtividadesDesponiveis.Name = "lblAtividadesDesponiveis";
            this.lblAtividadesDesponiveis.Size = new System.Drawing.Size(309, 32);
            this.lblAtividadesDesponiveis.TabIndex = 11;
            this.lblAtividadesDesponiveis.Text = "Conteúdos Disponíveis";
            // 
            // txtCodigoAcesso
            // 
            this.txtCodigoAcesso.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoAcesso.Location = new System.Drawing.Point(69, 157);
            this.txtCodigoAcesso.Name = "txtCodigoAcesso";
            this.txtCodigoAcesso.Size = new System.Drawing.Size(202, 32);
            this.txtCodigoAcesso.TabIndex = 10;
            // 
            // btnDestravar
            // 
            this.btnDestravar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDestravar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnDestravar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDestravar.Location = new System.Drawing.Point(105, 214);
            this.btnDestravar.Name = "btnDestravar";
            this.btnDestravar.Size = new System.Drawing.Size(124, 30);
            this.btnDestravar.TabIndex = 9;
            this.btnDestravar.Text = "Destravar";
            this.btnDestravar.UseVisualStyleBackColor = false;
            this.btnDestravar.Click += new System.EventHandler(this.btnDestravar_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.lbl1.Location = new System.Drawing.Point(78, 192);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(182, 19);
            this.lbl1.TabIndex = 17;
            this.lbl1.Text = "Insira o código de Acesso";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.lbl2.Location = new System.Drawing.Point(47, 286);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(194, 23);
            this.lbl2.TabIndex = 18;
            this.lbl2.Text = "Anexos Disponíveis";
            // 
            // lstInformacoes
            // 
            this.lstInformacoes.FormattingEnabled = true;
            this.lstInformacoes.Location = new System.Drawing.Point(12, 312);
            this.lstInformacoes.Name = "lstInformacoes";
            this.lstInformacoes.Size = new System.Drawing.Size(313, 173);
            this.lstInformacoes.TabIndex = 19;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblErro.ForeColor = System.Drawing.Color.Coral;
            this.lblErro.Location = new System.Drawing.Point(43, 240);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(56, 21);
            this.lblErro.TabIndex = 20;
            this.lblErro.Text = "lblErro";
            // 
            // fmrMenuAcessoAtividade
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(252)))));
            this.BackgroundImage = global::Maestro_Rework.Properties.Resources.a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(859, 585);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.lstInformacoes);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lstAtividadesDisponiveis);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAcessar);
            this.Controls.Add(this.lblAtividadesDesponiveis);
            this.Controls.Add(this.txtCodigoAcesso);
            this.Controls.Add(this.btnDestravar);
            this.DoubleBuffered = true;
            this.Name = "fmrMenuAcessoAtividade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fmrMenuAtividade";
            this.Load += new System.EventHandler(this.fmrMenuAcessoAtividade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ListBox lstAtividadesDisponiveis;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.Label lblAtividadesDesponiveis;
        private System.Windows.Forms.TextBox txtCodigoAcesso;
        private System.Windows.Forms.Button btnDestravar;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.ListBox lstInformacoes;
        private System.Windows.Forms.Label lblErro;
    }
}