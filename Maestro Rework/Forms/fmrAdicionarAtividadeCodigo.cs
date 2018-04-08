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
    public partial class fmrAdicionarAtividadeCodigo : Form
    {
        public fmrAdicionarAtividadeCodigo(string codigoAcesso, object tipoDeAtividade)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            lblCodigo.Text = codigoAcesso;
            MostrarTipoDeAtividade(tipoDeAtividade);
        }

        private void MostrarTipoDeAtividade(object tipoDeAtividade)
        {
            if (tipoDeAtividade is fmrAdicionarConteudo3Anexos)
            {
                lblAtividadeAdicionada.Text = "Conteúdo adicionado!";
            }
            if (tipoDeAtividade is fmrAdicionarQuestionario3AdicionarQuestao)
            {
                lblAtividadeAdicionada.Text = "Questionario adicionado!";
            }
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
