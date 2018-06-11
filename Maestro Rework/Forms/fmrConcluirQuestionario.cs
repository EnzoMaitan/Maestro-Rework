using Maestro_Rework.Classes;
using Maestro_Rework.Classes.Entidades;
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
    public partial class fmrConcluirQuestionario : Form
    {
        Questionario questionario;

        public fmrConcluirQuestionario(Questionario questionario)
        {
            this.questionario = questionario;
            FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
            MostrarInformacoes();
        }

        private void MostrarInformacoes()
        {
            var RQ = new ResultadoQuestionario(fmrLogin.usuarioLogado, questionario);
            
            lblNota.Text = $"Nota: {RQ.GetNota()}";
            lblAcertos.Text = $"Acertos: {RQ.GetAcertos()}";
            lblTempoGasto.Text = $"Tempo Gasto: ";
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
