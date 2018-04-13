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
        private AnexoConteudoConstrutor anexoConteudoConstrutor;
        private ConteudoConstrutor conteudoConstrutor;

        public fmrAdicionarConteudo1Titulo()
        {
            InitializeComponent();
            anexoConteudoConstrutor = new AnexoConteudoConstrutor();
            this.AcceptButton = btnAvancar;
            lblErro.Visible = false;
            FormBorderStyle = FormBorderStyle.None;
            ConfigurarFileDialog();
        }

        public fmrAdicionarConteudo1Titulo(ConteudoConstrutor conteudoConstrutor, AnexoConteudoConstrutor anexoConteudoConstrutor)
        {         
            InitializeComponent();
            this.AcceptButton = btnAvancar;

            lblErro.Visible = false;

            this.anexoConteudoConstrutor = anexoConteudoConstrutor;
            this.conteudoConstrutor = conteudoConstrutor;

            MostrarNomeDoArquivo();

            txtTitulo.Text = conteudoConstrutor.Nome;
            cboTema.Text = conteudoConstrutor.Tema;
            FormBorderStyle = FormBorderStyle.None;
            ConfigurarFileDialog();          
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            try
            {
                CamposPreenchidos();

                conteudoConstrutor = new ConteudoConstrutor();
                anexoConteudoConstrutor = new AnexoConteudoConstrutor();

                conteudoConstrutor.ParaNome(txtTitulo.Text);
                conteudoConstrutor.ParaTema(cboTema.Text);
                var show = new fmrAdicionarConteudo2Texto(conteudoConstrutor, anexoConteudoConstrutor);
                show.MdiParent = ActiveForm;
                show.Dock = DockStyle.Fill;
                show.Show();
                Close();
            }
            catch (ArgumentNullException ex) when (ex.Message.Contains("Titulo"))
            {
                MostrarErro.DeixarLabelVisivelMostrarErro(lblErro, ex);
            }
            catch (ArgumentNullException ex) when (ex.Message.Contains("Tema"))
            {
                MostrarErro.DeixarLabelVisivelMostrarErro(lblErro, ex);
            }
        }

        private bool CamposPreenchidos()
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
                throw new ArgumentNullException("Titulo", "Campo Invalido");
            else if (string.IsNullOrWhiteSpace(cboTema.Text))
                throw new ArgumentNullException("Tema", "Campo Invalido");
            else return true;
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
                anexoConteudoConstrutor.ParaImagem(ConversorDeAnexos.ConverterImagem(ofdImagemDeCapa));
                MostrarNomeDoArquivo();
            }
        }

        private void ConfigurarFileDialog() =>
            ofdImagemDeCapa.Filter = "Images(*.JPG;*PNG;*.IMG)|*.JPG;*PNG;*.IMG";       

        private void MostrarNomeDoArquivo()
        {
            if (ofdImagemDeCapa.FileName.Length > 0)
            {
                anexoConteudoConstrutor.ParaNome(ofdImagemDeCapa.SafeFileName.ToString());
                txtImagemDeCapa.Text = anexoConteudoConstrutor.Nome;
            }
        }          
    }
}
