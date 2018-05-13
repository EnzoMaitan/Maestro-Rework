using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            this.tipoDeAtividade = tipoDeAtividade;
            InitializeComponent();
            AlterarTextoDaTextBox(tipoDeAtividade);
            FormBorderStyle = FormBorderStyle.None;
            AtualizarListBox();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {

        }

        private void btnDestravar_Click(object sender, EventArgs e)
        {
            if (tipoDeAtividade == TipoDeAtividade.Conteudo)
            {
                var usuarioConteudo = new UsuarioConteudo(fmrLogin.usuarioLogado, txtCodigoAcesso.Text);
                usuarioConteudo.DestravarConteudo();
            }
            else if (tipoDeAtividade == TipoDeAtividade.Questionario)
            {
            }
            AtualizarListBox();
        }

        private void AtualizarListBox()
        {
            if (tipoDeAtividade == TipoDeAtividade.Conteudo)
            {
                var usuarioConteudoDAO = new UsuarioConteudoDAO();
                var conteudoDisponiveis = usuarioConteudoDAO.UsuarioConteudos().ToList();

                foreach (var conteudo in conteudoDisponiveis)
                {
                    var conteudoDAO = new ConteudoDAO();
                    var conteudoAtual = conteudoDAO.Conteudo().FirstOrDefault(x => x.Id == conteudo.ConteudoID);
                    lstAtividadesDisponiveis.Items.Add(conteudoAtual.Nome);
                }
            }
            else if (tipoDeAtividade == TipoDeAtividade.Questionario)
            {

            }
        }

        private void AlterarTextoDaTextBox(TipoDeAtividade tipoDeAtividade)
        {
            if (tipoDeAtividade == TipoDeAtividade.Conteudo)
            {
                lblAtividadesDesponiveis.Text = "Conteudo";
            }
            else if (tipoDeAtividade == TipoDeAtividade.Questionario)
            {
                lblAtividadesDesponiveis.Text = "Questionario";
            }
        }

    }
}
