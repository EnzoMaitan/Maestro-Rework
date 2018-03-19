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
        //TODO - arrumar o nome salvo do arquivo no banco
        private byte[] imagemDeCapa;
        private string tituloDoConteudo;
        private string nomeDaImagemCapa;
        private string texto;
        private string codigoDeAcesso;
        private string temaDoConteudo;

        public fmrAdicionarConteudo3Anexos(string tituloDoConteudo,byte[] imagemDeCapa,string nomeDaImagemCapa, string texto, string temaDoConteudo)
        {
            this.tituloDoConteudo = tituloDoConteudo;
            this.imagemDeCapa = imagemDeCapa;
            this.nomeDaImagemCapa = nomeDaImagemCapa;
            this.texto = texto;
            this.temaDoConteudo = temaDoConteudo;

            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            Conteudo conteudo;
            try
            {
                conteudo = AdicionarConteudo();

                AdicionarAnexos(conteudo);
                AdicionarImagemDeCapa(conteudo);

                codigoDeAcesso = conteudo.CodigoAcesso;

                var show = new fmrAdicionarConteudo3(codigoDeAcesso);
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
            var show = new fmrAdicionarConteudo2Texto(tituloDoConteudo, imagemDeCapa, nomeDaImagemCapa,temaDoConteudo, texto);
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
            var construtorConteudo = new ConteudoConstrutor();
            var conteudoDAO = new ConteudoDAO();
            construtorConteudo.ParaNome(tituloDoConteudo)
                .ParaTema(temaDoConteudo)
                .ParaAtivo(true)
                .ParaTexto(tituloDoConteudo)
                .ParaUsuario(fmrLogin.usuarioLogado);

            var conteudoCriado = construtorConteudo.Constroi();

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
                (ofdArquivosAnexo.FileName.Length > 0);

            if (possuiArquivoAdicionado)
            {
                var addAnexo = new ConversorDeAnexos();
                AdicionarArquivos(conteudoCriado, addAnexo);
            }
        }

        private void AdicionarImagemDeCapa(Conteudo conteudoCriado)
        {
            var anexoConteudoDAO = new AnexoConteudoDAO();
            var anexoConstrutor = new AnexoConteudoConstrutor();

            var anexoImagem = anexoConstrutor.ParaConteudo(conteudoCriado)
                    .ParaImagem(imagemDeCapa)
                    .ParaAnexo(null)
                    .ParaNome(nomeDaImagemCapa)
                    .Constroi();

            anexoConteudoDAO.Adicionar(anexoImagem);
        }

        private void AdicionarArquivos(Conteudo conteudoCriado, ConversorDeAnexos addAnexo)
        {
            var anexoConteudoDAO = new AnexoConteudoDAO();

            string[] anexoArquivos = ofdArquivosAnexo.FileNames;

            foreach (var arquivosSelecionado in anexoArquivos)
            {
                var anexos = new AnexoConteudoConstrutor();

                string nome = ofdArquivosAnexo.SafeFileName;

                var arquivo = anexos.ParaConteudo(conteudoCriado)
                    .ParaImagem(null)
                    .ParaNome(nome)
                    .ParaAnexo(addAnexo.DatabaseFilePut(arquivosSelecionado))
                    .Constroi();

                anexoConteudoDAO.Adicionar(arquivo);
            }
        }
    }
}
