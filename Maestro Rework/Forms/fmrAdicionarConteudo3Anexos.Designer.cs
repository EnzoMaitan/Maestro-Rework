namespace Maestro_Rework.Forms
{
    partial class fmrAdicionarConteudo3Anexos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrAdicionarConteudo3Anexos));
            this.btnAdicionarAnexos = new System.Windows.Forms.Button();
            this.lblAnexos = new System.Windows.Forms.Label();
            this.btnCriar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.ofdArquivosAnexo = new System.Windows.Forms.OpenFileDialog();
            this.lstAnexoAdicionados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAdicionarAnexos
            // 
            this.btnAdicionarAnexos.AutoSize = true;
            this.btnAdicionarAnexos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdicionarAnexos.FlatAppearance.BorderSize = 0;
            this.btnAdicionarAnexos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarAnexos.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarAnexos.Image")));
            this.btnAdicionarAnexos.Location = new System.Drawing.Point(250, 260);
            this.btnAdicionarAnexos.Name = "btnAdicionarAnexos";
            this.btnAdicionarAnexos.Size = new System.Drawing.Size(38, 38);
            this.btnAdicionarAnexos.TabIndex = 18;
            this.btnAdicionarAnexos.UseVisualStyleBackColor = true;
            this.btnAdicionarAnexos.Click += new System.EventHandler(this.btnAdicionarAnexos_Click);
            // 
            // lblAnexos
            // 
            this.lblAnexos.AutoSize = true;
            this.lblAnexos.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnexos.Location = new System.Drawing.Point(379, 216);
            this.lblAnexos.Name = "lblAnexos";
            this.lblAnexos.Size = new System.Drawing.Size(144, 41);
            this.lblAnexos.TabIndex = 19;
            this.lblAnexos.Text = "Anexos";
            // 
            // btnCriar
            // 
            this.btnCriar.BackColor = System.Drawing.Color.Transparent;
            this.btnCriar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCriar.FlatAppearance.BorderSize = 0;
            this.btnCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCriar.Image = ((System.Drawing.Image)(resources.GetObject("btnCriar.Image")));
            this.btnCriar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCriar.Location = new System.Drawing.Point(671, 534);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(176, 39);
            this.btnCriar.TabIndex = 22;
            this.btnCriar.Text = "Criar ";
            this.btnCriar.UseVisualStyleBackColor = false;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
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
            this.btnVoltar.TabIndex = 23;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lstAnexoAdicionados
            // 
            this.lstAnexoAdicionados.FormattingEnabled = true;
            this.lstAnexoAdicionados.Location = new System.Drawing.Point(294, 267);
            this.lstAnexoAdicionados.Name = "lstAnexoAdicionados";
            this.lstAnexoAdicionados.Size = new System.Drawing.Size(315, 186);
            this.lstAnexoAdicionados.TabIndex = 24;
            // 
            // fmrAdicionarConteudo3Anexos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(859, 585);
            this.Controls.Add(this.lstAnexoAdicionados);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.lblAnexos);
            this.Controls.Add(this.btnAdicionarAnexos);
            this.DoubleBuffered = true;
            this.Name = "fmrAdicionarConteudo3Anexos";
            this.Text = "Anexos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionarAnexos;
        private System.Windows.Forms.Label lblAnexos;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.OpenFileDialog ofdArquivosAnexo;
        private System.Windows.Forms.ListBox lstAnexoAdicionados;
    }
}