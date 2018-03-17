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
using Maestro_Rework.DAO;

namespace Maestro_Rework.Forms
{
    public partial class fmrPerfil : Form
    {
        public fmrPerfil()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            CarregarInformacoes();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (SenhaCoincide())
                {
                    var usuario = GetUsuarioAtualizado(fmrLogin.usuarioLogado);
                    usuario.AtualizarSenha(txtSenha.Text);

                    var usuarioDAO = new UsuarioDAO();
                    usuarioDAO.Atualizar(usuario);
                    usuarioDAO.Dispose();
                }
            }
            catch (Exception ex)
            {
                lblErro.Visible = true;
                lblErro.Text = ex.Message;
            }
        }

        private bool SenhaCoincide()
        {
            if (txtSenha.Text == txtSenhaConf.Text) return true;
            else throw new Exception("Senhas Não Coincidem");
        }

        private void CarregarInformacoes()
        {
            try
            {
                var usuario = GetUsuarioAtualizado(fmrLogin.usuarioLogado);
                txtNome.Text = usuario.Nome;
                txtLogin.Text = usuario.Login;
                txtEmail.Text = usuario.Email;
                usuario.CheckarEmailConfirmado();
              
            }
            catch (Exception ex)
            {
                lblErro.Visible = true;
                lblErro.Text = ex.Message;
                if(ex.Message.Contains("Email Não Confirmado"))chkAlterarSenha.Enabled = false;             
            }
        }
      
        private Usuario GetUsuarioAtualizado(Usuario usuario)
        {
            using (var contexto = new MaestroContext())
            {
                return contexto.Usuarios.FirstOrDefault(x => x.Id == usuario.Id);
            }
        }

        private void cbxAlterar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlterarSenha.Checked)
            {
                lblSenhaAtual.Visible = true;
                lblNovaSenha.Visible = true;
                txtSenha.Visible = true;
                txtSenhaConf.Visible = true;
                btnSalvarSenha.Visible = true;
            }
            else
            {
                lblSenhaAtual.Visible = false;
                lblNovaSenha.Visible = false;
                txtSenha.Visible = false;
                txtSenhaConf.Visible = false;
                btnSalvarSenha.Visible = false;
            }
        }

        private void fmrPerfil_Load(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }
    }
}
