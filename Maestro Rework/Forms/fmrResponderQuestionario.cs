using Maestro_Rework.Classes.Entidades;
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
        Questionario questionario;
        IList<Questao> questoesRestantes;
        public fmrResponderQuestionario(Questionario questionario)
        {
            this.questionario = questionario;
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            MessageBox.Show(questionario.Nome);

            questoesRestantes = questionario.Questoes;
            CarregarQuestao();
        }

        private void CarregarQuestao()
        {
            if (questoesRestantes.Count > 0)
            {
                Questao questaoAtual = RandomizaQuestaoDaLista();
                questoesRestantes.Remove(questaoAtual);

                lblPergunta.Text = questaoAtual.Pergunta;

                CarregarAlternativas(questaoAtual);
            }
            else { MessageBox.Show("That's All Folks!"); }
        }

        private void CarregarAlternativas(Questao questao)
        {
            Random random = new Random();
            var sorteada = questao.Alternativas.OrderBy(x => random.Next()).ToArray();

            rdbAlternativa1.Text = sorteada[0].Texto;
            rdbAlternativa2.Text = sorteada[1].Texto;
            rdbAlternativa3.Text = sorteada[2].Texto;
            rdbAlternativa4.Text = sorteada[3].Texto;
            rdbAlternativa5.Text = sorteada[4].Texto;

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
            CarregarQuestao();
        }
    }
}
