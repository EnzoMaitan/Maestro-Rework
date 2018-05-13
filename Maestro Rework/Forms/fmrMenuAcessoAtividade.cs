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
    public partial class fmrMenuAcessoAtividade : Form
    {
        TipoDeAtividade atividade;

        public fmrMenuAcessoAtividade(TipoDeAtividade tipoDeAtividade)
        {
            this.atividade = tipoDeAtividade;
            InitializeComponent();
            AlterarTextoDaTextBox(tipoDeAtividade);
            FormBorderStyle = FormBorderStyle.None;
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {

        }

        private void AlterarTextoDaTextBox(TipoDeAtividade tipoDeAtividade)
        {
            if (tipoDeAtividade == TipoDeAtividade.Conteudo)
            {
                lblAtividadesDesponiveis.Text = "Conteudo";
            }
            else if (tipoDeAtividade == TipoDeAtividade.Questionario)
            {
                lblAtividadesDesponiveis.Text = "Questionario";
            }
        }
    }
}
