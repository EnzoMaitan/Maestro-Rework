namespace Maestro_Rework.Forms
{
    partial class fmrAdicionarConteudo1Titulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrAdicionarConteudo1Titulo));
            this.ofdImagemDeCapa = new System.Windows.Forms.OpenFileDialog();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblImg = new System.Windows.Forms.Label();
            this.txtImagemDeCapa = new System.Windows.Forms.TextBox();
            this.btnAdicionarImagem = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.lblTema = new System.Windows.Forms.Label();
            this.cboTema = new System.Windows.Forms.ComboBox();
            this.lblErro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(387, 76);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(102, 41);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(274, 120);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(315, 38);
            this.txtTitulo.TabIndex = 0;
            // 
            // lblImg
            // 
            this.lblImg.AutoSize = true;
            this.lblImg.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImg.Location = new System.Drawing.Point(298, 290);
            this.lblImg.Name = "lblImg";
            this.lblImg.Size = new System.Drawing.Size(268, 36);
            this.lblImg.TabIndex = 2;
            this.lblImg.Text = "Imagem de Capa";
            // 
            // txtImagemDeCapa
            // 
            this.txtImagemDeCapa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImagemDeCapa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImagemDeCapa.Location = new System.Drawing.Point(278, 354);
            this.txtImagemDeCapa.Name = "txtImagemDeCapa";
            this.txtImagemDeCapa.ReadOnly = true;
            this.txtImagemDeCapa.Size = new System.Drawing.Size(315, 31);
            this.txtImagemDeCapa.TabIndex = 1;
            this.txtImagemDeCapa.TabStop = false;
            // 
            // btnAdicionarImagem
            // 
            this.btnAdicionarImagem.AutoSize = true;
            this.btnAdicionarImagem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAdicionarImagem.FlatAppearance.BorderSize = 0;
            this.btnAdicionarImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarImagem.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarImagem.Image")));
            this.btnAdicionarImagem.Location = new System.Drawing.Point(219, 347);
            this.btnAdicionarImagem.Name = "btnAdicionarImagem";
            this.btnAdicionarImagem.Size = new System.Drawing.Size(38, 38);
            this.btnAdicionarImagem.TabIndex = 2;
            this.btnAdicionarImagem.UseVisualStyleBackColor = true;
            this.btnAdicionarImagem.Click += new System.EventHandler(this.btnAdicionarImagem_Click);
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
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
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
            this.btnAvancar.TabIndex = 4;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.UseVisualStyleBackColor = false;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTema.Location = new System.Drawing.Point(387, 186);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(111, 41);
            this.lblTema.TabIndex = 5;
            this.lblTema.Text = "Tema";
            // 
            // cboTema
            // 
            this.cboTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.cboTema.FormattingEnabled = true;
            this.cboTema.Location = new System.Drawing.Point(274, 230);
            this.cboTema.Name = "cboTema";
            this.cboTema.Size = new System.Drawing.Size(315, 39);
            this.cboTema.TabIndex = 1;
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Location = new System.Drawing.Point(414, 388);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(48, 13);
            this.lblErro.TabIndex = 7;
            this.lblErro.Text = "lblERRO";
            // 
            // fmrAdicionarConteudo1Titulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 585);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.cboTema);
            this.Controls.Add(this.lblTema);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnAdicionarImagem);
            this.Controls.Add(this.lblImg);
            this.Controls.Add(this.txtImagemDeCapa);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "fmrAdicionarConteudo1Titulo";
            this.Text = "fmrAdicionarConteudo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofdImagemDeCapa;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblImg;
        private System.Windows.Forms.TextBox txtImagemDeCapa;
        private System.Windows.Forms.Button btnAdicionarImagem;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.ComboBox cboTema;
        private System.Windows.Forms.Label lblErro;
    }
}