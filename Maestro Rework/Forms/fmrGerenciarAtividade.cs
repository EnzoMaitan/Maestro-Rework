using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maestro_Rework.Forms
{
    public partial class fmrGerenciarAtividade : Form
    {
        TipoDeAtividade _tipoDeAtividade;

        public fmrGerenciarAtividade(TipoDeAtividade tipoDeAtividade)
        {
            _tipoDeAtividade = tipoDeAtividade;
            FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            AlterarTextoDaTextBox(tipoDeAtividade);
        }

        private void AlterarTextoDaTextBox(TipoDeAtividade tipoDeAtividade)
        {
            if (tipoDeAtividade == TipoDeAtividade.Conteudo)
            {
                lblTipoDeAtividade.Text = "Conteudo";
            }
            else if (tipoDeAtividade == TipoDeAtividade.Questionario)
            {
                lblTipoDeAtividade.Text = "Questionario";
            }
        }

        private void btnAdicionarNovo_Click(object sender, EventArgs e)
        {
            if (_tipoDeAtividade == TipoDeAtividade.Conteudo)
            {
                var show = new fmrAdicionarConteudo1Titulo();
                show.MdiParent = ActiveForm;
                show.Dock = DockStyle.Fill;
                show.Show();
                Close();
            }
            else if (_tipoDeAtividade == TipoDeAtividade.Questionario)
            {
                fmrAdicionarQuestionario2ListaQuestoes.questoes.Clear();
                var show = new fmrAdicionarQuestionario1Titulo();
                show.MdiParent = ActiveForm;
                show.Dock = DockStyle.Fill;
                show.Show();
            }
        }

        private void btnGerenciar_Click(object sender, EventArgs e)
        {
            if (_tipoDeAtividade == TipoDeAtividade.Conteudo)
            {
            }
            else if (_tipoDeAtividade == TipoDeAtividade.Questionario)
            {
                fmrAdicionarQuestionario2ListaQuestoes.questoes.Clear();
                var show = new fmrGerenciarQuestionario();
                show.MdiParent = ActiveForm;
                show.Dock = DockStyle.Fill;
                show.Show();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
