namespace Maestro_Rework.Forms
{
    partial class fmrMenu
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
            this.lblNome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnConteudo = new System.Windows.Forms.Button();
            this.btnQuestionario = new System.Windows.Forms.Button();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblNome.Location = new System.Drawing.Point(41, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(62, 24);
            this.lblNome.TabIndex = 14;
            this.lblNome.Text = "Nome";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(8)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnConteudo);
            this.panel1.Controls.Add(this.btnQuestionario);
            this.panel1.Controls.Add(this.btnPerfil);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 585);
            this.panel1.TabIndex = 15;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(80)))), ((int)(((byte)(33)))));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Location = new System.Drawing.Point(45, 537);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(101, 36);
            this.btnSair.TabIndex = 24;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnConteudo
            // 
            this.btnConteudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(80)))), ((int)(((byte)(33)))));
            this.btnConteudo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConteudo.FlatAppearance.BorderSize = 0;
            this.btnConteudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConteudo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConteudo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConteudo.Location = new System.Drawing.Point(0, 276);
            this.btnConteudo.Name = "btnConteudo";
            this.btnConteudo.Size = new System.Drawing.Size(200, 40);
            this.btnConteudo.TabIndex = 21;
            this.btnConteudo.Text = "Conteudo";
            this.btnConteudo.UseVisualStyleBackColor = false;
            this.btnConteudo.Click += new System.EventHandler(this.btnConteudo_Click);
            // 
            // btnQuestionario
            // 
            this.btnQuestionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(80)))), ((int)(((byte)(33)))));
            this.btnQuestionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnQuestionario.FlatAppearance.BorderSize = 0;
            this.btnQuestionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuestionario.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestionario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuestionario.Location = new System.Drawing.Point(0, 230);
            this.btnQuestionario.Name = "btnQuestionario";
            this.btnQuestionario.Size = new System.Drawing.Size(200, 40);
            this.btnQuestionario.TabIndex = 20;
            this.btnQuestionario.Text = "Questionario";
            this.btnQuestionario.UseVisualStyleBackColor = false;
            this.btnQuestionario.Click += new System.EventHandler(this.btnQuestionario_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.btnPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(80)))), ((int)(((byte)(33)))));
            this.btnPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.Yellow;
            this.btnPerfil.Location = new System.Drawing.Point(0, 187);
            this.btnPerfil.Margin = new System.Windows.Forms.Padding(0);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(200, 40);
            this.btnPerfil.TabIndex = 16;
            this.btnPerfil.Text = "Meu Perfil";
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // fmrMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1059, 585);
            this.Controls.Add(this.panel1);
            this.Name = "fmrMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.fmrMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnConteudo;
        private System.Windows.Forms.Button btnQuestionario;
        private System.Windows.Forms.Button btnPerfil;
    }
}