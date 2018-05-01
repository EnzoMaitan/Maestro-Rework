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
using Maestro_Rework.Classes.Entidades;

namespace Maestro_Rework.Forms
{
    public partial class fmrMenu : Form
    {
        public fmrMenu()
        {
            InitializeComponent();
            IsMdiContainer = true;

            OcultarFuncionalidadesPorNivel();
            lblNome.Text = $"Olá, {fmrLogin.usuarioLogado.Nome}";          
        }

        private void OcultarFuncionalidadesPorNivel()
        {
            if (fmrLogin.usuarioLogado is Aluno)
            { }
            if (fmrLogin.usuarioLogado is Professor)
            { }
            if (fmrLogin.usuarioLogado is Administrador)
            { }
        }

        private void LimparMdiContainer()
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
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

        private void btnQuestionario_Click(object sender, EventArgs e)
        {
            LimparMdiContainer();
            var show = new fmrGerenciarAtividade(TipoDeAtividade.Questionario);
            show.MdiParent = this;
            show.Dock = DockStyle.Fill;
            show.Show();
        }

        private void btnConteudo_Click(object sender, EventArgs e)
        {
            LimparMdiContainer();
            var show = new fmrGerenciarAtividade(TipoDeAtividade.Conteudo);
            show.MdiParent = this;
            show.Dock = DockStyle.Fill;
            show.Show();
        }

        private void fmrMenu_Load(object sender, EventArgs e)
        {
           AlterarEstiloDoBackground.CarregarBackGroundColourDoMDIContainer(this);
        }
    }
}
