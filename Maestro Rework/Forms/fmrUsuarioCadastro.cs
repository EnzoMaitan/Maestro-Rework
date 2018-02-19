using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Maestro_Rework.Classes.Construtores;
using Maestro_Rework.DAO;


namespace Maestro_Rework.Forms
{
    public partial class fmrUsuarioCadastro : Form
    {
        public fmrUsuarioCadastro()
        {
            InitializeComponent();
            lblErro.Visible = false;
            lblUsuarioCadastrado.Visible = false;
            lblUsuario.Visible = false;
            cboSelecionar.Visible = false;
        }

        private void BtnAcao_Click(object sender, EventArgs e)
        {
            lblErro.Visible = false;
            lblUsuarioCadastrado.Visible = false;

            try
            {
                if (SenhaCoincide() && NomeDisponivel() && CamposPreenchidos())
                {
                    using (var contexto = new MaestroContext())
                    {
                        var usuarioDao = new UsuarioDAO();
                        var usuarioBuilder = new UsuarioConstrutor();

                        var usuario = usuarioBuilder.ParaNome(txtNome.Text)
                               .ParaLogin(txtLogin.Text)
                               .ParaSenha(txtSenha.Text)
                               .ParaCargo("Aluno")
                               .ParaNivel(1)
                               .ParaEmail(txtEmail.Text)
                               .Constroi();

                        usuarioDao.Adicionar(usuario);

                        lblUsuarioCadastrado.Visible = true;
                        LimparCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                lblErro.Visible = true;
                lblErro.Text = ex.Message;
            }
        }

        private void LimparCampos()
        {
            txtConf.Text = null;
            txtEmail.Text = null;
            txtLogin.Text = null;
            txtNome.Text = null;
            txtSenha.Text = null;
        }
        private bool CamposPreenchidos()
        {
            if (txtConf.Text != null && txtEmail.Text != null &&
               txtLogin.Text != null && txtNome.Text != null) return true;
            else throw new Exception("Preencha todos os campos");
        }
        private bool NomeDisponivel()
        {
            using (var contexto = new MaestroContext())
            {
                var LoginEmUso = contexto.Usuarios.Where(x => x.Login == txtLogin.Text);
                if (LoginEmUso.FirstOrDefault() == null) return true;
                else throw new Exception("Login já em uso");
            }
        }
        private bool SenhaCoincide()
        {
            if (txtSenha.Text == txtConf.Text) return true;
            else throw new Exception("Senhas Não Coincidem");
        }
    }
}
