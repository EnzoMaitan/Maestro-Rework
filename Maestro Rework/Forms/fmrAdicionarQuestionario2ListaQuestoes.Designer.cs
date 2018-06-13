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
            this.btnConcluir = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.dtgQuestoes = new System.Windows.Forms.DataGridView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblCliqueAdicionar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgQuestoes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConcluir
            // 
            this.btnConcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnConcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConcluir.FlatAppearance.BorderSize = 0;
            this.btnConcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcluir.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcluir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnConcluir.Image")));
            this.btnConcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConcluir.Location = new System.Drawing.Point(671, 534);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(176, 39);
            this.btnConcluir.TabIndex = 8;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = false;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
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
            this.dtgQuestoes.Location = new System.Drawing.Point(102, 47);
            this.dtgQuestoes.Name = "dtgQuestoes";
            this.dtgQuestoes.Size = new System.Drawing.Size(631, 481);
            this.dtgQuestoes.TabIndex = 10;
            this.dtgQuestoes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grd_CellClick);
            this.dtgQuestoes.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView1_CellPainting);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.AutoSize = true;
            this.btnAdicionar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(695, 3);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(38, 38);
            this.btnAdicionar.TabIndex = 12;
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblCliqueAdicionar
            // 
            this.lblCliqueAdicionar.AutoSize = true;
            this.lblCliqueAdicionar.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblCliqueAdicionar.ForeColor = System.Drawing.Color.Black;
            this.lblCliqueAdicionar.Location = new System.Drawing.Point(412, 9);
            this.lblCliqueAdicionar.Name = "lblCliqueAdicionar";
            this.lblCliqueAdicionar.Size = new System.Drawing.Size(277, 25);
            this.lblCliqueAdicionar.TabIndex = 13;
            this.lblCliqueAdicionar.Text = "Adicionar Nova Questão";
            this.lblCliqueAdicionar.Click += new System.EventHandler(this.lblCliqueAdicionar_Click);
            // 
            // fmrAdicionarQuestionario2ListaQuestoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(859, 585);
            this.Controls.Add(this.lblCliqueAdicionar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.dtgQuestoes);
            this.Controls.Add(this.btnConcluir);
            this.Controls.Add(this.btnVoltar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "fmrAdicionarQuestionario2ListaQuestoes";
            this.Text = "fmrListaQuestionarios";
            ((System.ComponentModel.ISupportInitialize)(this.dtgQuestoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConcluir;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridView dtgQuestoes;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblCliqueAdicionar;
    }
}