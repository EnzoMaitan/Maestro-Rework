namespace Maestro_Rework.Forms
{
    partial class fmrAdicionarQuestionario
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
            this.lblErro = new System.Windows.Forms.Label();
            this.lblQuestionarioAdicionado = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnRemoverImg = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lstQuestoes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboSelecionar = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.updValor = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.chkAdicionarPrazo = new System.Windows.Forms.CheckBox();
            this.lblFim = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.chkRefazer = new System.Windows.Forms.CheckBox();
            this.btnAcao = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnImg = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.rdbE = new System.Windows.Forms.RadioButton();
            this.rdbD = new System.Windows.Forms.RadioButton();
            this.rdbC = new System.Windows.Forms.RadioButton();
            this.rdbB = new System.Windows.Forms.RadioButton();
            this.rdbA = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAltD = new System.Windows.Forms.TextBox();
            this.txtAltC = new System.Windows.Forms.TextBox();
            this.txtAltE = new System.Windows.Forms.TextBox();
            this.txtAltA = new System.Windows.Forms.TextBox();
            this.txtAltB = new System.Windows.Forms.TextBox();
            this.txtPergunta = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdImagemDaQuestao = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updValor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErro.ForeColor = System.Drawing.Color.Coral;
            this.lblErro.Location = new System.Drawing.Point(343, 397);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(245, 16);
            this.lblErro.TabIndex = 93;
            this.lblErro.Text = "Selecione uma alternativa como correta";
            // 
            // lblQuestionarioAdicionado
            // 
            this.lblQuestionarioAdicionado.AutoSize = true;
            this.lblQuestionarioAdicionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionarioAdicionado.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblQuestionarioAdicionado.Location = new System.Drawing.Point(643, 530);
            this.lblQuestionarioAdicionado.Name = "lblQuestionarioAdicionado";
            this.lblQuestionarioAdicionado.Size = new System.Drawing.Size(247, 24);
            this.lblQuestionarioAdicionado.TabIndex = 91;
            this.lblQuestionarioAdicionado.Text = "Questionário Adicionado!";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(670, 134);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(197, 24);
            this.label14.TabIndex = 90;
            this.label14.Text = "Imagem da Questão";
            // 
            // btnRemoverImg
            // 
            this.btnRemoverImg.BackColor = System.Drawing.Color.Coral;
            this.btnRemoverImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverImg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemoverImg.Location = new System.Drawing.Point(770, 335);
            this.btnRemoverImg.Name = "btnRemoverImg";
            this.btnRemoverImg.Size = new System.Drawing.Size(113, 34);
            this.btnRemoverImg.TabIndex = 89;
            this.btnRemoverImg.Text = "Remover";
            this.btnRemoverImg.UseVisualStyleBackColor = false;
            this.btnRemoverImg.Click += new System.EventHandler(this.btnRemoverImg_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.White;
            this.btnAlterar.Location = new System.Drawing.Point(394, 450);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(142, 28);
            this.btnAlterar.TabIndex = 88;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lstQuestoes
            // 
            this.lstQuestoes.FormattingEnabled = true;
            this.lstQuestoes.Location = new System.Drawing.Point(21, 145);
            this.lstQuestoes.Name = "lstQuestoes";
            this.lstQuestoes.Size = new System.Drawing.Size(251, 134);
            this.lstQuestoes.TabIndex = 87;
            this.lstQuestoes.SelectedValueChanged += new System.EventHandler(this.lstQuestoes_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(736, 563);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 86;
            this.label2.Text = "Código";
            // 
            // cboSelecionar
            // 
            this.cboSelecionar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSelecionar.FormattingEnabled = true;
            this.cboSelecionar.Location = new System.Drawing.Point(14, 12);
            this.cboSelecionar.Name = "cboSelecionar";
            this.cboSelecionar.Size = new System.Drawing.Size(179, 30);
            this.cboSelecionar.TabIndex = 85;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(724, 589);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 84;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(674, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // updValor
            // 
            this.updValor.DecimalPlaces = 2;
            this.updValor.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updValor.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.updValor.Location = new System.Drawing.Point(462, 561);
            this.updValor.Name = "updValor";
            this.updValor.Size = new System.Drawing.Size(71, 32);
            this.updValor.TabIndex = 82;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(373, 561);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 25);
            this.label13.TabIndex = 81;
            this.label13.Text = "Valor:";
            // 
            // chkAdicionarPrazo
            // 
            this.chkAdicionarPrazo.AutoSize = true;
            this.chkAdicionarPrazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdicionarPrazo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkAdicionarPrazo.Location = new System.Drawing.Point(18, 293);
            this.chkAdicionarPrazo.Name = "chkAdicionarPrazo";
            this.chkAdicionarPrazo.Size = new System.Drawing.Size(177, 28);
            this.chkAdicionarPrazo.TabIndex = 80;
            this.chkAdicionarPrazo.Text = "Adicionar Prazo";
            this.chkAdicionarPrazo.UseVisualStyleBackColor = true;
            this.chkAdicionarPrazo.CheckedChanged += new System.EventHandler(this.chkAdicionarPrazo_CheckedChanged);
            // 
            // lblFim
            // 
            this.lblFim.AutoSize = true;
            this.lblFim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFim.Location = new System.Drawing.Point(18, 376);
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(45, 24);
            this.lblFim.TabIndex = 79;
            this.lblFim.Text = "Fim";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInicio.Location = new System.Drawing.Point(18, 329);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(60, 24);
            this.lblInicio.TabIndex = 78;
            this.lblInicio.Text = "Inicio";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(18, 356);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(250, 20);
            this.dtpInicio.TabIndex = 77;
            // 
            // dtpFim
            // 
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFim.Location = new System.Drawing.Point(18, 403);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(250, 20);
            this.dtpFim.TabIndex = 76;
            // 
            // chkRefazer
            // 
            this.chkRefazer.AutoSize = true;
            this.chkRefazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRefazer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkRefazer.Location = new System.Drawing.Point(12, 451);
            this.chkRefazer.Name = "chkRefazer";
            this.chkRefazer.Size = new System.Drawing.Size(209, 28);
            this.chkRefazer.TabIndex = 75;
            this.chkRefazer.Text = "Permitir 2 tentativas";
            this.chkRefazer.UseVisualStyleBackColor = true;
            // 
            // btnAcao
            // 
            this.btnAcao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(82)))));
            this.btnAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAcao.Location = new System.Drawing.Point(819, 677);
            this.btnAcao.Name = "btnAcao";
            this.btnAcao.Size = new System.Drawing.Size(95, 36);
            this.btnAcao.TabIndex = 74;
            this.btnAcao.Text = "Criar";
            this.btnAcao.UseVisualStyleBackColor = false;
            this.btnAcao.Click += new System.EventHandler(this.btnAcao_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Coral;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Location = new System.Drawing.Point(696, 677);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(117, 36);
            this.btnSair.TabIndex = 73;
            this.btnSair.Text = "Cancelar";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(13, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 24);
            this.label10.TabIndex = 72;
            this.label10.Text = "Questões adicionadas";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Coral;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(394, 484);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(142, 30);
            this.btnExcluir.TabIndex = 71;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnImg
            // 
            this.btnImg.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImg.Location = new System.Drawing.Point(647, 336);
            this.btnImg.Name = "btnImg";
            this.btnImg.Size = new System.Drawing.Size(117, 34);
            this.btnImg.TabIndex = 70;
            this.btnImg.Text = "Importar";
            this.btnImg.UseVisualStyleBackColor = false;
            this.btnImg.Click += new System.EventHandler(this.btnImg_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(82)))));
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(394, 416);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(142, 28);
            this.btnAdicionar.TabIndex = 69;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // rdbE
            // 
            this.rdbE.AutoSize = true;
            this.rdbE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbE.Location = new System.Drawing.Point(411, 376);
            this.rdbE.Name = "rdbE";
            this.rdbE.Size = new System.Drawing.Size(14, 13);
            this.rdbE.TabIndex = 68;
            this.rdbE.TabStop = true;
            this.rdbE.UseVisualStyleBackColor = true;
            // 
            // rdbD
            // 
            this.rdbD.AutoSize = true;
            this.rdbD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbD.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbD.Location = new System.Drawing.Point(411, 350);
            this.rdbD.Name = "rdbD";
            this.rdbD.Size = new System.Drawing.Size(14, 13);
            this.rdbD.TabIndex = 67;
            this.rdbD.TabStop = true;
            this.rdbD.UseVisualStyleBackColor = true;
            // 
            // rdbC
            // 
            this.rdbC.AutoSize = true;
            this.rdbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbC.Location = new System.Drawing.Point(412, 324);
            this.rdbC.Name = "rdbC";
            this.rdbC.Size = new System.Drawing.Size(14, 13);
            this.rdbC.TabIndex = 66;
            this.rdbC.TabStop = true;
            this.rdbC.UseVisualStyleBackColor = true;
            // 
            // rdbB
            // 
            this.rdbB.AutoSize = true;
            this.rdbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbB.Location = new System.Drawing.Point(411, 298);
            this.rdbB.Name = "rdbB";
            this.rdbB.Size = new System.Drawing.Size(14, 13);
            this.rdbB.TabIndex = 65;
            this.rdbB.TabStop = true;
            this.rdbB.UseVisualStyleBackColor = true;
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbA.Location = new System.Drawing.Point(412, 271);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(14, 13);
            this.rdbA.TabIndex = 64;
            this.rdbA.TabStop = true;
            this.rdbA.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(391, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 16);
            this.label5.TabIndex = 63;
            this.label5.Text = "A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(391, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 16);
            this.label9.TabIndex = 62;
            this.label9.Text = "E";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(391, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 16);
            this.label8.TabIndex = 61;
            this.label8.Text = "D";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(391, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 16);
            this.label7.TabIndex = 60;
            this.label7.Text = "C";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(391, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 16);
            this.label6.TabIndex = 59;
            this.label6.Text = "B";
            // 
            // txtAltD
            // 
            this.txtAltD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAltD.Location = new System.Drawing.Point(432, 347);
            this.txtAltD.Name = "txtAltD";
            this.txtAltD.Size = new System.Drawing.Size(100, 22);
            this.txtAltD.TabIndex = 58;
            // 
            // txtAltC
            // 
            this.txtAltC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltC.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAltC.Location = new System.Drawing.Point(432, 321);
            this.txtAltC.Name = "txtAltC";
            this.txtAltC.Size = new System.Drawing.Size(100, 22);
            this.txtAltC.TabIndex = 57;
            // 
            // txtAltE
            // 
            this.txtAltE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltE.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAltE.Location = new System.Drawing.Point(432, 373);
            this.txtAltE.Name = "txtAltE";
            this.txtAltE.Size = new System.Drawing.Size(100, 22);
            this.txtAltE.TabIndex = 56;
            // 
            // txtAltA
            // 
            this.txtAltA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAltA.Location = new System.Drawing.Point(432, 269);
            this.txtAltA.Name = "txtAltA";
            this.txtAltA.Size = new System.Drawing.Size(100, 22);
            this.txtAltA.TabIndex = 55;
            // 
            // txtAltB
            // 
            this.txtAltB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAltB.Location = new System.Drawing.Point(432, 295);
            this.txtAltB.Name = "txtAltB";
            this.txtAltB.Size = new System.Drawing.Size(100, 22);
            this.txtAltB.TabIndex = 54;
            // 
            // txtPergunta
            // 
            this.txtPergunta.Location = new System.Drawing.Point(361, 160);
            this.txtPergunta.Multiline = true;
            this.txtPergunta.Name = "txtPergunta";
            this.txtPergunta.Size = new System.Drawing.Size(215, 34);
            this.txtPergunta.TabIndex = 53;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(369, 12);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(232, 32);
            this.txtTitulo.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(365, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 51;
            this.label4.Text = "Correta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(400, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "Pergunta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(257, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Título";
            // 
            // openFileDialog1
            // 
            this.ofdImagemDaQuestao.FileName = "openFileDialog1";
            // 
            // fmrAdicionarQuestionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(928, 723);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.lblQuestionarioAdicionado);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnRemoverImg);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lstQuestoes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboSelecionar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.updValor);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.chkAdicionarPrazo);
            this.Controls.Add(this.lblFim);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.dtpFim);
            this.Controls.Add(this.chkRefazer);
            this.Controls.Add(this.btnAcao);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnImg);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.rdbE);
            this.Controls.Add(this.rdbD);
            this.Controls.Add(this.rdbC);
            this.Controls.Add(this.rdbB);
            this.Controls.Add(this.rdbA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAltD);
            this.Controls.Add(this.txtAltC);
            this.Controls.Add(this.txtAltE);
            this.Controls.Add(this.txtAltA);
            this.Controls.Add(this.txtAltB);
            this.Controls.Add(this.txtPergunta);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "fmrAdicionarQuestionario";
            this.Text = "fmrAdicionarQuestionario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.Label lblQuestionarioAdicionado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnRemoverImg;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.ListBox lstQuestoes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboSelecionar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown updValor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkAdicionarPrazo;
        private System.Windows.Forms.Label lblFim;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.CheckBox chkRefazer;
        private System.Windows.Forms.Button btnAcao;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnImg;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.RadioButton rdbE;
        private System.Windows.Forms.RadioButton rdbD;
        private System.Windows.Forms.RadioButton rdbC;
        private System.Windows.Forms.RadioButton rdbB;
        private System.Windows.Forms.RadioButton rdbA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAltD;
        private System.Windows.Forms.TextBox txtAltC;
        private System.Windows.Forms.TextBox txtAltE;
        private System.Windows.Forms.TextBox txtAltA;
        private System.Windows.Forms.TextBox txtAltB;
        private System.Windows.Forms.TextBox txtPergunta;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofdImagemDaQuestao;
    }
}