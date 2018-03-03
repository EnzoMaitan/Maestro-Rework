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

namespace Maestro_Rework.Forms
{
    public partial class fmrAdicionarQuestionario : Form
    {
        public fmrAdicionarQuestionario()
        {
            InitializeComponent();
            lblErro.Visible = false;
            lblQuestionarioAdicionado.Visible = false;
            FormBorderStyle = FormBorderStyle.None;

            btnAlterar.Visible = false;
            btnExcluir.Visible = false;
            cboSelecionar.Visible = false;
        }

        private IList<Questao> questoes = new List<Questao>();

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            IList<Alternativa> alternativas = new List<Alternativa>();
            lblErro.Visible = false;

            try
            {
                if (CamposAlternativaPreenchido() && PossuiAlternativaCorreta() && ValorMaiorQueZero()) {
                    var questaoConstrutor = new QuestaoConstrutor();

                    var questao = questaoConstrutor
                        .ParaPergunta(txtPergunta.Text)
                        .ParaValor(Convert.ToDouble(updValor.Value))
                        .ParaImagem(null)
                        .Constroi();

                    alternativas.Add(AdicionaAlternativa(questao, txtAltA.Text, rdbA.Checked));
                    alternativas.Add(AdicionaAlternativa(questao, txtAltB.Text, rdbB.Checked));
                    alternativas.Add(AdicionaAlternativa(questao, txtAltC.Text, rdbC.Checked));
                    alternativas.Add(AdicionaAlternativa(questao, txtAltD.Text, rdbD.Checked));
                    alternativas.Add(AdicionaAlternativa(questao, txtAltE.Text, rdbE.Checked));

                    questao = questaoConstrutor.ParaAlternativas(alternativas).Constroi();
                    questoes.Add(questao);
                    lstQuestoes.Items.Add(questao.Pergunta);
                }
            }
            catch (Exception ex)
            {
                lblErro.Visible = true;
                lblErro.Text = ex.Message;
<<<<<<< HEAD
            }           
        }

