using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maestro_Rework.Classes;

namespace Maestro_Rework.Forms
{
    public partial class fmrRecuperarSenha1 : Form
    {
        public fmrRecuperarSenha1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            var show = new fmrRecuperarSenha2();
            show.MdiParent = ActiveForm;
            show.Dock = DockStyle.Fill;
            show.Show();
            Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            fmrLogin formLogin = (fmrLogin)ActiveForm;
            formLogin.MostrarElementosDoFormLogin();
            Close();
        }

        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            EnviadorDeEmail.Enviar_Rec_Senha(txtEmail.Text);
        }
    }
}
