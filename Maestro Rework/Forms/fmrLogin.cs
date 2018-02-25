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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (var contexto = new MaestroContext())
                {
                    var usuarioDAO = new UsuarioDAO();
                    if (CamposPreenchidos()&&usuarioDAO.ValidarLogin(txtLogin.Text, txtSenha.Text))
                    {
                        usuarioLogado = usuarioDAO.GetUsuarioLogado(txtLogin.Text, txtSenha.Text);
                        fmrMenu fmr = new fmrMenu();
                        fmr.Show();
                        Hide();
                    }
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
