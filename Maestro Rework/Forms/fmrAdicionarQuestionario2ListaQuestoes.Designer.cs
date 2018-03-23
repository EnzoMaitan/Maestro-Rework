namespace Maestro_Rework.Forms
{
    partial class fmrAdicionarQuestionario2ListaQuestoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrAdicionarQuestionario2ListaQuestoes));
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dtgQuestoes = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgQuestoes)).BeginInit();
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
            this.btnAvancar.TabIndex = 8;
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
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dtgQuestoes
            // 
            this.dtgQuestoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgQuestoes.Location = new System.Drawing.Point(102, 22);
            this.dtgQuestoes.Name = "dtgQuestoes";
            this.dtgQuestoes.Size = new System.Drawing.Size(631, 506);
            this.dtgQuestoes.TabIndex = 10;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.AutoSize = true;
            this.btnAdicionar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(739, 22);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(38, 38);
            this.btnAdicionar.TabIndex = 12;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // fmrAdicionarQuestionario2ListaQuestoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(859, 585);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dtgQuestoes);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.btnVoltar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "fmrAdicionarQuestionario2ListaQuestoes";
            this.Text = "fmrListaQuestionarios";
            ((System.ComponentModel.ISupportInitialize)(this.dtgQuestoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dtgQuestoes;
        private System.Windows.Forms.Button btnAdicionar;
    }
}