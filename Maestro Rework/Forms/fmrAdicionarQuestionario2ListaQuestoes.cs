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
            //if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            //{
            //    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

            //    string resource = "Maestro_Rework/Imagens/editar.ico";
            //    Stream fontStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource);

            //    Icon ico = new Icon(fontStream, 10, 10);
            //    int x = (e.CellBounds.X + (e.CellBounds.Width / 2)) - 10;
            //    int y = (e.CellBounds.Y + (e.CellBounds.Height / 2)) - 10;
            //    e.Graphics.DrawIcon(ico, x, y);
            //    e.Handled = true;
            //}
            //if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            //{
            //    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

            //    Icon ico = new Icon("Maestro_Rework.Imagens.deletar.ico", 10,10);

            //    int x = (e.CellBounds.X + (e.CellBounds.Width / 2)) - 10;
            //    int y = (e.CellBounds.Y + (e.CellBounds.Height / 2)) - 10;
            //    e.Graphics.DrawIcon(ico, x, y);
            //    e.Handled = true;
            //}
        }
    }
}
