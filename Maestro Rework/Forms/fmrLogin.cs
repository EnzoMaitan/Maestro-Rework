using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maestro_Rework.Classes.Construtores;
using Maestro_Rework.DAO;
using Maestro_Rework.Classes;
namespace Maestro_Rework.Forms
{
    public partial class fmrLogin : Form
    {
        public static Usuario usuarioLogado;
        public fmrLogin()
        {
            InitializeComponent();
            lblErro.Visible = false;
            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (CamposPreenchidos()&& Usuario.ValidarLogin(txtLogin.Text, txtSenha.Text))
                {
                    var usuarioDAO = new UsuarioDAO();
                    usuarioLogado = usuarioDAO.GetUsuarioLogado(txtLogin.Text, txtSenha.Text);
                    fmrMenu fmr = new fmrMenu();
                    fmr.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                lblErro.Visible = true;
                lblErro.Text = ex.Message;
            }
        }

        private bool CamposPreenchidos()
        {
            if (txtLogin.Text != "" && txtSenha.Text != "") return true;
            else throw new ArgumentNullException("", "Preencha os Campos");
        }


        private void lblCadastrar_Click(object sender, EventArgs e)
        {
            fmrUsuarioCadastro fmr = new fmrUsuarioCadastro();
            fmr.Show();
        }
    }
}
