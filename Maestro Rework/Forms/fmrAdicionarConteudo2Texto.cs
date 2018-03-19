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
    public partial class fmrAdicionarConteudo2Texto : Form
    {
        private byte[] imagemDeCapa;
        private string tituloDoConteudo;
        private string nomeDaImagemCapa;
        private string texto;
        private string temaDoConteudo;

        public fmrAdicionarConteudo2Texto(string tituloDoConteudo, byte[] imagemDeCapa, string nomeDaImagemCapa, string temaDoConteudo)
        {
            this.tituloDoConteudo = tituloDoConteudo;
            this.imagemDeCapa = imagemDeCapa;
            this.nomeDaImagemCapa = nomeDaImagemCapa;
            this.temaDoConteudo = temaDoConteudo;

            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
        }

        public fmrAdicionarConteudo2Texto(string tituloDoConteudo, byte[] imagemDeCapa, string nomeDaImagemCapa, string temaDoConteudo, string texto)
        {
            this.tituloDoConteudo = tituloDoConteudo;
            this.imagemDeCapa = imagemDeCapa;
            this.nomeDaImagemCapa = nomeDaImagemCapa;
            this.texto = texto;
            this.temaDoConteudo = temaDoConteudo;

            InitializeComponent();

            rtfTextoConteudo.Text = texto;

            FormBorderStyle = FormBorderStyle.None;
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            this.texto = rtfTextoConteudo.Text;

            var show = new fmrAdicionarConteudo3Anexos(tituloDoConteudo, imagemDeCapa, nomeDaImagemCapa, temaDoConteudo, texto);
            show.MdiParent = ActiveForm;
            show.Dock = DockStyle.Fill;
            show.Show();
            Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var show = new fmrAdicionarConteudo1Titulo(tituloDoConteudo, imagemDeCapa, nomeDaImagemCapa, temaDoConteudo);
            show.MdiParent = ActiveForm;
            show.Dock = DockStyle.Fill;
            show.Show();
            Close();
        }
    }
}
