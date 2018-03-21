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
        private ConteudoConstrutor conteudoConstrutor;

        public fmrAdicionarConteudo1Titulo()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            ConfigurarFileDialog();
        }

        public fmrAdicionarConteudo1Titulo(ConteudoConstrutor conteudoConstrutor, byte[] imagemDeCapa, string nomeDaImagemCapa)
        {         
            InitializeComponent();

            this.imagemDeCapa = imagemDeCapa;
            this.conteudoConstrutor = conteudoConstrutor;
            MostrarNomeDoArquivo();
            txtTitulo.Text = conteudoConstrutor.Nome;
            cboTema.Text = conteudoConstrutor.Tema;
            FormBorderStyle = FormBorderStyle.None;
            ConfigurarFileDialog();          
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            conteudoConstrutor = new ConteudoConstrutor();

            conteudoConstrutor.ParaNome(txtTitulo.Text);
            conteudoConstrutor.ParaTema(cboTema.Text);
            var show = new fmrAdicionarConteudo2Texto(conteudoConstrutor, imagemDeCapa, nomeDaImagemCapa);
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
            if (ofdImagemDeCapa.FileName.Length > 0)
            {
                nomeDaImagemCapa = ofdImagemDeCapa.SafeFileName.ToString();
                txtImagemDeCapa.Text = nomeDaImagemCapa;
            }
            else
                nomeDaImagemCapa = null;
        }

        private byte[] AdicionarImagem(ConversorDeAnexos addAnexo) =>
             addAnexo.DatabaseFilePut(Path.GetFullPath(ofdImagemDeCapa.FileName));           
    }
}
