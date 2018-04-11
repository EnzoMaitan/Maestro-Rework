namespace Maestro_Rework.Forms
{
    partial class fmrGerenciarAtividade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrGerenciarAtividade));
            this.btnAdicionarNovo = new System.Windows.Forms.Button();
            this.btnGerenciar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblTipoDeAtividade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdicionarNovo
            // 
            this.btnAdicionarNovo.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionarNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdicionarNovo.FlatAppearance.BorderSize = 0;
            this.btnAdicionarNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarNovo.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarNovo.Image")));
            this.btnAdicionarNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarNovo.Location = new System.Drawing.Point(245, 145);
            this.btnAdicionarNovo.Name = "btnAdicionarNovo";
            this.btnAdicionarNovo.Size = new System.Drawing.Size(446, 130);
            this.btnAdicionarNovo.TabIndex = 0;
            this.btnAdicionarNovo.Text = "Novo";
            this.btnAdicionarNovo.UseVisualStyleBackColor = false;
            this.btnAdicionarNovo.Click += new System.EventHandler(this.btnAdicionarNovo_Click);
            // 
            // btnGerenciar
            // 
            this.btnGerenciar.BackColor = System.Drawing.Color.Transparent;
            this.btnGerenciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGerenciar.FlatAppearance.BorderSize = 0;
            this.btnGerenciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerenciar.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciar.Image = ((System.Drawing.Image)(resources.GetObject("btnGerenciar.Image")));
            this.btnGerenciar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerenciar.Location = new System.Drawing.Point(245, 281);
            this.btnGerenciar.Name = "btnGerenciar";
            this.btnGerenciar.Size = new System.Drawing.Size(446, 130);
            this.btnGerenciar.TabIndex = 1;
            this.btnGerenciar.Text = "Gerenciar";
            this.btnGerenciar.UseVisualStyleBackColor = false;
            this.btnGerenciar.Click += new System.EventHandler(this.btnGerenciar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(12, 534);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(154, 39);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // lblTipoDeAtividade
            // 
            this.lblTipoDeAtividade.AutoSize = true;
            this.lblTipoDeAtividade.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.lblTipoDeAtividade.Location = new System.Drawing.Point(312, 94);
            this.lblTipoDeAtividade.Name = "lblTipoDeAtividade";
            this.lblTipoDeAtividade.Size = new System.Drawing.Size(239, 33);
            this.lblTipoDeAtividade.TabIndex = 2;
            this.lblTipoDeAtividade.Text = "TIPODEATIVIDADE";
            // 
            // fmrGerenciarAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(859, 585);
            this.Controls.Add(this.lblTipoDeAtividade);
            this.Controls.Add(this.btnGerenciar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAdicionarNovo);
            this.Name = "fmrGerenciarAtividade";
            this.Text = "Gerenciar";
            this.Load += new System.EventHandler(this.fmrGerencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarNovo;
        private System.Windows.Forms.Button btnGerenciar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblTipoDeAtividade;
    }
}