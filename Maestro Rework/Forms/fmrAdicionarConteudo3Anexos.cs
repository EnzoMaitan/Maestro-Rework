using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maestro_Rework.Classes;
using Maestro_Rework.Classes.Construtores;
using Maestro_Rework.DAO;

namespace Maestro_Rework.Forms
{
    public partial class fmrAdicionarConteudo3Anexos : Form
    {
        private ConteudoConstrutor conteudoConstrutor;
        private AnexoConteudoConstrutor anexoConteudoConstrutor;

        public fmrAdicionarConteudo3Anexos(ConteudoConstrutor conteudoConstrutor, AnexoConteudoConstrutor anexoConteudoConstrutor)
        {
            this.conteudoConstrutor = conteudoConstrutor;
            this.anexoConteudoConstrutor = anexoConteudoConstrutor;

            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            try
            {
                var conteudo = AdicionarConteudo();
                
                AdicionarAnexos(conteudo);

                AdicionarImagemDeCapa(conteudo);
                
                var show = new fmrAdicionarAtividadeCodigo(conteudo.CodigoAcesso, this);
                show.MdiParent = ActiveForm;
                show.Dock = DockStyle.Fill;
                show.Show();
                Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var show = new fmrAdicionarConteudo2Texto(conteudoConstrutor, anexoConteudoConstrutor);
            show.MdiParent = ActiveForm;
            show.Dock = DockStyle.Fill;
            show.Show();
            Close();
        }

        private void btnAdicionarAnexos_Click(object sender, EventArgs e)
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
                    lstAnexoAdicionados.Items.Add(Path.GetFileName(arquivo));
                }
            }
        }

        private Conteudo AdicionarConteudo()
        {
            var conteudoDAO = new ConteudoDAO();

            conteudoConstrutor
                .ParaUsuario(fmrLogin.usuarioLogado);

            var conteudoCriado = conteudoConstrutor.Constroi();

            conteudoDAO.Adicionar(conteudoCriado);

            return conteudoCriado;
        }

        private void ConfigurarFileDialogs()
        {
            ofdArquivosAnexo.Filter = "Anexos(*.docx;*.ppt;*.doc;*.xls;*.pdf,*.txt;)|*.docx;*.ppt;*.doc;*.xls;*.pdf,*.txt";
            ofdArquivosAnexo.Multiselect = true;
            ofdArquivosAnexo.RestoreDirectory = true;
        }

        private void AdicionarAnexos(Conteudo conteudoCriado)
        {
            bool possuiArquivoAdicionado =
                (ofdArquivosAnexo.FileNames != null);

            if (possuiArquivoAdicionado)
            {
                var addAnexo = new ConversorDeAnexos();
                AdicionarArquivos(conteudoCriado, addAnexo);
            }
        }

        private void AdicionarImagemDeCapa(Conteudo conteudoCriado)
        {
            if (anexoConteudoConstrutor.Imagem != null)
            {
                var anexoConteudoDAO = new AnexoConteudoDAO();
                var anexoConstrutor = new AnexoConteudoConstrutor();

                var anexoImagem = anexoConstrutor.ParaConteudo(conteudoCriado)
                        .ParaImagem(anexoConteudoConstrutor.Imagem)
                        .ParaAnexo(null)
                        .ParaNome(anexoConteudoConstrutor.Nome)
                        .Constroi();

                anexoConteudoDAO.Adicionar(anexoImagem);
            }
        }

        private void AdicionarArquivos(Conteudo conteudoCriado, ConversorDeAnexos addAnexo)
        {
            var anexoConteudoDAO = new AnexoConteudoDAO();

            string[] anexoArquivos = ofdArquivosAnexo.FileNames;

            foreach (var arquivosSelecionado in anexoArquivos)
            {
                var anexos = new AnexoConteudoConstrutor();

                var arquivo = anexos.ParaConteudo(conteudoCriado)
                    .ParaImagem(null)
                    .ParaNome(Path.GetFileNameWithoutExtension(arquivosSelecionado))
                    .ParaAnexo(addAnexo.DatabaseFilePut(arquivosSelecionado))
                    .Constroi();

                anexoConteudoDAO.Adicionar(arquivo);
            }
        }
    }
}
