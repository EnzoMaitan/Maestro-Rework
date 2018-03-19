namespace Maestro_Rework.Forms
{
    partial class fmrAdicionarConteudo
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
            this.lblConteudoAdicionado = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblConteudo = new System.Windows.Forms.Label();
            this.cboSelecionar = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnApagarAnexos = new System.Windows.Forms.Button();
            this.btnImg = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lstAnexoAdicionados = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboTema = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnArquivos = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rtfTexto = new System.Windows.Forms.RichTextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAcao = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblErro = new System.Windows.Forms.Label();
            this.ofdArquivosAnexo = new System.Windows.Forms.OpenFileDialog();
            this.ofdImagemDeCapa = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lblConteudoAdicionado
            // 
            this.lblConteudoAdicionado.AutoSize = true;
            this.lblConteudoAdicionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConteudoAdicionado.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblConteudoAdicionado.Location = new System.Drawing.Point(293, 465);
            this.lblConteudoAdicionado.Name = "lblConteudoAdicionado";
            this.lblConteudoAdicionado.Size = new System.Drawing.Size(219, 24);
            this.lblConteudoAdicionado.TabIndex = 71;
            this.lblConteudoAdicionado.Text = "Conteudo Adicionado!";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(269, 494);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 24);
            this.label10.TabIndex = 70;
            this.label10.Text = "Código";
            // 
            // lblConteudo
            // 
            this.lblConteudo.AutoSize = true;
            this.lblConteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConteudo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblConteudo.Location = new System.Drawing.Point(35, 34);
            this.lblConteudo.Name = "lblConteudo";
            this.lblConteudo.Size = new System.Drawing.Size(101, 24);
            this.lblConteudo.TabIndex = 69;
            this.lblConteudo.Text = "Conteúdo";
            // 
            // cboSelecionar
            // 
            this.cboSelecionar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelecionar.FormattingEnabled = true;
            this.cboSelecionar.Location = new System.Drawing.Point(148, 31);
            this.cboSelecionar.Name = "cboSelecionar";
            this.cboSelecionar.Size = new System.Drawing.Size(145, 30);
            this.cboSelecionar.TabIndex = 68;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(358, 494);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(154, 20);
            this.txtCodigo.TabIndex = 67;
            // 
            // btnApagarAnexos
            // 
            this.btnApagarAnexos.BackColor = System.Drawing.Color.Coral;
            this.btnApagarAnexos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagarAnexos.ForeColor = System.Drawing.Color.White;
            this.btnApagarAnexos.Location = new System.Drawing.Point(123, 296);
            this.btnApagarAnexos.Name = "btnApagarAnexos";
            this.btnApagarAnexos.Size = new System.Drawing.Size(97, 23);
            this.btnApagarAnexos.TabIndex = 66;
            this.btnApagarAnexos.Text = "Apagar";
            this.btnApagarAnexos.UseVisualStyleBackColor = false;
            this.btnApagarAnexos.Click += new System.EventHandler(this.btnApagarAnexos_Click);
            // 
            // btnImg
            // 
            this.btnImg.Location = new System.Drawing.Point(189, 174);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(33, 23);
            this.btnImg.TabIndex = 65;
            this.btnImg.UseVisualStyleBackColor = true;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(13, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 24);
            this.label8.TabIndex = 64;
            this.label8.Text = "Imagem de Capa";
            // 
            // lstAnexoAdicionados
            // 
            this.lstAnexoAdicionados.FormattingEnabled = true;
            this.lstAnexoAdicionados.Location = new System.Drawing.Point(17, 247);
            this.lstAnexoAdicionados.Name = "lstAnexoAdicionados";
            this.lstAnexoAdicionados.Size = new System.Drawing.Size(203, 43);
            this.lstAnexoAdicionados.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(13, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 24);
            this.label7.TabIndex = 62;
            this.label7.Text = "*Tema";
            // 
            // cboTema
            // 
            this.cboTema.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTema.FormattingEnabled = true;
            this.cboTema.Location = new System.Drawing.Point(93, 115);
            this.cboTema.Name = "cboTema";
            this.cboTema.Size = new System.Drawing.Size(153, 30);
            this.cboTema.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(345, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 24);
            this.label6.TabIndex = 60;
            this.label6.Text = "Criar conteúdo";
            // 
            // btnArquivos
            // 
            this.btnArquivos.Location = new System.Drawing.Point(189, 209);
            this.btnArquivos.Name = "btnArquivos";
            this.btnArquivos.Size = new System.Drawing.Size(33, 23);
            this.btnArquivos.TabIndex = 59;
            this.btnArquivos.UseVisualStyleBackColor = true;
            this.btnArquivos.Click += new System.EventHandler(this.btnArquivos_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(13, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 24);
            this.label5.TabIndex = 58;
            this.label5.Text = "Importar Anexo";
            // 
            // rtfTexto
            // 
            this.rtfTexto.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfTexto.Location = new System.Drawing.Point(427, 114);
            this.rtfTexto.Name = "rtfTexto";
            this.rtfTexto.Size = new System.Drawing.Size(427, 338);
            this.rtfTexto.TabIndex = 51;
            this.rtfTexto.Text = "";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Coral;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Location = new System.Drawing.Point(602, 479);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(123, 32);
            this.btnSair.TabIndex = 53;
            this.btnSair.Text = "Cancelar";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // btnAcao
            // 
            this.btnAcao.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAcao.Location = new System.Drawing.Point(731, 479);
            this.btnAcao.Name = "btnAcao";
            this.btnAcao.Size = new System.Drawing.Size(123, 32);
            this.btnAcao.TabIndex = 52;
            this.btnAcao.Text = "Criar";
            this.btnAcao.UseVisualStyleBackColor = false;
            this.btnAcao.Click += new System.EventHandler(this.btnAcao_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(93, 74);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(248, 29);
            this.txtNome.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(598, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 50;
            this.label2.Text = "*Conteúdo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 47;
            this.label1.Text = "*Titulo";
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblErro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblErro.Location = new System.Drawing.Point(598, 455);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(51, 20);
            this.lblErro.TabIndex = 72;
            this.lblErro.Text = "label3";
            // 
            // fmrAdicionarConteudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(891, 530);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.lblConteudoAdicionado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblConteudo);
            this.Controls.Add(this.cboSelecionar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.btnApagarAnexos);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstAnexoAdicionados);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboTema);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnArquivos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtfTexto);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAcao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmrAdicionarConteudo";
            this.Text = "fmrAdicionarConteudo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConteudoAdicionado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblConteudo;
        private System.Windows.Forms.ComboBox cboSelecionar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnApagarAnexos;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstAnexoAdicionados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboTema;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnArquivos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtfTexto;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnAcao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.OpenFileDialog ofdArquivosAnexo;
        private System.Windows.Forms.OpenFileDialog ofdImagemDeCapa;
    }
}