        public void LimparCamposAlternativas()
        {
            txtAltA.Clear();
            txtAltB.Clear();
            txtAltC.Clear();
            txtAltD.Clear();
            txtAltE.Clear();
            txtPergunta.Clear();
            updValor.Value = 0.0m;
            rdbA.Checked = false;
            rdbB.Checked = false;
            rdbC.Checked = false;
            rdbD.Checked = false;
            rdbE.Checked = false;
=======
            }
>>>>>>> design
        }

        private bool ValorMaiorQueZero()
        {
            if (updValor.Value > 0) return true;
            else throw new ArgumentException("Selecione um valor para a Alternativa");
        }

        private bool PossuiAlternativaCorreta()
        {
            if (rdbA.Checked != false || rdbB.Checked != false ||
                rdbC.Checked != false || rdbD.Checked != false ||
                rdbE.Checked != false) return true;
            else throw new ArgumentNullException("", "Selecione uma Alternativa Correta");
        }

        private bool CamposAlternativaPreenchido()
        {
            if (txtAltA.Text != "" && txtAltB.Text != "" &&
                txtAltC.Text != "" && txtAltD.Text != "" &&
                txtAltE.Text != "")
                return true;
            else throw new ArgumentNullException("Preencha Todos os Campos");
        }

        private Alternativa AdicionaAlternativa(Questao questaoAtual, string texto, bool correta)
        {
            using (var alternativaConstrutor = new AlternativaConstrutor())
            {
                return alternativaConstrutor
                               .ParaTexto(texto)
                               .ParaCorreta(correta)
                               .ParaQuestao(questaoAtual)
                               .Constroi();
            }
        }

        private void btnAcao_Click(object sender, EventArgs e)
        {            
                var questionarioDAO = new QuestionarioDAO();
                var questionarioConstrutor = new QuestionarioConstrutor();

<<<<<<< HEAD
            try
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

                var questionario =  questionarioConstrutor
                    .ParaUsuario(fmrLogin.usuarioLogado)
                    .ParaNome(txtTitulo.Text)
                    .ParaRefazer(chkRefazer.Checked)
                    .ParaAtivo(true)
                    .ParaQuestoes(questoes)
                    .Constroi();

                questionarioDAO.Adicionar(questionario);

                txtCodigo.Text = questionario.CodigoAcesso;
                lblQuestionarioAdicionado.Visible = true;

                questoes.Clear();
                LimparCamposQuestionario();
                LimparCamposAlternativas();
            }
            catch (Exception ex)
            {
                lblErro.Visible = true;
                lblErro.Text = ex.Message;
            }
        }

        private void LimparCamposQuestionario()
        {
            txtTitulo.Clear();
            chkRefazer.Checked = false;
            chkAdicionarPrazo.Checked = false;
            AtualizarDataSource();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {          
            var questaoSelecionada = GetQuestaoSelecionada();
            if (questaoSelecionada != null)
                AlterarQuestao(questaoSelecionada);

            AtualizarDataSource();
        }

        private void AtualizarDataSource()
        {
            lstQuestoes.DataSource = null;
            lstQuestoes.DataSource = questoes;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var questaoSelecionada = GetQuestaoSelecionada();

            questoes.Remove(questaoSelecionada);

            LimparCamposAlternativas();
        }

        private void lstQuestoes_SelectedValueChanged(object sender, EventArgs e)
        {
            Questao questaoSelecionada = GetQuestaoSelecionada();
            if (questaoSelecionada != null)
            {
                MostrarQuestaoAtual(questaoSelecionada);
                MostrarTextoAlternativas(questaoSelecionada);
                MostrarAlternativaCorreta(questaoSelecionada);
            }
        }

        private Questao GetQuestaoSelecionada()
        {
            return questoes.Where(x => x.Pergunta == lstQuestoes.Text).FirstOrDefault();
        }

        private void MostrarAlternativaCorreta(Questao questaoSelecionada)
        {
            rdbA.Checked = questaoSelecionada.Alternativas[0].Correta;
            rdbB.Checked = questaoSelecionada.Alternativas[1].Correta;
            rdbC.Checked = questaoSelecionada.Alternativas[2].Correta;
            rdbD.Checked = questaoSelecionada.Alternativas[3].Correta;
            rdbE.Checked = questaoSelecionada.Alternativas[4].Correta;
        }

        private void MostrarTextoAlternativas(Questao questaoSelecionada)
        {
            txtAltA.Text = questaoSelecionada.Alternativas[0].Texto;
            txtAltB.Text = questaoSelecionada.Alternativas[1].Texto;
            txtAltC.Text = questaoSelecionada.Alternativas[2].Texto;
            txtAltD.Text = questaoSelecionada.Alternativas[3].Texto;
            txtAltE.Text = questaoSelecionada.Alternativas[4].Texto;
        }

        private void MostrarQuestaoAtual(Questao questaoSelecionada)
        {
            txtPergunta.Text = questaoSelecionada.Pergunta;
            //pictureBox1.Image = questaoSelecionada.Imagem;
            updValor.Value = Convert.ToDecimal(questaoSelecionada.Valor);
        }

        private void AlterarQuestao(Questao questaoSelecionada)
        {
            double valorPergunta = Convert.ToDouble(updValor.Value);

            var pergunta = questaoSelecionada.Pergunta;

            questaoSelecionada.AlterarPergunta(txtPergunta.Text);
            questaoSelecionada.AlterarValor(valorPergunta);
            //questaoSelecionada.AlterarImagem();
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
            lblFim.Visible = visibilidade;
            lblInicio.Visible = visibilidade;
            dtpFim.Visible = visibilidade;
            dtpInicio.Visible = visibilidade;
=======
                var questionario = 
                    questionarioConstrutor.ParaUsuario(fmrLogin.usuarioLogado)
                        .ParaNome(txtTitulo.Text)
                        .ParaDataFim(dateFim.Value)
                        .ParaDataInicio(dateInicio.Value)
                        .ParaRefazer(chkRefazer.Checked)
                        .ParaAtivo(true)
                        .ParaQuestoes(questoes)
                        .Constroi();

                questionarioDAO.Adicionar(questionario);
            txtCodigo.Text = questionarioConstrutor.CodigoAcesso;
            lblQuestionarioAdicionado.Visible = true;
>>>>>>> design
        }
    }
}
