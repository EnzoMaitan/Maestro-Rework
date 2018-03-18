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
    public partial class fmrContCodigo : Form
    {
        public fmrContCodigo()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            lblErro.Visible = false;
            lblConteudo.Visible = false;
            cboSelecionar.Visible = false;
            lblConteudoAdicionado.Visible = false;
            ConfigurarFileDialogs();          
        }

        private void btnAcao_Click(object sender, EventArgs e)
        {
            lblErro.Visible = false;
            lblConteudoAdicionado.Visible = false;
            txtCodigo.Text = null;
            Conteudo conteudo;
           
            try
            {
                CheckarCamposPreenchidos();

                conteudo = AdicionarConteudo();
                AdicionarAnexos(conteudo);

                lblConteudoAdicionado.Visible = true;
                txtCodigo.Text = conteudo.CodigoAcesso;

                LimparCampos();
            }
            catch (Exception ex)
            {
                lblErro.Visible = true;
                lblErro.Text = ex.Message;
            }
        }

        private  void AdicionarAnexos(Conteudo conteudoCriado)
        {
            bool possuiArquivoAdicionado = 
                (ofdArquivosAnexo.FileName.Length > 0) || (ofdImagemDeCapa.FileName.Length > 0);

            if (possuiArquivoAdicionado)
            {
                var addAnexo = new ConversorDeAnexos();
                AdicionarImagem(conteudoCriado, addAnexo);
                AdicionarArquivos(conteudoCriado, addAnexo);
            }
        }

        private void AdicionarArquivos(Conteudo conteudoCriado, ConversorDeAnexos addAnexo)
        {
            var anexoConteudoDAO = new AnexoConteudoDAO();

            string[] anexoArquivos = ofdArquivosAnexo.FileNames;

            foreach (var arquivosSelecionados in anexoArquivos)
            {
                var anexos = new AnexoConteudoConstrutor();

                string nomeArquivo = ofdArquivosAnexo.SafeFileName.ToString();

                var arquivo = anexos.ParaConteudo(conteudoCriado)
                    .ParaImagem(null)
                    .ParaNome(nomeArquivo)
                    .ParaAnexo(addAnexo.DatabaseFilePut(arquivosSelecionados))
                    .Constroi();

                anexoConteudoDAO.Adicionar(arquivo);
            }
        }

        private void AdicionarImagem(Conteudo conteudoCriado, ConversorDeAnexos addAnexo)
        {
            var anexoConteudoDAO = new AnexoConteudoDAO();
            var anexoConstrutor = new AnexoConteudoConstrutor();
            
            var imagem = addAnexo.DatabaseFilePut(Path.GetFullPath(ofdImagemDeCapa.FileName));
            string nomeImagem = ofdImagemDeCapa.SafeFileName.ToString();

            var anexoImagem = anexoConstrutor.ParaConteudo(conteudoCriado)
                    .ParaImagem(imagem)
                    .ParaAnexo(null)
                    .ParaNome(nomeImagem)
                    .Constroi();

            anexoConteudoDAO.Adicionar(anexoImagem);
        }

        private Conteudo AdicionarConteudo()
        {
            var construtorConteudo = new ConteudoConstrutor();
            var conteudoDAO = new ConteudoDAO();
            construtorConteudo.ParaNome(txtNome.Text)
                .ParaTema(cboTema.Text)
                .ParaAtivo(true)
                .ParaTexto(rtfTexto.Text)
                .ParaUsuario(fmrLogin.usuarioLogado);

            var conteudoCriado = construtorConteudo.Constroi();

            conteudoDAO.Adicionar(conteudoCriado);

            return conteudoCriado;
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            rtfTexto.Clear();
            cboTema.Text = "";
            lstAnexoAdicionados.Items.Clear();
        }

        private void CheckarCamposPreenchidos()
        {
            if (txtNome.Text == "" ||
               rtfTexto.Text == "" ||
               cboTema.Text == "") throw new ArgumentNullException("","Preencha Todos os campos obrigatórios");
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            ofdImagemDeCapa.Reset();
            ConfigurarFileDialogs();

            if (ofdImagemDeCapa.ShowDialog() == DialogResult.OK)
            {         
                ofdImagemDeCapa.OpenFile();
                lstAnexoAdicionados.Items.Add(GetNomeArquivo(ofdImagemDeCapa));
            }
        }

        private void btnApagarAnexos_Click(object sender, EventArgs e)
        {
            ofdArquivosAnexo.Reset();
            ofdImagemDeCapa.Reset();
            lstAnexoAdicionados.DataSource = null;
            lstAnexoAdicionados.Items.Clear();
        }

        private void btnArquivos_Click(object sender, EventArgs e)
        {
            ofdArquivosAnexo.Reset();
            ConfigurarFileDialogs();

            if (ofdArquivosAnexo.ShowDialog() == DialogResult.OK)
            {
                lstAnexoAdicionados.DataSource = null;
                lstAnexoAdicionados.Items.Clear();

                ofdArquivosAnexo.OpenFile();
                string[] anexos = ofdArquivosAnexo.FileNames;
                foreach (string arquivo in anexos)
                {
                    if(ofdImagemDeCapa.FileNames.Count() > 0)
                     lstAnexoAdicionados.Items.Add(GetNomeArquivo(ofdImagemDeCapa));

                    lstAnexoAdicionados.Items.Add(Path.GetFileName(arquivo));
                }
            }
        }

        private string GetNomeArquivo(OpenFileDialog fileDialog)=>
         Path.GetFileName(fileDialog.FileName.ToString());

        private void ConfigurarFileDialogs()
        {
            ofdImagemDeCapa.Filter = "Images(*.JPG;*PNG;*.IMG)|*.JPG;*PNG;*.IMG";
            ofdArquivosAnexo.Filter = "Anexos(*.docx;*.ppt;*.doc;*.xls;*.pdf,*.txt;)|*.docx;*.ppt;*.doc;*.xls;*.pdf,*.txt";
            ofdArquivosAnexo.Multiselect = true;
            ofdArquivosAnexo.RestoreDirectory = true;
        }
    }
}
