using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maestro_Rework.Classes.Entidades;
using Maestro_Rework.DAO;

namespace Maestro_Rework.Forms
{
    public partial class fmrMenuAcessoAtividade : Form
    {
        TipoDeAtividade tipoDeAtividade;

        public fmrMenuAcessoAtividade(TipoDeAtividade tipoDeAtividade)
        {
            FormBorderStyle = FormBorderStyle.None;
            this.tipoDeAtividade = tipoDeAtividade;
            InitializeComponent();
            lblErro.Visible = false;
            AlterarTextoDaTextBox(tipoDeAtividade);
            AtualizarListBox();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tipoDeAtividade == TipoDeAtividade.Conteudo)
                {
                }
                else if (tipoDeAtividade == TipoDeAtividade.Questionario)
                {
                    var questionario = PesquisarQuestionario();

                    CarregarFormDeConfirmarAcesso(questionario);
                }
            }
            catch (NullReferenceException)
            {
                MostrarErro.DeixarLabelVisivelMostrarErro(lblErro, "Selecione uma Atividade");
            }
        }

        private void CarregarFormDeConfirmarAcesso(Questionario questionario)
        {
            var show = new fmrConfirmarAcessoQuestionario(questionario);
            show.MdiParent = ActiveForm;
            show.Dock = DockStyle.Fill;
            show.Show();
            Close();
        }

        private Questionario PesquisarQuestionario()
        {
            var nomeQuestionarioSelecionado = lstAtividadesDisponiveis.SelectedItem.ToString();

            var questionarioDAO = new QuestionarioDAO();
            var questionario = questionarioDAO.Questionario().First(x => x.Nome == nomeQuestionarioSelecionado);
            return questionario;
        }

        private void btnDestravar_Click(object sender, EventArgs e)
        {
            if (tipoDeAtividade == TipoDeAtividade.Conteudo)
            {
                try
                {
                    var usuarioConteudo = new UsuarioConteudo(fmrLogin.usuarioLogado, txtCodigoAcesso.Text);
                    usuarioConteudo.DestravarConteudo();
                }
                catch (ArgumentException ex) when (ex.Message.Contains("invalido"))
                {
                    MostrarErro.DeixarLabelVisivelMostrarErro(lblErro, ex);
                }
                catch (Microsoft.EntityFrameworkCore.DbUpdateException)
                {
                    MostrarErro.DeixarLabelVisivelMostrarErro(lblErro, "Conteudo já destravado");
                }
            }
            else if (tipoDeAtividade == TipoDeAtividade.Questionario)
            {
                try
                {
                    var questionarioUsuario = new QuestionarioUsuario(fmrLogin.usuarioLogado, txtCodigoAcesso.Text);
                    questionarioUsuario.DestravarQuestionario();
                }
                catch (ArgumentException ex) when (ex.Message.Contains("invalido"))
                {
                    MostrarErro.DeixarLabelVisivelMostrarErro(lblErro, ex);
                }
                catch (Exception ex) when (ex.Message.Contains("destravado"))
                {
                    MostrarErro.DeixarLabelVisivelMostrarErro(lblErro, ex);
                }
            }
            AtualizarListBox();
        }

        private void AtualizarListBox()
        {
            lstAtividadesDisponiveis.Items.Clear();
            if (tipoDeAtividade == TipoDeAtividade.Conteudo)
            {
                IEnumerable<UsuarioConteudo> conteudoDisponiveis = PesquisarConteudosDestravados();

                AdicionarNaListBoxONomeDoConteudo(conteudoDisponiveis);
            }
            else if (tipoDeAtividade == TipoDeAtividade.Questionario)
            {
                IEnumerable<QuestionarioUsuario> questionariosDisponiveis = PesquisarQuestionariosDestravados();

                AdicionarNaListBoxONomeDoQuestionario(questionariosDisponiveis);
            }
        }

        private void AdicionarNaListBoxONomeDoQuestionario(IEnumerable<QuestionarioUsuario> questionariosDisponiveis)
        {
            foreach (var questionario in questionariosDisponiveis)
            {
                var questionarioDAO = new QuestionarioDAO();
                var questionarioAtual = questionarioDAO.Questionario().FirstOrDefault(x => x.Id == questionario.QuestionarioID);
                lstAtividadesDisponiveis.Items.Add(questionarioAtual.Nome);
            }
        }

        private void AdicionarNaListBoxONomeDoConteudo(IEnumerable<UsuarioConteudo> conteudoDisponiveis)
        {
            foreach (var conteudo in conteudoDisponiveis)
            {
                var conteudoDAO = new ConteudoDAO();
                var conteudoAtual = conteudoDAO.Conteudo().FirstOrDefault(x => x.Id == conteudo.ConteudoID);
                lstAtividadesDisponiveis.Items.Add(conteudoAtual.Nome);
            }
        }

        private static IEnumerable<UsuarioConteudo> PesquisarConteudosDestravados()
        {
            var usuarioConteudoDAO = new UsuarioConteudoDAO();
            var conteudoDisponiveis = usuarioConteudoDAO.UsuarioConteudos().Where(x => x.UsuarioID == fmrLogin.usuarioLogado.Id);
            return conteudoDisponiveis;
        }

        private static IEnumerable<QuestionarioUsuario> PesquisarQuestionariosDestravados()
        {
            var questionarioUsuarioDAO = new QuestionarioUsuarioDAO();
            var questionariosDisponiveis = questionarioUsuarioDAO.QuestionarioUsuario().Where(x => x.UsuarioID == fmrLogin.usuarioLogado.Id);
            return questionariosDisponiveis;
        }

        private void AlterarTextoDaTextBox(TipoDeAtividade tipoDeAtividade)
        {
            if (tipoDeAtividade == TipoDeAtividade.Conteudo)
            {
                lblAtividadesDesponiveis.Text = "Conteúdos disponiveis";
                lbl2.Text = "Anexos Disponíveis";
            }
            else if (tipoDeAtividade == TipoDeAtividade.Questionario)
            {
                lblAtividadesDesponiveis.Text = "Questionario disponiveis";
                lbl2.Text = "Informações";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmrMenuAcessoAtividade_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
        }

        private void lstAtividadesDisponiveis_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstInformacoes.Items.Clear();
            try
            {
                MostrarAsInformacoesDoQuestionario();
            }
            catch (Exception){}
        }

        private void lstAtividadesDisponiveis_Click(object sender, EventArgs e)
        {
            lstInformacoes.Items.Clear();
            try
            {
                MostrarAsInformacoesDoQuestionario();
            }
            catch (Exception){}
        }

        private void MostrarAsInformacoesDoQuestionario()
        {
            var questionario = PesquisarQuestionario();
            lstInformacoes.Items.Add($"Nome do questionario: {questionario.Nome}");
            lstInformacoes.Items.Add($"Data de criação:  {questionario.DataCriacao}");
            lstInformacoes.Items.Add($"Código de acesso: {questionario.CodigoAcesso}");
            lstInformacoes.Items.Add($"Data Limite:      {questionario.DataFim}");
        }
    }
}
