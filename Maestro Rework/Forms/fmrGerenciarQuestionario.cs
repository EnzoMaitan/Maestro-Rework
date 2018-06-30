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
    public partial class fmrGerenciarQuestionario : Form
    {
        Questionario questionarioAtual;

        public fmrGerenciarQuestionario()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            CarregarListaDeQuestionariosNaListBox();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Mesmo Remover?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var questionarioDAO = new QuestionarioDAO();
                questionarioDAO.Remover(questionarioAtual);
                CarregarListaDeQuestionariosNaListBox();
            }
        }

        private void CarregarListaDeQuestionariosNaListBox()
        {
            lstQuestionarios.Items.Clear();
            var questionarioDAO = new QuestionarioDAO();
            var questionarios = questionarioDAO.Questionario().Where(x => x.UsuarioId == fmrLogin.usuarioLogado.Id);
            foreach (var questionario in questionarios)
            {
                lstQuestionarios.Items.Add(questionario.Nome);
            }
        }

        private void lstQuestionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            questionarioAtual = new Questionario();

            var questionarioDAO = new QuestionarioDAO();
            var questionario = questionarioDAO.CarregarQuestionarioComQuestoesEAlternativas().FirstOrDefault(x => x.Nome == lstQuestionarios.SelectedItem.ToString());
            questionarioAtual = questionario;

            CarregarInformacoesDoQuestionario();
        }

        private void CarregarInformacoesDoQuestionario()
        {
            lstInformacoes.Items.Clear();

            lstInformacoes.Items.Add($"Número de questões: {questionarioAtual.Questoes.Count()}");
            lstInformacoes.Items.Add($"Data de criação: {questionarioAtual.DataCriacao}");
            lstInformacoes.Items.Add($"Data limite: {questionarioAtual.DataFim}");
            lstInformacoes.Items.Add($"Valor total: {questionarioAtual.GetTotalDePontos()} pontos");

        }
    }
}
