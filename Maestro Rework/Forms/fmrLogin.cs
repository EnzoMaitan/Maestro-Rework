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
        public static Usuario usuarioLogado = new Usuario();
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
                    if (ValidarLogin(contexto) && CamposPreenchidos())
                    {
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
            if (txtLogin.Text != null && txtSenha != null) return true;
            else throw new Exception("Preencha os Campos");
        }

        private bool ValidarLogin(MaestroContext contexto)
        {
            var query = contexto.Usuarios.Where(x => x.Login == txtLogin.Text && x.Senha == txtSenha.Text);
            if (query.FirstOrDefault() != null)
            {
                usuarioLogado = query.FirstOrDefault();  
                return true;
            }
            else throw new Exception("Usuario Invalido");
        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {
            fmrUsuarioCadastro fmr = new fmrUsuarioCadastro();
            fmr.Show();
        }

        private void fmrLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
