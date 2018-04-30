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
    public partial class fmrRecuperarSenha2 : Form
    {
        public fmrRecuperarSenha2()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            fmrLogin formLogin = (fmrLogin)ActiveForm;
            formLogin.MostrarElementosDoFormLogin();
            Close();
        }

        private void lblAlterarSenha_Click(object sender, EventArgs e)
        {

        }
    }
}
