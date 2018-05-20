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
using Maestro_Rework.Classes.Entidades;

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
            IsMdiContainer = true;
            AlterarEstiloDoBackground.CarregarBackGroundColourDoMDIContainer(this);
            MdiChildActivate += EsconderElementosDoFormLogin;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Task<bool> t = Task<bool>.Factory.StartNew(() => Usuario.ValidarLogin(txtLogin.Text, txtSenha.Text));
                
                if (CamposPreenchidos()&& t.Result)
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
                MostrarErro.DeixarLabelVisivelMostrarErro(lblErro, ex);
            }
        }

        private bool CamposPreenchidos()
        {
            if (txtLogin.Text != "" && txtSenha.Text != "") return true;
            else throw new ArgumentNullException("", "Preencha os Campos");
        }


        private void lblCadastrar_Click(object sender, EventArgs e)
        {
            fmrUsuarioCadastro show = new fmrUsuarioCadastro();
            show.MdiParent = this;
            show.Dock = DockStyle.Fill;
            show.Show();
        }

        private void lblRecSenha_Click(object sender, EventArgs e)
        {
            var show = new fmrRecuperarSenha1();
            show.MdiParent = this;
            show.Dock = DockStyle.Fill;
            show.Show();
        }

        private void EsconderElementosDoFormLogin(object sender, EventArgs e)
        {
            AlterarVisibilidadeDosElementos(false);
        }
        public void MostrarElementosDoFormLogin()
        {
            ActiveMdiChild.Close();
            AlterarVisibilidadeDosElementos(true);
        }
        private void AlterarVisibilidadeDosElementos(bool visivel)
        {
            this.txtLogin.Visible = visivel;
            this.txtSenha.Visible = visivel;
            this.btnLogin.Visible = visivel;
            this.lblCadastrar.Visible = visivel;
            this.lblRecSenha.Visible = visivel;
            this.pictureBox1.Visible = visivel;
            this.label2.Visible = visivel;
            this.label3.Visible = visivel;
        }

        private void fmrLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
