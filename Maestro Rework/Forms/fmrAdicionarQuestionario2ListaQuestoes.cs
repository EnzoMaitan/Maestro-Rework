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

namespace Maestro_Rework.Forms
{
    public partial class fmrAdicionarQuestionario2ListaQuestoes : Form
    {
        QuestionarioConstrutor questionarioConstrutor;

        public fmrAdicionarQuestionario2ListaQuestoes(QuestionarioConstrutor questionarioConstrutor)
        {
            this.questionarioConstrutor = questionarioConstrutor;

            InitializeComponent();

            FormatarDatagrid();

            FormBorderStyle = FormBorderStyle.None;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var show = new fmrAdicionarQuestionario1Titulo(questionarioConstrutor);
            show.MdiParent = ActiveForm;
            show.Dock = DockStyle.Fill;
            show.Show();
            Close();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

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

    }
}
