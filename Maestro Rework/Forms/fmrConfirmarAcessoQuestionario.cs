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
using Maestro_Rework.DAO;

namespace Maestro_Rework.Forms
{
    public partial class fmrConfirmarAcessoQuestionario : Form
    {
        Questionario questionario;
        public fmrConfirmarAcessoQuestionario(Questionario questionario)
        {
            InitializeComponent();
            this.questionario = questionario;
            CarregarInformacoesDoQuestionario();
            FormBorderStyle = FormBorderStyle.None;
            lblErro.Visible = false;
        }

        private void CarregarInformacoesDoQuestionario()
        {
            lblTitulo.Text = $"Titulo: {questionario.Nome}";

            MostratPrazo();
            MostrarLimiteDeTentativas();
            MostrarTentativasRestantesENotaAnterior();
        }

        private void MostratPrazo()
        {
            if (questionario.DataFim == null)
            {
                lblPrazo.Text = "Prazo: Não há prazo";
            }
            else
                lblPrazo.Text = $"Prazo: {questionario.DataFim.ToString()}";
        }

        private void MostrarLimiteDeTentativas()
        {
            if (questionario.Refazer)
                lblNumeroTentativas.Text = "Número de tentativas: 2";
            else
                lblNumeroTentativas.Text = "Número de tentativas: 1";
        }

        private void MostrarTentativasRestantesENotaAnterior()
        {
            var questionarioUsuarioDAO = new QuestionarioUsuarioDAO();
            var QU = questionarioUsuarioDAO.QuestionarioUsuario().First(x => x.UsuarioID == fmrLogin.usuarioLogado.Id && x.QuestionarioID == questionario.Id);

            if (QU.Refez == null && questionario.Refazer == false)
            {
                lblTentativasRestantes.Text = "Tentativas Restantes: 1";
                lblNotaAnterior.Text = "Nota Anterior: Nenhuma nota registrada";
            }
            else if (QU.Refez == false && questionario.Refazer == false)
            {
                lblTentativasRestantes.Text = "Tentativas Restantes: 0";
                //lblNotaAnterior.Text = "Nota Anterior: {}";
            }
            else if (QU.Refez == null)
            {
                lblTentativasRestantes.Text = "Tentativas Restantes: 2";
                lblNotaAnterior.Text = "Nota Anterior: Nenhuma nota registrada";
            }
            else if (QU.Refez == false)
            {
                lblTentativasRestantes.Text = "Tentativas Restantes: 1";
                //lblNotaAnterior.Text = $"Nota Anterior: {}";
            }
            else if (QU.Refez == true)
                lblTentativasRestantes.Text = "Tentativas Restantes: 0";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            var questionarioUsuarioDAO = new QuestionarioUsuarioDAO();
            var QU = questionarioUsuarioDAO.QuestionarioUsuario().First(x => x.UsuarioID == fmrLogin.usuarioLogado.Id && x.QuestionarioID == questionario.Id);

            try
            {
                var tentativasRestantes = QU.GetNumeroDeTentativasRestantes();
                if(tentativasRestantes == 2)
                {
                    QU.Refez = false;
                    CarregarOFormDeResponderQuestionario(numeroDaTentativa: 1, QU: QU);
                    questionarioUsuarioDAO.Atualizar(QU);
                }
                else if (tentativasRestantes == 1)
                {
                    QU.Refez = true;
                    CarregarOFormDeResponderQuestionario(numeroDaTentativa: 2, QU: QU);
                    questionarioUsuarioDAO.Atualizar(QU);
                }

            }
            catch (Exception ex)
            {
                MostrarErro.DeixarLabelVisivelMostrarErro(lblErro, ex);
            }
            
        }

        private void CarregarOFormDeResponderQuestionario(int numeroDaTentativa, QuestionarioUsuario QU)
        {
            var show = new fmrResponderQuestionario(questionario, numeroDaTentativa, QU);
            show.MdiParent = ActiveForm;
            show.Dock = DockStyle.Fill;
            show.Show();
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var show = new fmrMenuAcessoAtividade(TipoDeAtividade.Questionario);
            show.MdiParent = ActiveForm;
            show.Dock = DockStyle.Fill;
            show.Show();
            Close();
        }
    }
}
