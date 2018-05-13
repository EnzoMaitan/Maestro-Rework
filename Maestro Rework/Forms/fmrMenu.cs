using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

            panel1.BorderStyle = BorderStyle.None;
        }

        private void OcultarFuncionalidadesPorNivel()
        {
            if (fmrLogin.usuarioLogado is Aluno)
            {

            }
            else if (fmrLogin.usuarioLogado is Professor)
            {
            }
            else if (fmrLogin.usuarioLogado is Administrador)
            {
            }
        }

        private void LimparMdiContainer()
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            LimparMdiContainer();

            var show = new fmrPerfil
            {
                MdiParent = this,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None
            };
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

            if (fmrLogin.usuarioLogado is Professor)
            {
                MostrarFormGerenciarAtividade(TipoDeAtividade.Questionario);
            }
            if (fmrLogin.usuarioLogado is Aluno)
            {
                MostrarFormMenuAcessoAtividade(TipoDeAtividade.Questionario);
            }
        }

        private void btnConteudo_Click(object sender, EventArgs e)
        {
            LimparMdiContainer();

            if (fmrLogin.usuarioLogado is Professor)
            {
                MostrarFormGerenciarAtividade(TipoDeAtividade.Conteudo);
            }        
            else if (fmrLogin.usuarioLogado is Aluno)
            {
                MostrarFormMenuAcessoAtividade(TipoDeAtividade.Conteudo);
            }
        }

        private void MostrarFormGerenciarAtividade(TipoDeAtividade tipoDeAtividade)
        {    
            var show = new fmrGerenciarAtividade(tipoDeAtividade)
            {
                MdiParent = this,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None
            };
            show.Show();
        }

        private void MostrarFormMenuAcessoAtividade(TipoDeAtividade tipoDeAtividade)
        {
            var show = new fmrMenuAcessoAtividade(tipoDeAtividade)
            {
                MdiParent = this,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None                
            };
            show.Show();
        }

        private void fmrMenu_Load(object sender, EventArgs e)
        {
           AlterarEstiloDoBackground.CarregarBackGroundColourDoMDIContainer(this);
        }
    }
}
