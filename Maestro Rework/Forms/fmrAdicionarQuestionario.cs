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

                    var questao = questaoConstrutor.ParaPergunta(txtPergunta.Text)
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
            }
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
        }
    }
}
