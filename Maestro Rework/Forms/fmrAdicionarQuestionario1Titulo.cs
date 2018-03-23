using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maestro_Rework.Classes;
using Maestro_Rework.Classes.Construtores;
using Maestro_Rework.DAO;
using System.IO;

namespace Maestro_Rework.Forms
{
    public partial class fmrAdicionarQuestionario1Titulo : Form
    {
        private QuestionarioConstrutor questionarioConstrutor;

        public fmrAdicionarQuestionario1Titulo()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;

            AlterarVisibilidadePrazo(false);
        }

        
        public fmrAdicionarQuestionario1Titulo(QuestionarioConstrutor questionarioConstrutor)
        {
            this.questionarioConstrutor = questionarioConstrutor;

            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;

            txtTitulo.Text = questionarioConstrutor.Nome;


            var possuiPrazo = questionarioConstrutor.DataFim != null && questionarioConstrutor.DataInicio != null;

            if (possuiPrazo)
            {              
                dtpFim.Value = (DateTime)questionarioConstrutor.DataFim;
                dtpInicio.Value = (DateTime)questionarioConstrutor.DataInicio;
            }
            AlterarVisibilidadePrazo(possuiPrazo);

        }

        //private IList<Questao> questoes = new List<Questao>();

        //private void btnAdicionar_Click(object sender, EventArgs e)
        //{
        //    IList<Alternativa> alternativas;
        //    lblErro.Visible = false;

        //    try
        //    {
        //        if (CamposAlternativaPreenchido() && PossuiAlternativaCorreta() && ValorMaiorQueZero())
        //        {
        //            var questaoConstrutor = new QuestaoConstrutor();

        //            var questao = questaoConstrutor
        //                .ParaPergunta(txtPergunta.Text)
        //                .ParaValor(Convert.ToDouble(updValor.Value))
        //                .ParaImagem(DefinirImagem())
        //                .Constroi();

        //            alternativas = new List<Alternativa>
        //            {
        //                AdicionaAlternativa(questao, txtAltA.Text, rdbA.Checked),
        //                AdicionaAlternativa(questao, txtAltB.Text, rdbB.Checked),
        //                AdicionaAlternativa(questao, txtAltC.Text, rdbC.Checked),
        //                AdicionaAlternativa(questao, txtAltD.Text, rdbD.Checked),
        //                AdicionaAlternativa(questao, txtAltE.Text, rdbE.Checked),
        //            };

        //            questao = questaoConstrutor
        //                .ParaAlternativas(alternativas)
        //                .Constroi();

        //            questoes.Add(questao);

        //            LimparCamposAlternativas();
        //            AtualizarDataSource();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        lblErro.Visible = true;
        //        lblErro.Text = ex.Message;
        //    }
        //}

        //public void LimparCamposAlternativas()
        //{
        //    txtAltA.Clear();
        //    txtAltB.Clear();
        //    txtAltC.Clear();
        //    txtAltD.Clear();
        //    txtAltE.Clear();
        //    txtPergunta.Clear();
        //    updValor.Value = 0.0m;
        //    rdbA.Checked = false;
        //    rdbB.Checked = false;
        //    rdbC.Checked = false;
        //    rdbD.Checked = false;
        //    rdbE.Checked = false;
        //}

        //private bool ValorMaiorQueZero()
        //{
        //    if (updValor.Value > 0) return true;
        //    else throw new ArgumentException("Selecione um valor para a Alternativa");
        //}

        //private bool PossuiAlternativaCorreta()
        //{
        //    if (rdbA.Checked || rdbB.Checked ||
        //        rdbC.Checked || rdbD.Checked ||
        //        rdbE.Checked) return true;
        //    else throw new ArgumentNullException("", "Selecione uma Alternativa Correta");
        //}

        //private bool CamposAlternativaPreenchido()
        //{
        //    if (txtAltA.Text != "" && txtAltB.Text != "" &&
        //        txtAltC.Text != "" && txtAltD.Text != "" &&
        //        txtAltE.Text != "")
        //        return true;
        //    else throw new ArgumentNullException("Preencha Todos os Campos");
        //}

