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
    public partial class fmrResponderQuestionario : Form
    {
        Questionario questionario;
        public fmrResponderQuestionario(Questionario questionario)
        {
            this.questionario = questionario;
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            MessageBox.Show(questionario.Nome);
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {

        }
    }
}
