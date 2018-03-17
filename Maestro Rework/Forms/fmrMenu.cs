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

namespace Maestro_Rework.Forms
{
    public partial class fmrMenu : Form
    {
        public fmrMenu()
        {
            InitializeComponent();
            IsMdiContainer = true;

            OcultarFuncionalidadesPorNivel(fmrLogin.usuarioLogado.Nivel);
            lblNome.Text = $"Olá, {fmrLogin.usuarioLogado.Nome}";          
        }

        private void OcultarFuncionalidadesPorNivel(int nivel)
        {
        }

        private void LimparMdiContainer()
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }

        //private void tsCadastrarConteudo_Click(object sender, EventArgs e)
        //{
        //    LimparMdiContainer();
        //    fmrAdicionarConteudo show = new fmrAdicionarConteudo();
        //    show.MdiParent = this;
        //    show.Dock = DockStyle.Fill;
        //    show.Show();
        //}

        //private void tsCadastrarQuestionario_Click(object sender, EventArgs e)
        //{
        //    LimparMdiContainer();
        //    fmrAdicionarQuestionario show = new fmrAdicionarQuestionario();
        //    show.MdiParent = this;
        //    show.Dock = DockStyle.Fill;
        //    show.Show();
        //}

        private void button6_Click(object sender, EventArgs e)
        {
            LimparMdiContainer();
            var show = new fmrAdicionarConteudo();
            show.MdiParent = this;
            show.Dock = DockStyle.Fill;
            show.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LimparMdiContainer();
            var show = new fmrAdicionarQuestionario();
            show.MdiParent = this;
            show.Dock = DockStyle.Fill;
            show.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            LimparMdiContainer();
            var show = new fmrPerfil();
            show.MdiParent = this;
            show.Dock = DockStyle.Fill;
            show.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var show = new fmrLogin();
            fmrLogin.usuarioLogado = null;
            show.Show();
            Close();          
        }
    }
}
