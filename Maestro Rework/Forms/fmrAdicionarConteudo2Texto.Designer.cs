namespace Maestro_Rework.Forms
{
    partial class fmrAdicionarConteudo2Texto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrAdicionarConteudo2Texto));
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.rtfTextoConteudo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnAvancar
            // 
            this.btnAvancar.BackColor = System.Drawing.Color.Transparent;
            this.btnAvancar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAvancar.FlatAppearance.BorderSize = 0;
            this.btnAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAvancar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvancar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAvancar.Image = ((System.Drawing.Image)(resources.GetObject("btnAvancar.Image")));
            this.btnAvancar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAvancar.Location = new System.Drawing.Point(671, 534);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(176, 39);
            this.btnAvancar.TabIndex = 5;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.UseVisualStyleBackColor = false;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
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
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // rtfTextoConteudo
            // 
            this.rtfTextoConteudo.Location = new System.Drawing.Point(12, 12);
            this.rtfTextoConteudo.Name = "rtfTextoConteudo";
            this.rtfTextoConteudo.Size = new System.Drawing.Size(835, 516);
            this.rtfTextoConteudo.TabIndex = 7;
            this.rtfTextoConteudo.Text = "";
            // 
            // fmrAdicionarConteudo2Texto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(859, 585);
            this.Controls.Add(this.rtfTextoConteudo);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.btnVoltar);
            this.Name = "fmrAdicionarConteudo2Texto";
            this.Text = "frmAdicionarConteudo2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.RichTextBox rtfTextoConteudo;
    }
}