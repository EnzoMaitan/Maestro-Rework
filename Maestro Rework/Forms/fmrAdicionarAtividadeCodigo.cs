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
    public partial class fmrAdicionarConteudo3 : Form
    {
        public fmrAdicionarConteudo3(string codigoAcesso)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            lblCodigo.Text = codigoAcesso;
        }

        private void btnConcluir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
