using Maestro_Rework.Classes.Entidades;
using Maestro_Rework.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maestro_Rework.Forms
{
    public partial class fmrResponderQuestionario : Form
    {
        private int numeroDaTentativa;
        private Questionario questionario;

        private IList<Questao> questoesRestantes;
        private IList<AlternativaCorreta> questoesAcertadas;

        private QuestionarioUsuario questionarioUsuario;
        private Questao questaoAtual;
        private IList<Alternativa> alternativasAtual;

        public fmrResponderQuestionario(Questionario questionario, int tentativa, QuestionarioUsuario questionarioUsuario)
        {
            this.questionario = questionario;
            this.numeroDaTentativa = tentativa;
            this.questionarioUsuario = questionarioUsuario;
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            questoesRestantes = questionario.Questoes;
            questoesAcertadas = new List<AlternativaCorreta>();

            CarregarQuestao();
        }

        private void CarregarQuestao()
        {
            if (questoesRestantes.Count > 0)
            {
                questaoAtual = RandomizaQuestaoDaLista();
                questoesRestantes.Remove(questaoAtual);
                
                lblPergunta.Text = questaoAtual.Pergunta;
                CarregarAlternativas(questaoAtual);
            }
            else
            {
                MessageBox.Show("That's All Folks!");
                SalvarRespostasNoBanco();
            }
        }

        private void SalvarRespostasNoBanco()
        {
            var alternativaCorretaDAO = new AlternativaCorretaDAO();

            foreach (var resposta in questoesAcertadas)
            {
                alternativaCorretaDAO.Adicionar(resposta);
            }
        }

        private void CarregarAlternativas(Questao questao)
        {
            RandomizarAlternativas(questao);

            rdbAlternativa1.Text = alternativasAtual[0].Texto;
            rdbAlternativa2.Text = alternativasAtual[1].Texto;
            rdbAlternativa3.Text = alternativasAtual[2].Texto;
            rdbAlternativa4.Text = alternativasAtual[3].Texto;
            rdbAlternativa5.Text = alternativasAtual[4].Texto;

        }

        private void RandomizarAlternativas(Questao questao)
        {
            Random random = new Random();
            alternativasAtual = questao.Alternativas.OrderBy(x => random.Next()).ToArray();
        }

        private Questao RandomizaQuestaoDaLista()
        {
            Random random = new Random();
            var a = random.Next(questoesRestantes.Count);
            Questao questaoAtual = questoesRestantes[a];
            return questaoAtual;
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if (CheckarSeAcertouERetornarIdDaAlternativaCorreta(out int idAlternativa))
            {
                SalvarAlternativaCorreta(idAlternativa);
            }
            LimparRadioButtons();
            CarregarQuestao();
        }

        private void LimparRadioButtons()
        {
            rdbAlternativa1.Checked = true;
            rdbAlternativa1.Checked = false;
        }

        private void SalvarAlternativaCorreta(int idAlternativa)
        {
            var alternativaCorreta = new AlternativaCorreta();

            alternativaCorreta.Tentativa = numeroDaTentativa;
            alternativaCorreta.AlternativaID = idAlternativa;
            alternativaCorreta.QuestionarioUsuarioID = questionarioUsuario.Id;
            questoesAcertadas.Add(alternativaCorreta);
        }

        private bool CheckarSeAcertouERetornarIdDaAlternativaCorreta(out int idAlternativa)
        {
            if (rdbAlternativa1.Checked && alternativasAtual[0].Correta)
            {
                idAlternativa = alternativasAtual[0].Id;
                return true;
            }
            else if (rdbAlternativa2.Checked && alternativasAtual[1].Correta)
            {
                idAlternativa = alternativasAtual[1].Id;
                return true;
            }
            else if (rdbAlternativa3.Checked && alternativasAtual[2].Correta)
            {
                idAlternativa = alternativasAtual[2].Id;
                return true;
            }
            else if (rdbAlternativa4.Checked && alternativasAtual[3].Correta)
            {
                idAlternativa = alternativasAtual[3].Id;
                return true;
            }
            else if (rdbAlternativa5.Checked && alternativasAtual[4].Correta)
            {
                idAlternativa = alternativasAtual[4].Id;
                return true;
            }
            else
                idAlternativa = 0;
                return false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza que deseja cancelar o questionario ?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
