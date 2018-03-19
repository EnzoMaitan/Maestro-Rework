using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maestro_Rework.DAO;
using Maestro_Rework.Classes.Construtores;
using Maestro_Rework.Classes;
using System.IO;

namespace Maestro_Rework.Forms
{
    public partial class fmrAdicionarConteudo1Titulo : Form
    {
        private string nomeDaImagemCapa;
        private byte[] imagemDeCapa;
        private string tituloDoConteudo;
        private string temaDoConteudo;

        public fmrAdicionarConteudo1Titulo()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            ConfigurarFileDialog();
        }

        public fmrAdicionarConteudo1Titulo(string tituloDoConteudo, byte[] imagemDeCapa, string nomeDaImagemCapa, string temaDoConteudo)
        {
            InitializeComponent();
            this.imagemDeCapa = imagemDeCapa;
            this.tituloDoConteudo = tituloDoConteudo;
            this.nomeDaImagemCapa = nomeDaImagemCapa;
            this.temaDoConteudo = temaDoConteudo;

            MostrarNomeDoArquivo();
            txtTitulo.Text = tituloDoConteudo;
            cboTema.SelectedText = temaDoConteudo;
            FormBorderStyle = FormBorderStyle.None;
            ConfigurarFileDialog();          
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            this.tituloDoConteudo = txtTitulo.Text;
            this.temaDoConteudo = cboTema.Text;
            var show = new fmrAdicionarConteudo2Texto(tituloDoConteudo, imagemDeCapa, nomeDaImagemCapa, temaDoConteudo);
            show.MdiParent = ActiveForm;
            show.Dock = DockStyle.Fill;
            show.Show();
            Close();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdicionarImagem_Click(object sender, EventArgs e)
        {
            if (ofdImagemDeCapa.ShowDialog() == DialogResult.OK)
            {
                ofdImagemDeCapa.OpenFile();
            }

            bool possuiArquivoAdicionado = ofdImagemDeCapa.FileName.Length > 0;

            if (possuiArquivoAdicionado)
            {
                var addAnexo = new ConversorDeAnexos();

                imagemDeCapa = AdicionarImagem(addAnexo);
                MostrarNomeDoArquivo();
            }
        }

        private void ConfigurarFileDialog()
        {
            ofdImagemDeCapa.Filter = "Images(*.JPG;*PNG;*.IMG)|*.JPG;*PNG;*.IMG";
        }

        private void MostrarNomeDoArquivo()
        {
            if(ofdImagemDeCapa.FileName.Length > 0)
             this.nomeDaImagemCapa = ofdImagemDeCapa.SafeFileName.ToString();

            txtImagemDeCapa.Text = nomeDaImagemCapa;
        }

        private byte[] AdicionarImagem(ConversorDeAnexos addAnexo) =>
             addAnexo.DatabaseFilePut(Path.GetFullPath(ofdImagemDeCapa.FileName));           
    }
}
