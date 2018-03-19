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
        private string _tipoDeAtividade;
        
        public fmrGerenciarAtividade(string tipoDeAtividade)
        {
            _tipoDeAtividade = tipoDeAtividade;
            FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
        }

        private void fmrGerencia_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionarNovo_Click(object sender, EventArgs e)
        {
            if (_tipoDeAtividade.Equals("CONTEUDO"))
            {
                var show = new fmrAdicionarConteudo1Titulo();
                show.MdiParent = ActiveForm;
                show.Dock = DockStyle.Fill;
                show.Show();
            }
            else if (_tipoDeAtividade == "QUESTIONARIO")
            {
                var show = new fmrAdicionarQuestionario1Titulo();
                show.MdiParent = ActiveForm;
                show.Dock = DockStyle.Fill;
                show.Show();
            }
        }
    }
}
