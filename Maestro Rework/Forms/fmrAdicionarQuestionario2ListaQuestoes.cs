using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maestro_Rework.Classes.Construtores;
using System.Windows.Forms;
using Maestro_Rework.Classes;
using System.Reflection;
using System.IO;
using Maestro_Rework.DAO;
using Maestro_Rework.Classes.Entidades;

namespace Maestro_Rework.Forms
{
    public partial class fmrAdicionarQuestionario2ListaQuestoes : Form
    {
        QuestionarioConstrutor questionarioConstrutor;

        public static List<Questao> questoes = new List<Questao>();

        public fmrAdicionarQuestionario2ListaQuestoes(QuestionarioConstrutor questionarioConstrutor)
        {
            this.questionarioConstrutor = questionarioConstrutor;
       
            InitializeComponent();
            if (dtgQuestoes.Rows.Count < 1)
            {
                lblCliqueAdicionar.Visible = true;
            }
            else
                lblCliqueAdicionar.Visible = false;
            FormatarDatagrid();
            PreencherDataGrid();

            FormBorderStyle = FormBorderStyle.None;
        }


        private void PreencherDataGrid()
        {
            foreach (var questao in questoes)
            {
                dtgQuestoes.Rows.Add(questao);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var show = new fmrAdicionarQuestionario1Titulo(questionarioConstrutor);
            show.MdiParent = ActiveForm;
            show.Dock = DockStyle.Fill;
            show.Show();
            Close();
        }

        private Questionario AdicionarQuestionario()
        {
            var questionarioDAO = new QuestionarioDAO();

            var questionario = this.questionarioConstrutor
                .ParaQuestoes(questoes)
                .ParaUsuario(fmrLogin.usuarioLogado)
                .Constroi();
            questionarioDAO.Adicionar(questionario);
            return questionario;
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            var questionarioAdicionado = AdicionarQuestionario();
            
            var show = new fmrAdicionarAtividadeCodigo(questionarioAdicionado.CodigoAcesso,this);
            show.MdiParent = ActiveForm;
            show.Dock = DockStyle.Fill;
            show.Show();
            Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            CarregarFormAdicionarQuestao();
        }

        private void CarregarFormAdicionarQuestao()
        {
            var show = new fmrAdicionarQuestionario3AdicionarQuestao(questionarioConstrutor);
            show.MdiParent = ActiveForm;
            show.Dock = DockStyle.Fill;
            show.Show();
            Close();
        }

        private void FormatarDatagrid()
        {
            DataGridViewButtonColumn botaoExcluir = new DataGridViewButtonColumn();
            botaoExcluir.Width = 100;
            DataGridViewButtonColumn botaoAlterar = new DataGridViewButtonColumn();
            botaoAlterar.Width = 100;
            DataGridViewTextBoxColumn dtgNomeQuestao = new DataGridViewTextBoxColumn();

            dtgNomeQuestao.Width = dtgQuestoes.Width - (botaoAlterar.Width + botaoExcluir.Width) - 20;
            dtgQuestoes.ScrollBars = ScrollBars.Vertical;
            dtgQuestoes.AllowUserToAddRows = false;
            dtgQuestoes.AllowUserToResizeRows = false;
            dtgQuestoes.AllowUserToResizeColumns = false;
            dtgQuestoes.RowHeadersVisible = false;

            dtgQuestoes.Columns.Add(dtgNomeQuestao);
            dtgQuestoes.Columns.Add(botaoExcluir);
            dtgQuestoes.Columns.Add(botaoAlterar);

            dtgQuestoes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            string imgEditar = "Maestro_Rework.Imagens.editar.ico";
            string imgExcluir = "Maestro_Rework.Imagens.deletar.ico";

            bool ehBotaoEditar = e.ColumnIndex == 1 && e.RowIndex >= 0;
            bool ehBotaoExcluir = e.ColumnIndex == 2 && e.RowIndex >= 0;

            if (ehBotaoEditar)
            {
                DesenharIconeNoBotao(e, imgEditar);
            }
            
            if (ehBotaoExcluir)
            {
                DesenharIconeNoBotao(e, imgExcluir);
            }
        }

        private static void DesenharIconeNoBotao(DataGridViewCellPaintingEventArgs e, string caminhoImagem)
        {
            e.Paint(e.CellBounds, DataGridViewPaintParts.All);

            using (Stream imageStream = GetImagem(caminhoImagem))
            {

                Icon ico = new Icon(imageStream, 10, 10);
                int x = (e.CellBounds.X + (e.CellBounds.Width / 2)) - 10;
                int y = (e.CellBounds.Y + (e.CellBounds.Height / 2)) - 10;
                e.Graphics.DrawIcon(ico, x, y);
                e.Handled = true;
            }
        }

        private static Stream GetImagem(string caminhoImagem)
        {
            Assembly assembly;
            Stream imageStream;

            assembly = Assembly.GetExecutingAssembly();
            imageStream = assembly.GetManifestResourceStream(caminhoImagem);
            return imageStream;
        }

        void grd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool ehBotaoEditar = e.ColumnIndex == 1 && e.RowIndex >= 0;
            bool ehBotaoExcluir = e.ColumnIndex == 2 && e.RowIndex >= 0;

            string nomeDaPergunta = GetNomeDaPerguntaDaCell(e);

            if (ehBotaoEditar)
            {
                var questaoSelecionada = questoes.FirstOrDefault(x => x.Pergunta == nomeDaPergunta);

                var show = new fmrAdicionarQuestionario3AdicionarQuestao(questionarioConstrutor, questaoSelecionada);
                show.MdiParent = ActiveForm;
                show.Dock = DockStyle.Fill;
                show.Show();
                Close();
            }
            if (ehBotaoExcluir)
            {
                RemoverQuestao(e, nomeDaPergunta);
            }
        }

        private string GetNomeDaPerguntaDaCell(DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > 0)
                return dtgQuestoes.Rows[e.RowIndex].Cells[0].Value.ToString();
            else
                return "";
        }

        private void RemoverQuestao(DataGridViewCellEventArgs e, string nomeDaPergunta)
        {
            if (MessageBox.Show("Deseja Mesmo Remover?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                dtgQuestoes.Rows.RemoveAt(e.RowIndex);
            questoes.RemoveAll(x => x.Pergunta == nomeDaPergunta);
        }

        private void lblCliqueAdicionar_Click(object sender, EventArgs e)
        {
            CarregarFormAdicionarQuestao();
        }
    }
}
