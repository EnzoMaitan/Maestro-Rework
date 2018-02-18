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
        static Usuario usuarioLogado = new Usuario();
        public fmrLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (var contexto = new MaestroContext())
                {
                    if (ValidarLogin(contexto))
                    {
                        MessageBox.Show(usuarioLogado.Nome.ToString());
                        fmrMenu fmr = new fmrMenu();
                        fmr.Show();
                        Hide();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
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
    }
}
