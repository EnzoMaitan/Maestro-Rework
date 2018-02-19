using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maestro_Rework.Forms
{
    public partial class fmrMenu : Form
    {
        public fmrMenu()
        {
            InitializeComponent();
            IsMdiContainer = true;

            OcultarFuncionalidadesPorNivel(fmrLogin.usuarioLogado.Nivel);
        }

        private void OcultarFuncionalidadesPorNivel(int nivel)
        {
            switch (nivel)
            {
                case 1:
                    tsGerenciar.Visible = false;
                    tsAlterar.Visible = false;
                    tsAdicionar.Visible = false;
                    tsStatus.Visible = false;
                    break;
                case 2:
                    tsConteudo.Visible = false;
                    tsQuestionario.Visible = false;
                    tsGerenciar.Visible = false;
                    tsStatusUsuario.Visible = false;
                    break;
                case 3:
                    tsConteudo.Visible = false;
                    tsQuestionario.Visible = false;
                    tsConteudo.Visible = false;
                    tsQuestionario.Visible = false;
                    tsGerenciarAdministrador.Visible = false;
                    break;
            }
        }

        private void LimparMdiContainer()
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }

        private void tsPerfil_Click(object sender, EventArgs e)
        {
            LimparMdiContainer();
            fmrPerfil show = new fmrPerfil();
            show.MdiParent = this;
            show.Dock = DockStyle.Fill;
            show.Show();
        }


        private void tsCadastrarConteudo_Click(object sender, EventArgs e)
        {
            LimparMdiContainer();
            fmrAdicionarConteudo show = new fmrAdicionarConteudo();
            show.MdiParent = this;
            show.Dock = DockStyle.Fill;
            show.Show();
        }
    }
}