        //private Alternativa AdicionaAlternativa(Questao questaoAtual, string texto, bool correta)
        //{
        //    var alternativaConstrutor = new AlternativaConstrutor();

        //    return alternativaConstrutor
        //            .ParaTexto(texto)
        //            .ParaCorreta(correta)
        //            .ParaQuestao(questaoAtual)
        //            .Constroi();           
        //}

        //private void btnAcao_Click(object sender, EventArgs e)
        //{            
        //    try
        //    {
        //        var questionarioAdicionado = AdicionarQuestionario();

        //        txtCodigo.Text = questionarioAdicionado.CodigoAcesso;
        //        lblQuestionarioAdicionado.Visible = true;

        //        questoes.Clear();

        //        LimparCamposQuestionario();
        //        LimparCamposAlternativas();
        //    }
        //    catch (Exception erro)
        //    {
        //        lblErro.Visible = true;
        //        lblErro.Text = erro.Message;
        //    }
        //}

        //private Questionario AdicionarQuestionario()
        //{
        //    var questionarioDAO = new QuestionarioDAO();
        //    var questionarioConstrutor = new QuestionarioConstrutor();

        //    if (chkAdicionarPrazo.Checked)
        //    {
        //        questionarioConstrutor.ParaDataFim(dtpFim.Value);
        //        questionarioConstrutor.ParaDataInicio(dtpInicio.Value);
        //    }
        //    else
        //    {
        //        questionarioConstrutor.ParaDataFim(null);
        //        questionarioConstrutor.ParaDataInicio(null);
        //    }

        //    var questionario = questionarioConstrutor
        //        .ParaUsuario(fmrLogin.usuarioLogado)
        //        .ParaNome(txtTitulo.Text)
        //        .ParaRefazer(chkRefazer.Checked)
        //        .ParaAtivo(true)
        //        .ParaQuestoes(questoes)
        //        .Constroi();

        //    questionarioDAO.Adicionar(questionario);
        //    return questionario;
        //}

        //private void LimparCamposQuestionario()
        //{
        //    txtTitulo.Clear();
        //    chkRefazer.Checked = false;
        //    chkAdicionarPrazo.Checked = false;
        //    AtualizarDataSource();
        //}

        //private void btnAlterar_Click(object sender, EventArgs e)
        //{          
        //    var questaoSelecionada = GetQuestaoSelecionada();
        //    if (questaoSelecionada != null)
        //        AlterarQuestao(questaoSelecionada);

        //    AtualizarDataSource();
        //}

        //private void AtualizarDataSource()
        //{
        //    lstQuestoes.DataSource = null;
        //    lstQuestoes.DataSource = questoes;
        //}

        //private void btnExcluir_Click(object sender, EventArgs e)
        //{
        //    var questaoSelecionada = GetQuestaoSelecionada();

        //    questoes.Remove(questaoSelecionada);

        //    LimparCamposAlternativas();

        //    AtualizarDataSource();
        //}

        //private void lstQuestoes_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    Questao questaoSelecionada = GetQuestaoSelecionada();
        //    if (questaoSelecionada != null)
        //    {
        //        MostrarQuestaoAtual(questaoSelecionada);
        //        MostrarTextoAlternativas(questaoSelecionada);
        //        MostrarAlternativaCorreta(questaoSelecionada);
        //    }
        //}

        //private Questao GetQuestaoSelecionada() => 
        //    questoes.Where(x => x.Pergunta == lstQuestoes.Text).FirstOrDefault();


        //private void MostrarAlternativaCorreta(Questao questaoSelecionada)
        //{
        //    rdbA.Checked = questaoSelecionada.Alternativas[0].Correta;
        //    rdbB.Checked = questaoSelecionada.Alternativas[1].Correta;
        //    rdbC.Checked = questaoSelecionada.Alternativas[2].Correta;
        //    rdbD.Checked = questaoSelecionada.Alternativas[3].Correta;
        //    rdbE.Checked = questaoSelecionada.Alternativas[4].Correta;
        //}

