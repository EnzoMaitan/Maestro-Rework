namespace Maestro_Rework.Forms
{
    partial class fmrGerenciarQuestionario
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
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lstQuestionarios = new System.Windows.Forms.ListBox();
            this.lblGerenciarQuestionarios = new System.Windows.Forms.Label();
            this.lblSelecionar = new System.Windows.Forms.Label();
            this.lstInformacoes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.btnEditar.Location = new System.Drawing.Point(671, 380);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(85, 26);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Coral;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.btnExcluir.Location = new System.Drawing.Point(671, 432);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(85, 26);
            this.btnExcluir.TabIndex = 1;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.btnCancelar.Location = new System.Drawing.Point(36, 526);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lstQuestionarios
            // 
            this.lstQuestionarios.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.lstQuestionarios.FormattingEnabled = true;
            this.lstQuestionarios.ItemHeight = 16;
            this.lstQuestionarios.Location = new System.Drawing.Point(36, 142);
            this.lstQuestionarios.Name = "lstQuestionarios";
            this.lstQuestionarios.Size = new System.Drawing.Size(551, 324);
            this.lstQuestionarios.TabIndex = 3;
            this.lstQuestionarios.SelectedIndexChanged += new System.EventHandler(this.lstQuestionarios_SelectedIndexChanged);
            // 
            // lblGerenciarQuestionarios
            // 
            this.lblGerenciarQuestionarios.AutoSize = true;
            this.lblGerenciarQuestionarios.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.lblGerenciarQuestionarios.Location = new System.Drawing.Point(280, 28);
            this.lblGerenciarQuestionarios.Name = "lblGerenciarQuestionarios";
            this.lblGerenciarQuestionarios.Size = new System.Drawing.Size(333, 33);
            this.lblGerenciarQuestionarios.TabIndex = 5;
            this.lblGerenciarQuestionarios.Text = "Gerenciar Questionarios";
            // 
            // lblSelecionar
            // 
            this.lblSelecionar.AutoSize = true;
            this.lblSelecionar.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.lblSelecionar.Location = new System.Drawing.Point(77, 94);
            this.lblSelecionar.Name = "lblSelecionar";
            this.lblSelecionar.Size = new System.Drawing.Size(345, 33);
            this.lblSelecionar.TabIndex = 6;
            this.lblSelecionar.Text = "Selecione o Questionário";
            // 
            // lstInformacoes
            // 
            this.lstInformacoes.FormattingEnabled = true;
            this.lstInformacoes.Location = new System.Drawing.Point(610, 142);
            this.lstInformacoes.Name = "lstInformacoes";
            this.lstInformacoes.Size = new System.Drawing.Size(225, 186);
            this.lstInformacoes.TabIndex = 7;
            // 
            // fmrGerenciarQuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(859, 585);
            this.Controls.Add(this.lstInformacoes);
            this.Controls.Add(this.lblSelecionar);
            this.Controls.Add(this.lblGerenciarQuestionarios);
            this.Controls.Add(this.lstQuestionarios);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Name = "fmrGerenciarQuestionario";
            this.Text = "fmrGerenciarQuestionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListBox lstQuestionarios;
        private System.Windows.Forms.Label lblGerenciarQuestionarios;
        private System.Windows.Forms.Label lblSelecionar;
        private System.Windows.Forms.ListBox lstInformacoes;
    }
}