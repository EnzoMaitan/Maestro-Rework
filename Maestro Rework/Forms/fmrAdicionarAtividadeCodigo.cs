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
        public fmrAdicionarAtividadeCodigo(string codigoAcesso, Form formAtividade)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            lblCodigo.Text = codigoAcesso;
            MostrarTipoDeAtividade(formAtividade);
        }

        private void MostrarTipoDeAtividade(Form formAtividade)
        {
            if (formAtividade is fmrAdicionarConteudo3Anexos)
            {
                lblAtividadeAdicionada.Text = "Conteúdo adicionado!";
            }
            else if (formAtividade is fmrAdicionarQuestionario2ListaQuestoes)
            {
                lblAtividadeAdicionada.Text = "Questionário adicionado!";
            }
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