        //private void MostrarTextoAlternativas(Questao questaoSelecionada)
        //{
        //    txtAltA.Text = questaoSelecionada.Alternativas[0].Texto;
        //    txtAltB.Text = questaoSelecionada.Alternativas[1].Texto;
        //    txtAltC.Text = questaoSelecionada.Alternativas[2].Texto;
        //    txtAltD.Text = questaoSelecionada.Alternativas[3].Texto;
        //    txtAltE.Text = questaoSelecionada.Alternativas[4].Texto;
        //}

        //private void MostrarQuestaoAtual(Questao questaoSelecionada)
        //{
        //    txtPergunta.Text = questaoSelecionada.Pergunta;

        //    CarregarImagem(questaoSelecionada);

        //    updValor.Value = Convert.ToDecimal(questaoSelecionada.Valor);
        //}

        //private void CarregarImagem(Questao questaoSelecionada)
        //{
        //    if (questaoSelecionada.Imagem != null)
        //    {
        //        MemoryStream stream = new MemoryStream(questaoSelecionada.Imagem);   
        //        pictureBox1.Image = Image.FromStream(stream);               
        //    }
        //    else
        //    {
        //        pictureBox1.Image = null;           
        //    }
        //}

        //private void AlterarQuestao(Questao questaoSelecionada)
        //{
        //    double valorPergunta = Convert.ToDouble(updValor.Value);

        //    var pergunta = questaoSelecionada.Pergunta;

        //    questaoSelecionada.AlterarPergunta(txtPergunta.Text);
        //    questaoSelecionada.AlterarValor(valorPergunta);
        //    questaoSelecionada.AlterarImagem(DefinirImagem());
        //}

        //private byte[] DefinirImagem()
        //{
        //    byte[] imagem = null;
        //    try
        //    {
        //        imagem = ConverterFoto(pictureBox1);
        //    }
        //    catch (Exception)
        //    {

        //    }

        //    return imagem;
        //}


        //private void btnImg_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ofdImagemDaQuestao.Filter = "Images(*.JPG;*PNG;*.IMG)|*.JPG;*PNG;*.IMG";
        //        if (ofdImagemDaQuestao.ShowDialog() == DialogResult.OK)
        //        {
        //            ofdImagemDaQuestao.OpenFile();
        //            pictureBox1.ImageLocation = ofdImagemDaQuestao.FileName;
        //        }
        //    }
        //    catch (Exception) { }
        //}

        //private void btnRemoverImg_Click(object sender, EventArgs e) => pictureBox1.Image = null;

        //private byte[] ConverterFoto(PictureBox pictureBox)
        //{
        //    using (var stream = new MemoryStream())
        //    {
        //        pictureBox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
        //        stream.Seek(0, SeekOrigin.Begin);
        //        byte[] bArray = new byte[stream.Length];
        //        stream.Read(bArray, 0, Convert.ToInt32(stream.Length));
        //        return bArray;
        //    }
        //}

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            questionarioConstrutor = new QuestionarioConstrutor();

            questionarioConstrutor.ParaNome(txtTitulo.Text);
            AdicionarPrazoAoConstrutor();

            var show = new fmrAdicionarQuestionario2ListaQuestoes(questionarioConstrutor);
            show.MdiParent = ActiveForm;
            show.Dock = DockStyle.Fill;
            show.Show();
            Close();
        }

        private void AdicionarPrazoAoConstrutor()
        {
            if (chkAdicionarPrazo.Checked)
            {
                questionarioConstrutor.ParaDataFim(dtpFim.Value);
                questionarioConstrutor.ParaDataInicio(dtpInicio.Value);
            }
            else
            {
                questionarioConstrutor.ParaDataFim(null);
                questionarioConstrutor.ParaDataInicio(null);
            }
        }

        private void chkAdicionarPrazo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdicionarPrazo.Checked)
            {
                AlterarVisibilidadePrazo(true);
            }
            else
            {
                AlterarVisibilidadePrazo(false);
            }
        }

        private void AlterarVisibilidadePrazo(bool visibilidade)
        {
            dtpFim.Visible = visibilidade;
            dtpInicio.Visible = visibilidade;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }
    }
}
