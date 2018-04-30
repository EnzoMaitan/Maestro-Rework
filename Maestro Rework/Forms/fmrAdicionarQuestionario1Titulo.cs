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
using Maestro_Rework.Classes.Construtores;
using Maestro_Rework.DAO;
using System.IO;

namespace Maestro_Rework.Forms
{
    public partial class fmrAdicionarQuestionario1Titulo : Form
    {
        private QuestionarioConstrutor questionarioConstrutor;

        public fmrAdicionarQuestionario1Titulo()
        {
            InitializeComponent();

            lblErro.Visible = false;

            FormBorderStyle = FormBorderStyle.None;

            AlterarVisibilidadePrazo(false);
        }

        
        public fmrAdicionarQuestionario1Titulo(QuestionarioConstrutor questionarioConstrutor)
        {
            this.questionarioConstrutor = questionarioConstrutor;

            InitializeComponent();

            lblErro.Visible = false;

            FormBorderStyle = FormBorderStyle.None;

            txtTitulo.Text = questionarioConstrutor.Nome;


            var possuiPrazo = questionarioConstrutor.DataFim != null && questionarioConstrutor.DataInicio != null;

            if (possuiPrazo)
            {              
                dtpFim.Value = (DateTime)questionarioConstrutor.DataFim;
                dtpInicio.Value = (DateTime)questionarioConstrutor.DataInicio;
            }
            AlterarVisibilidadePrazo(possuiPrazo);

        }

        //private void CarregarImagem(Questao questaoSelecionada)
        //{
        //    if (questaoSelecionada.Imagem != null)
        //    {
        //        MemoryStream stream = new MemoryStream(questaoSelecionada.Imagem);   
        //        pictureBox1.Image = Image.FromStream(stream);               
        //    }
        //    else
        //    {
        //        pictureBox1.Image = null;           
        //    }
        //}

        //private void AlterarQuestao(Questao questaoSelecionada)
        //{
        //    double valorPergunta = Convert.ToDouble(updValor.Value);

        //    var pergunta = questaoSelecionada.Pergunta;

        //    questaoSelecionada.AlterarPergunta(txtPergunta.Text);
        //    questaoSelecionada.AlterarValor(valorPergunta);
        //    questaoSelecionada.AlterarImagem(DefinirImagem());
        //}

        //private byte[] DefinirImagem()
        //{
        //    byte[] imagem = null;
        //    try
        //    {
        //        imagem = ConverterFoto(pictureBox1);
        //    }
        //    catch (Exception)
        //    {

        //    }

        //    return imagem;
        //}


        //private void btnImg_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        ofdImagemDaQuestao.Filter = "Images(*.JPG;*PNG;*.IMG)|*.JPG;*PNG;*.IMG";
        //        if (ofdImagemDaQuestao.ShowDialog() == DialogResult.OK)
        //        {
        //            ofdImagemDaQuestao.OpenFile();
        //            pictureBox1.ImageLocation = ofdImagemDaQuestao.FileName;
        //        }
        //    }
        //    catch (Exception) { }
        //}

        //private void btnRemoverImg_Click(object sender, EventArgs e) => pictureBox1.Image = null;

        //private byte[] ConverterFoto(PictureBox pictureBox)
        //{
        //    using (var stream = new MemoryStream())
        //    {
        //        pictureBox.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
        //        stream.Seek(0, SeekOrigin.Begin);
        //        byte[] bArray = new byte[stream.Length];
        //        stream.Read(bArray, 0, Convert.ToInt32(stream.Length));
        //        return bArray;
        //    }
        //}

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            try
            {
                CamposPreenchidos();

                questionarioConstrutor = new QuestionarioConstrutor();

                questionarioConstrutor.ParaNome(txtTitulo.Text);
                AdicionarPrazoAoConstrutor();

                var show = new fmrAdicionarQuestionario2ListaQuestoes(questionarioConstrutor);
                show.MdiParent = ActiveForm;
                show.Dock = DockStyle.Fill;
                show.Show();
                Close();
            }
            catch (ArgumentNullException ex) when (ex.Message.Contains("Titulo"))
            {
                MostrarErro.DeixarLabelVisivelMostrarErro(lblErro, ex);
            }
            catch (ArgumentException ex) when (ex.Message.Contains("Data"))
            {
                MostrarErro.DeixarLabelVisivelMostrarErro(lblErro, ex);
            }

        }

        private bool CamposPreenchidos()
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
                throw new ArgumentNullException("Titulo", "Preencha o campo");
            else return true;        
        }

        private void AdicionarPrazoAoConstrutor()
        {
            if (chkAdicionarPrazo.Checked)
            {
                questionarioConstrutor.ParaDataFim(dtpFim.Value);
                questionarioConstrutor.ParaDataInicio(dtpInicio.Value);
            }
            else
            {
                questionarioConstrutor.ParaDataFim(null);
                questionarioConstrutor.ParaDataInicio(null);
            }
        }

        private void chkAdicionarPrazo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAdicionarPrazo.Checked)
            {
                AlterarVisibilidadePrazo(true);
            }
            else
            {
                AlterarVisibilidadePrazo(false);
            }
        }

        private void AlterarVisibilidadePrazo(bool visibilidade)
        {
            dtpFim.Visible = visibilidade;
            dtpInicio.Visible = visibilidade;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
