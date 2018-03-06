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
    public partial class fmrAdicionarConteudo : Form
    {
        public fmrAdicionarConteudo()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            lblErro.Visible = false;
            lblConteudo.Visible = false;
            cboSelecionar.Visible = false;
            lblConteudoAdicionado.Visible = false;
            AlterarVisibilidadePrazo(false);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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
            lblFim.Visible = visibilidade;
            lblInicio.Visible = visibilidade;
            dtpFim.Visible = visibilidade;
            dtpInicio.Visible = visibilidade;
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
                (openFileDialog1.FileName.Length > 0) || (openFileDialog2.FileName.Length > 0);

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

            string[] anexoArquivos = openFileDialog1.FileNames;

            foreach (var arquivosSelecionados in anexoArquivos)
            {
                var anexos = new AnexoConteudoConstrutor();

                string nomeArquivo = openFileDialog1.SafeFileName.ToString();

                var arquivo = anexos.ParaConteudo(conteudoCriado)
                    .ParaImagem(null)
                    .ParaNome(nomeArquivo)
                    .ParaAnexo(addAnexo.databaseFilePut(arquivosSelecionados))
                    .Constroi();

                anexoConteudoDAO.Adicionar(arquivo);
            }
        }

        private void AdicionarImagem(Conteudo conteudoCriado, ConversorDeAnexos addAnexo)
        {
            var anexoConteudoDAO = new AnexoConteudoDAO();
            var anexoConstrutor = new AnexoConteudoConstrutor();
            
            var imagem = addAnexo.databaseFilePut(Path.GetFullPath(openFileDialog2.FileName));
            string nomeImagem = openFileDialog2.SafeFileName.ToString();

            var anexoImagem = anexoConstrutor.ParaConteudo(conteudoCriado)
                    .ParaImagem(imagem)
                    .ParaAnexo(null)
                    .ParaNome(nomeImagem)
                    .Constroi();

            anexoConteudoDAO.Adicionar(anexoImagem);
        }

        private Conteudo AdicionarConteudo()
        {
            Conteudo conteudoCriado;
            var construtorConteudo = new ConteudoConstrutor();
            var conteudoDAO = new ConteudoDAO();
            construtorConteudo.ParaNome(txtNome.Text)
                .ParaTema(cboTema.Text)
                .ParaAtivo(true)
                .ParaTexto(rtfTexto.Text)
                .ParaUsuario(fmrLogin.usuarioLogado);

            if (chkAdicionarPrazo.Checked)
            {
                construtorConteudo
                    .ParaDataFim(dtpFim.Value)
                    .ParaDataInicio(dtpInicio.Value);
            }
            else
            {
                construtorConteudo
                    .ParaDataFim(null)
                    .ParaDataInicio(null);
            }
            conteudoCriado = construtorConteudo.Constroi();

            conteudoDAO.Adicionar(conteudoCriado);

            return conteudoCriado;
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            rtfTexto.Clear();
            cboTema.Text = "";
            lstAnexosAdicionados.Items.Clear();
        }

        private void CheckarCamposPreenchidos()
        {
            if (txtNome.Text == "" ||
               rtfTexto.Text == "" ||
               cboTema.Text == "") throw new ArgumentNullException("","Preencha Todos os campos obrigatórios");
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            openFileDialog2.Reset();
            openFileDialog2.Filter = "Images(*.JPG;*PNG;*.IMG)|*.JPG;*PNG;*.IMG";
            openFileDialog2.ShowDialog();
            openFileDialog2.OpenFile();
            lstAnexosAdicionados.Items.Add(Path.GetFileName(openFileDialog2.FileName.ToString()));
        }

        private void btnApagarAnexos_Click(object sender, EventArgs e)
        {
            openFileDialog1.Reset();
            openFileDialog2.Reset();
            lstAnexosAdicionados.DataSource = null;
            lstAnexosAdicionados.Items.Clear();
        }

        private void btnArquivos_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Anexos(*.docx;*.ppt;*.doc;*.xls;*.pdf,*.txt;)|*.docx;*.ppt;*.doc;*.xls;*.pdf,*.txt";
            openFileDialog1.Multiselect = true;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lstAnexosAdicionados.DataSource = null;
                lstAnexosAdicionados.Items.Clear();
                openFileDialog1.OpenFile();
                string[] anexos = openFileDialog1.FileNames;
                foreach (string y in anexos)
                {
                    lstAnexosAdicionados.Items.Add(Path.GetFileName(openFileDialog2.FileName.ToString()));
                    lstAnexosAdicionados.Items.Add(Path.GetFileName(y));
                }
            }
        }
    }
}
