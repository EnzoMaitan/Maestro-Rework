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
            this.lblCargo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsPerfil = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGerenciar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGerenciarAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGerenciarAlunoCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGerenciarAlunoAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGerenciarProfessor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGerenciarProfessorCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGerenciarProfessorAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGerenciarAdministrador = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGerenciarAdministradorCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGerenciarAdministradorAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsHistorico = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGerenciarHistoricoProfessor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGerenciarHistoricoAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAcesso = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAlterarConteudo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAlterarQuestionario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAdicionar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCadastrarConteudo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCadastrarQuestionario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsQuestionario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsConteudo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsResultado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.tsStatusConteudo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsStatusQuestionario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsStatusUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsStatusUsuarioAdministrador = new System.Windows.Forms.ToolStripMenuItem();
            this.tsStatusUsuarioAluno = new System.Windows.Forms.ToolStripMenuItem();
            this.tsStatusUsuarioProfessor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCargo.Location = new System.Drawing.Point(844, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(40, 13);
            this.lblCargo.TabIndex = 14;
            this.lblCargo.Text = "Cargo";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPerfil,
            this.tsGerenciar,
            this.tsAlterar,
            this.tsAdicionar,
            this.tsQuestionario,
            this.tsConteudo,
            this.tsResultado,
            this.tsStatus,
            this.tsSair});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(907, 25);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsPerfil
            // 
            this.tsPerfil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsPerfil.Name = "tsPerfil";
            this.tsPerfil.Size = new System.Drawing.Size(81, 21);
            this.tsPerfil.Text = "Meu Perfil";
            this.tsPerfil.Click += new System.EventHandler(this.tsPerfil_Click);
            // 
            // tsGerenciar
            // 
            this.tsGerenciar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGerenciarAluno,
            this.tsGerenciarProfessor,
            this.tsGerenciarAdministrador,
            this.tsHistorico,
            this.tsAcesso});
            this.tsGerenciar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsGerenciar.Name = "tsGerenciar";
            this.tsGerenciar.Size = new System.Drawing.Size(83, 21);
            this.tsGerenciar.Text = "Gerenciar";
            // 
            // tsGerenciarAluno
            // 
            this.tsGerenciarAluno.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGerenciarAlunoCadastrar,
            this.tsGerenciarAlunoAlterar});
            this.tsGerenciarAluno.Name = "tsGerenciarAluno";
            this.tsGerenciarAluno.Size = new System.Drawing.Size(166, 22);
            this.tsGerenciarAluno.Text = "Aluno";
            // 
            // tsGerenciarAlunoCadastrar
            // 
            this.tsGerenciarAlunoCadastrar.Name = "tsGerenciarAlunoCadastrar";
            this.tsGerenciarAlunoCadastrar.Size = new System.Drawing.Size(138, 22);
            this.tsGerenciarAlunoCadastrar.Text = "Adicionar";
            // 
            // tsGerenciarAlunoAlterar
            // 
            this.tsGerenciarAlunoAlterar.Name = "tsGerenciarAlunoAlterar";
            this.tsGerenciarAlunoAlterar.Size = new System.Drawing.Size(138, 22);
            this.tsGerenciarAlunoAlterar.Text = "Alterar";
            // 
            // tsGerenciarProfessor
            // 
            this.tsGerenciarProfessor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGerenciarProfessorCadastrar,
            this.tsGerenciarProfessorAlterar});
            this.tsGerenciarProfessor.Name = "tsGerenciarProfessor";
            this.tsGerenciarProfessor.Size = new System.Drawing.Size(166, 22);
            this.tsGerenciarProfessor.Text = "Professor";
            // 
            // tsGerenciarProfessorCadastrar
            // 
            this.tsGerenciarProfessorCadastrar.Name = "tsGerenciarProfessorCadastrar";
            this.tsGerenciarProfessorCadastrar.Size = new System.Drawing.Size(138, 22);
            this.tsGerenciarProfessorCadastrar.Text = "Adicionar";
            // 
            // tsGerenciarProfessorAlterar
            // 
            this.tsGerenciarProfessorAlterar.Name = "tsGerenciarProfessorAlterar";
            this.tsGerenciarProfessorAlterar.Size = new System.Drawing.Size(138, 22);
            this.tsGerenciarProfessorAlterar.Text = "Alterar";
            // 
            // tsGerenciarAdministrador
            // 
            this.tsGerenciarAdministrador.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGerenciarAdministradorCadastrar,
            this.tsGerenciarAdministradorAlterar});
            this.tsGerenciarAdministrador.Name = "tsGerenciarAdministrador";
            this.tsGerenciarAdministrador.Size = new System.Drawing.Size(166, 22);
            this.tsGerenciarAdministrador.Text = "Administrador";
            // 
            // tsGerenciarAdministradorCadastrar
            // 
            this.tsGerenciarAdministradorCadastrar.Name = "tsGerenciarAdministradorCadastrar";
            this.tsGerenciarAdministradorCadastrar.Size = new System.Drawing.Size(138, 22);
            this.tsGerenciarAdministradorCadastrar.Text = "Adicionar";
            // 
            // tsGerenciarAdministradorAlterar
            // 
            this.tsGerenciarAdministradorAlterar.Name = "tsGerenciarAdministradorAlterar";
            this.tsGerenciarAdministradorAlterar.Size = new System.Drawing.Size(138, 22);
            this.tsGerenciarAdministradorAlterar.Text = "Alterar";
            // 
            // tsHistorico
            // 
            this.tsHistorico.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsGerenciarHistoricoProfessor,
            this.tsGerenciarHistoricoAluno});
            this.tsHistorico.Name = "tsHistorico";
            this.tsHistorico.Size = new System.Drawing.Size(166, 22);
            this.tsHistorico.Text = "Historico";
            // 
            // tsGerenciarHistoricoProfessor
            // 
            this.tsGerenciarHistoricoProfessor.Name = "tsGerenciarHistoricoProfessor";
            this.tsGerenciarHistoricoProfessor.Size = new System.Drawing.Size(132, 22);
            this.tsGerenciarHistoricoProfessor.Text = "Professor";
            // 
            // tsGerenciarHistoricoAluno
            // 
            this.tsGerenciarHistoricoAluno.Name = "tsGerenciarHistoricoAluno";
            this.tsGerenciarHistoricoAluno.Size = new System.Drawing.Size(132, 22);
            this.tsGerenciarHistoricoAluno.Text = "Aluno";
            // 
            // tsAcesso
            // 
            this.tsAcesso.Name = "tsAcesso";
            this.tsAcesso.Size = new System.Drawing.Size(166, 22);
            this.tsAcesso.Text = "Acesso";
            // 
            // tsAlterar
            // 
            this.tsAlterar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAlterarConteudo,
            this.tsAlterarQuestionario});
            this.tsAlterar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsAlterar.Name = "tsAlterar";
            this.tsAlterar.Size = new System.Drawing.Size(62, 21);
            this.tsAlterar.Text = "Alterar";
            // 
            // tsAlterarConteudo
            // 
            this.tsAlterarConteudo.Name = "tsAlterarConteudo";
            this.tsAlterarConteudo.Size = new System.Drawing.Size(158, 22);
            this.tsAlterarConteudo.Text = "Conteudo";
            // 
            // tsAlterarQuestionario
            // 
            this.tsAlterarQuestionario.Name = "tsAlterarQuestionario";
            this.tsAlterarQuestionario.Size = new System.Drawing.Size(158, 22);
            this.tsAlterarQuestionario.Text = "Questionario";
            // 
            // tsAdicionar
            // 
            this.tsAdicionar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCadastrarConteudo,
            this.tsCadastrarQuestionario});
            this.tsAdicionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsAdicionar.Name = "tsAdicionar";
            this.tsAdicionar.Size = new System.Drawing.Size(82, 21);
            this.tsAdicionar.Text = "Adicionar";
            // 
            // tsCadastrarConteudo
            // 
            this.tsCadastrarConteudo.Name = "tsCadastrarConteudo";
            this.tsCadastrarConteudo.Size = new System.Drawing.Size(158, 22);
            this.tsCadastrarConteudo.Text = "Conteudo";
            this.tsCadastrarConteudo.Click += new System.EventHandler(this.tsCadastrarConteudo_Click);
            // 
            // tsCadastrarQuestionario
            // 
            this.tsCadastrarQuestionario.Name = "tsCadastrarQuestionario";
            this.tsCadastrarQuestionario.Size = new System.Drawing.Size(158, 22);
            this.tsCadastrarQuestionario.Text = "Questionario";
            this.tsCadastrarQuestionario.Click += new System.EventHandler(this.tsCadastrarQuestionario_Click);
            // 
            // tsQuestionario
            // 
            this.tsQuestionario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsQuestionario.Name = "tsQuestionario";
            this.tsQuestionario.Size = new System.Drawing.Size(102, 21);
            this.tsQuestionario.Text = "Questionario";
            // 
            // tsConteudo
            // 
            this.tsConteudo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsConteudo.Name = "tsConteudo";
            this.tsConteudo.Size = new System.Drawing.Size(87, 21);
            this.tsConteudo.Text = "Conteudo";
            // 
            // tsResultado
            // 
            this.tsResultado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsResultado.Name = "tsResultado";
            this.tsResultado.Size = new System.Drawing.Size(84, 21);
            this.tsResultado.Text = "Resultado";
            // 
            // tsStatus
            // 
            this.tsStatus.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusConteudo,
            this.tsStatusQuestionario,
            this.tsStatusUsuario});
            this.tsStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(58, 21);
            this.tsStatus.Text = "Status";
            // 
            // tsStatusConteudo
            // 
            this.tsStatusConteudo.Name = "tsStatusConteudo";
            this.tsStatusConteudo.Size = new System.Drawing.Size(158, 22);
            this.tsStatusConteudo.Text = "Conteúdo";
            // 
            // tsStatusQuestionario
            // 
            this.tsStatusQuestionario.Name = "tsStatusQuestionario";
            this.tsStatusQuestionario.Size = new System.Drawing.Size(158, 22);
            this.tsStatusQuestionario.Text = "Questionario";
            // 
            // tsStatusUsuario
            // 
            this.tsStatusUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatusUsuarioAdministrador,
            this.tsStatusUsuarioAluno,
            this.tsStatusUsuarioProfessor});
            this.tsStatusUsuario.Name = "tsStatusUsuario";
            this.tsStatusUsuario.Size = new System.Drawing.Size(158, 22);
            this.tsStatusUsuario.Text = "Usuários";
            // 
            // tsStatusUsuarioAdministrador
            // 
            this.tsStatusUsuarioAdministrador.Name = "tsStatusUsuarioAdministrador";
            this.tsStatusUsuarioAdministrador.Size = new System.Drawing.Size(166, 22);
            this.tsStatusUsuarioAdministrador.Text = "Administrador";
            // 
            // tsStatusUsuarioAluno
            // 
            this.tsStatusUsuarioAluno.Name = "tsStatusUsuarioAluno";
            this.tsStatusUsuarioAluno.Size = new System.Drawing.Size(166, 22);
            this.tsStatusUsuarioAluno.Text = "Aluno";
            // 
            // tsStatusUsuarioProfessor
            // 
            this.tsStatusUsuarioProfessor.Name = "tsStatusUsuarioProfessor";
            this.tsStatusUsuarioProfessor.Size = new System.Drawing.Size(166, 22);
            this.tsStatusUsuarioProfessor.Text = "Professor";
            // 
            // tsSair
            // 
            this.tsSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tsSair.Name = "tsSair";
            this.tsSair.Size = new System.Drawing.Size(42, 21);
            this.tsSair.Text = "Sair";
            // 
            // fmrMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 669);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "fmrMenu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsPerfil;
        private System.Windows.Forms.ToolStripMenuItem tsGerenciar;
        private System.Windows.Forms.ToolStripMenuItem tsGerenciarAluno;
        private System.Windows.Forms.ToolStripMenuItem tsGerenciarAlunoCadastrar;
        private System.Windows.Forms.ToolStripMenuItem tsGerenciarAlunoAlterar;
        private System.Windows.Forms.ToolStripMenuItem tsGerenciarProfessor;
        private System.Windows.Forms.ToolStripMenuItem tsGerenciarProfessorCadastrar;
        private System.Windows.Forms.ToolStripMenuItem tsGerenciarProfessorAlterar;
        private System.Windows.Forms.ToolStripMenuItem tsGerenciarAdministrador;
        private System.Windows.Forms.ToolStripMenuItem tsGerenciarAdministradorCadastrar;
        private System.Windows.Forms.ToolStripMenuItem tsGerenciarAdministradorAlterar;
        private System.Windows.Forms.ToolStripMenuItem tsHistorico;
        private System.Windows.Forms.ToolStripMenuItem tsGerenciarHistoricoProfessor;
        private System.Windows.Forms.ToolStripMenuItem tsGerenciarHistoricoAluno;
        private System.Windows.Forms.ToolStripMenuItem tsAcesso;
        private System.Windows.Forms.ToolStripMenuItem tsAlterar;
        private System.Windows.Forms.ToolStripMenuItem tsAlterarConteudo;
        private System.Windows.Forms.ToolStripMenuItem tsAlterarQuestionario;
        private System.Windows.Forms.ToolStripMenuItem tsAdicionar;
        private System.Windows.Forms.ToolStripMenuItem tsCadastrarConteudo;
        private System.Windows.Forms.ToolStripMenuItem tsCadastrarQuestionario;
        private System.Windows.Forms.ToolStripMenuItem tsQuestionario;
        private System.Windows.Forms.ToolStripMenuItem tsConteudo;
        private System.Windows.Forms.ToolStripMenuItem tsResultado;
        private System.Windows.Forms.ToolStripMenuItem tsStatus;
        private System.Windows.Forms.ToolStripMenuItem tsStatusConteudo;
        private System.Windows.Forms.ToolStripMenuItem tsStatusQuestionario;
        private System.Windows.Forms.ToolStripMenuItem tsStatusUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsStatusUsuarioAdministrador;
        private System.Windows.Forms.ToolStripMenuItem tsStatusUsuarioAluno;
        private System.Windows.Forms.ToolStripMenuItem tsStatusUsuarioProfessor;
        private System.Windows.Forms.ToolStripMenuItem tsSair;
    }
}