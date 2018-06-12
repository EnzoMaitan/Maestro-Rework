using Maestro_Rework.Classes.Entidades;
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
    public partial class fmrAcessarConteudo : Form
    {
        Conteudo conteudo;

        public fmrAcessarConteudo(Conteudo conteudo)
        {
            this.conteudo = conteudo;
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            CarregarInformacoesDoConteudo();
        }

        private void CarregarInformacoesDoConteudo()
        {
            lblNome.Text = conteudo.Nome;
            txtConteudo.Text = conteudo.Texto;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
