namespace Maestro_Rework.Forms
{
    partial class fmrAdicionarQuestionario1Titulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrAdicionarQuestionario1Titulo));
            this.ofdImagemDaQuestao = new System.Windows.Forms.OpenFileDialog();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPrazo = new System.Windows.Forms.Label();
            this.chkAdicionarPrazo = new System.Windows.Forms.CheckBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofdImagemDaQuestao
            // 
            this.ofdImagemDaQuestao.FileName = "openFileDialog1";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(271, 205);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(315, 38);
            this.txtTitulo.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(384, 161);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(102, 41);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Título";
            // 
            // lblPrazo
            // 
            this.lblPrazo.AutoSize = true;
            this.lblPrazo.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrazo.Location = new System.Drawing.Point(314, 337);
            this.lblPrazo.Name = "lblPrazo";
            this.lblPrazo.Size = new System.Drawing.Size(110, 41);
            this.lblPrazo.TabIndex = 2;
            this.lblPrazo.Text = "Prazo";
            // 
            // chkAdicionarPrazo
            // 
            this.chkAdicionarPrazo.AutoSize = true;
            this.chkAdicionarPrazo.Location = new System.Drawing.Point(293, 360);
            this.chkAdicionarPrazo.Name = "chkAdicionarPrazo";
            this.chkAdicionarPrazo.Size = new System.Drawing.Size(15, 14);
            this.chkAdicionarPrazo.TabIndex = 4;
            this.chkAdicionarPrazo.UseVisualStyleBackColor = true;
            this.chkAdicionarPrazo.CheckStateChanged += new System.EventHandler(this.chkAdicionarPrazo_CheckedChanged);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Location = new System.Drawing.Point(271, 381);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(315, 31);
            this.dtpInicio.TabIndex = 5;
            // 
            // dtpFim
            // 
            this.dtpFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFim.Location = new System.Drawing.Point(271, 434);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(315, 31);
            this.dtpFim.TabIndex = 5;
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
            this.btnAvancar.TabIndex = 6;
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
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // fmrAdicionarQuestionario1Titulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(859, 585);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dtpFim);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.chkAdicionarPrazo);
            this.Controls.Add(this.lblPrazo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblTitulo);
            this.Name = "fmrAdicionarQuestionario1Titulo";
            this.Text = "fmrAdicionarQuestionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofdImagemDaQuestao;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPrazo;
        private System.Windows.Forms.CheckBox chkAdicionarPrazo;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Button btnVoltar;
    }
}