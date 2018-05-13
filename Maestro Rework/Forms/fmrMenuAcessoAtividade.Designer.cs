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
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCodigo.Location = new System.Drawing.Point(346, 61);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(106, 31);
            this.lblCodigo.TabIndex = 16;
            this.lblCodigo.Text = "Código";
            // 
            // lstAtividadesDisponiveis
            // 
            this.lstAtividadesDisponiveis.FormattingEnabled = true;
            this.lstAtividadesDisponiveis.Location = new System.Drawing.Point(215, 242);
            this.lstAtividadesDisponiveis.Name = "lstAtividadesDisponiveis";
            this.lstAtividadesDisponiveis.Size = new System.Drawing.Size(409, 199);
            this.lstAtividadesDisponiveis.TabIndex = 14;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Coral;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(520, 521);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(144, 37);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAcessar
            // 
            this.btnAcessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(82)))));
            this.btnAcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAcessar.Location = new System.Drawing.Point(670, 521);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(144, 37);
            this.btnAcessar.TabIndex = 12;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = false;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // lblAtividadesDesponiveis
            // 
            this.lblAtividadesDesponiveis.AutoSize = true;
            this.lblAtividadesDesponiveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtividadesDesponiveis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAtividadesDesponiveis.Location = new System.Drawing.Point(209, 206);
            this.lblAtividadesDesponiveis.Name = "lblAtividadesDesponiveis";
            this.lblAtividadesDesponiveis.Size = new System.Drawing.Size(314, 31);
            this.lblAtividadesDesponiveis.TabIndex = 11;
            this.lblAtividadesDesponiveis.Text = "Conteúdos Disponíveis";
            // 
            // txtCodigoAcesso
            // 
            this.txtCodigoAcesso.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoAcesso.Location = new System.Drawing.Point(329, 97);
            this.txtCodigoAcesso.Name = "txtCodigoAcesso";
            this.txtCodigoAcesso.Size = new System.Drawing.Size(150, 32);
            this.txtCodigoAcesso.TabIndex = 10;
            // 
            // btnDestravar
            // 
            this.btnDestravar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDestravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDestravar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDestravar.Location = new System.Drawing.Point(340, 135);
            this.btnDestravar.Name = "btnDestravar";
            this.btnDestravar.Size = new System.Drawing.Size(124, 30);
            this.btnDestravar.TabIndex = 9;
            this.btnDestravar.Text = "Destravar";
            this.btnDestravar.UseVisualStyleBackColor = false;
            // 
            // fmrMenuAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 585);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lstAtividadesDisponiveis);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAcessar);
            this.Controls.Add(this.lblAtividadesDesponiveis);
            this.Controls.Add(this.txtCodigoAcesso);
            this.Controls.Add(this.btnDestravar);
            this.Name = "fmrMenuAtividade";
            this.Text = "fmrMenuAtividade";
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
    }
}