namespace Maestro_Rework.Forms
{
    partial class fmrAcessarConteudo
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
            this.btnVisualizarAnexo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblAnexos = new System.Windows.Forms.Label();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVisualizarAnexo
            // 
            this.btnVisualizarAnexo.Location = new System.Drawing.Point(751, 194);
            this.btnVisualizarAnexo.Name = "btnVisualizarAnexo";
            this.btnVisualizarAnexo.Size = new System.Drawing.Size(75, 23);
            this.btnVisualizarAnexo.TabIndex = 0;
            this.btnVisualizarAnexo.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.btnSair.Location = new System.Drawing.Point(748, 347);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(78, 29);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblAnexos
            // 
            this.lblAnexos.AutoSize = true;
            this.lblAnexos.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.lblAnexos.Location = new System.Drawing.Point(756, 172);
            this.lblAnexos.Name = "lblAnexos";
            this.lblAnexos.Size = new System.Drawing.Size(61, 19);
            this.lblAnexos.TabIndex = 2;
            this.lblAnexos.Text = "Anexos:";
            // 
            // txtConteudo
            // 
            this.txtConteudo.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.txtConteudo.Location = new System.Drawing.Point(54, 42);
            this.txtConteudo.Multiline = true;
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(673, 511);
            this.txtConteudo.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Century Gothic", 25F);
            this.lblNome.Location = new System.Drawing.Point(144, -1);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(116, 40);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "label1";
            // 
            // fmrAcessarConteudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(859, 585);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.lblAnexos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnVisualizarAnexo);
            this.Name = "fmrAcessarConteudo";
            this.Text = "fmrAcessarConteudo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVisualizarAnexo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblAnexos;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.Label lblNome;
    }
}