using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maestro_Rework.Classes;
using Maestro_Rework.Classes.Construtores;

namespace Maestro_Rework.Forms
{
    public partial class fmrAdicionarQuestionario3AdicionarQuestao : Form
    {
        private Questao questao;
        private Questao questaoParaAlterar;
        private QuestionarioConstrutor questionarioConstrutor;
        private bool registrarQuestao;

        public fmrAdicionarQuestionario3AdicionarQuestao(QuestionarioConstrutor questionarioConstrutor)
        {
            registrarQuestao = true;
            this.questionarioConstrutor = questionarioConstrutor;
            InitializeComponent();
            lblQuestaoAdicionada.Visible = false;
            FormBorderStyle = FormBorderStyle.None;
        }

        public fmrAdicionarQuestionario3AdicionarQuestao(QuestionarioConstrutor questionarioConstrutor, Questao questao)
        {
            registrarQuestao = false;
            this.questaoParaAlterar = new Questao();
            this.questaoParaAlterar = questao;
            this.questao = questao;
            this.questionarioConstrutor = questionarioConstrutor;
            InitializeComponent();

            lblQuestaoAdicionada.Visible = false;
            lblQuestaoAdicionada.Text = "Questão Alterada";
            FormBorderStyle = FormBorderStyle.None;

            MostrarQuestaoSelecionada();

            btnAdicionar.Text = "Alterar";
        }

        //private void AlterarQuestao(Questao questaoSelecionada)
        //{
        //    double valorPergunta = Convert.ToDouble(updValor.Value);

        //    var pergunta = questaoSelecionada.Pergunta;

        //    questaoSelecionada.AlterarPergunta(txtPergunta.Text);
        //    questaoSelecionada.AlterarValor(valorPergunta);
        //}

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            IList<Alternativa> alternativas;

            var questaoConstrutor = new QuestaoConstrutor();

            var questao = questaoConstrutor
                .ParaPergunta(txtPergunta.Text)
                .ParaValor(Convert.ToDouble(updValor.Value))
                .ParaImagem(ConverterFoto(ofdImagemDaQuestao))
                .Constroi();

            alternativas = new List<Alternativa>
                {
                    AdicionaAlternativa(questao, txtA.Text, rdbA.Checked),
                    AdicionaAlternativa(questao, txtB.Text, rdbB.Checked),
                    AdicionaAlternativa(questao, txtC.Text, rdbC.Checked),
                    AdicionaAlternativa(questao, txtD.Text, rdbD.Checked),
                    AdicionaAlternativa(questao, txtE.Text, rdbE.Checked),
                };

            questao = questaoConstrutor
                .ParaAlternativas(alternativas)
                .Constroi();

            if (registrarQuestao)
            {
                fmrAdicionarQuestionario2ListaQuestoes.questoes.Add(questao);
                LimparCampos();
            }
            else
            {
                AlterarQuestao(questao);
            }

            lblQuestaoAdicionada.Visible = true;
        }

        private void AlterarQuestao(Questao questao)
        {
                fmrAdicionarQuestionario2ListaQuestoes.questoes.Remove(questaoParaAlterar);
                fmrAdicionarQuestionario2ListaQuestoes.questoes.Add(questao);
        }

        private void LimparCampos()
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtD.Clear();
            txtE.Clear();
            txtPergunta.Clear();
            updValor.Value = 0;
            rdbA.Checked = false;
            rdbB.Checked = false;
            rdbC.Checked = false;
            rdbD.Checked = false;
            rdbE.Checked = false;
        }

        private void MostrarQuestaoSelecionada()
        {
            txtPergunta.Text = questao.Pergunta;
            updValor.Value = Convert.ToDecimal(questao.Valor);
            //todo mostrar questoes;
        }

        private Alternativa AdicionaAlternativa(Questao questaoAtual, string texto, bool correta)
        {
            var alternativaConstrutor = new AlternativaConstrutor();

            return alternativaConstrutor
                    .ParaTexto(texto)
                    .ParaCorreta(correta)
                    .ParaQuestao(questaoAtual)
                    .Constroi();
        }

        private byte[] ConverterFoto(OpenFileDialog ofd)
        {
            //using (var stream = new MemoryStream())
            //{
            //    pictureBox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            //    stream.Seek(0, SeekOrigin.Begin);
            //    byte[] bArray = new byte[stream.Length];
            //    stream.Read(bArray, 0, Convert.ToInt32(stream.Length));
            //    return bArray;
            //}
            return null;
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            try
            {
                ofdImagemDaQuestao.Filter = "Images(*.JPG;*PNG;*.IMG)|*.JPG;*PNG;*.IMG";
                if (ofdImagemDaQuestao.ShowDialog() == DialogResult.OK)
                {
                    ofdImagemDaQuestao.OpenFile();
                }
            }
            catch (Exception) { }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var show = new fmrAdicionarQuestionario2ListaQuestoes(questionarioConstrutor);
            show.MdiParent = ActiveForm;
            show.Dock = DockStyle.Fill;
            show.Show();
            Close();
        }

        private void updValor_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
