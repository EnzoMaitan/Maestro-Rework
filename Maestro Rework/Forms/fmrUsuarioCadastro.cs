using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Maestro_Rework.Classes.Construtores;
using Maestro_Rework.DAO;
using BCrypt;

namespace Maestro_Rework.Forms
{
    public partial class fmrUsuarioCadastro : Form
    {
        public fmrUsuarioCadastro()
        {
            InitializeComponent();
            lblErro.Visible = false;
            lblUsuarioCadastrado.Visible = false;
            this.AcceptButton = btnAcao;

            FormBorderStyle = FormBorderStyle.None;

        }

        private void BtnAcao_Click(object sender, EventArgs e)
        {
            lblErro.Visible = false;
            lblUsuarioCadastrado.Visible = false;
            var usuarioDAO = new UsuarioDAO();

            try
            {
                if (SenhaCoincide() && usuarioDAO.LoginDisponivel(txtLogin.Text))
                {
                    CadastrarAluno();
                    LimparCampos();
                    lblUsuarioCadastrado.Visible = true;
                }
            }
            catch (ArgumentNullException ex)
            {
                MostrarErro.DeixarLabelVisivelMostrarErro(lblErro, ex);
            }
            catch (Exception ex)
            {
                MostrarErro.DeixarLabelVisivelMostrarErro(lblErro, ex);
            }
        }
        private void CadastrarAluno()
        {
            var usuarioDao = new UsuarioDAO();
            var usuarioConstrutor = new UsuarioConstrutor();

            var aluno = usuarioConstrutor.ParaNome(txtNome.Text)
                    .ParaLogin(txtLogin.Text)
                    .ParaSenha(txtSenha.Text)
                    .ParaEmail(txtEmail.Text)
                    .ConstroiAluno();

            usuarioDao.Adicionar(aluno);
        }

        private void LimparCampos()
        {
            txtConf.Clear();
            txtEmail.Clear();
            txtLogin.Clear();
            txtNome.Clear();
            txtSenha.Clear();
        }

        private bool SenhaCoincide()
        {
            if (txtSenha.Text == txtConf.Text) return true;
            else throw new ArgumentException("Senhas Não Coincidem");
        }

        private void fmrUsuarioCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            fmrLogin formLogin = (fmrLogin)ActiveForm;
            formLogin.MostrarElementosDoFormLogin();
            Close();
        }
    }
}
