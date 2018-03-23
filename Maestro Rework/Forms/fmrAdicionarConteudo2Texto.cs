using Maestro_Rework.Classes.Construtores;
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
    public partial class fmrAdicionarConteudo2Texto : Form
    {
        private AnexoConteudoConstrutor anexoConteudoConstrutor;
        private ConteudoConstrutor conteudoConstrutor;

        public fmrAdicionarConteudo2Texto(ConteudoConstrutor conteudoConstrutor, AnexoConteudoConstrutor anexoConteudoConstrutor)
        {
            this.conteudoConstrutor = conteudoConstrutor;
            this.anexoConteudoConstrutor = anexoConteudoConstrutor;
            InitializeComponent();

            rtfTextoConteudo.Text = conteudoConstrutor.Texto;

            FormBorderStyle = FormBorderStyle.None;
        }
        private void btnAvancar_Click(object sender, EventArgs e)
        {
            conteudoConstrutor.ParaTexto(rtfTextoConteudo.Text);

            var show = new fmrAdicionarConteudo3Anexos(conteudoConstrutor, anexoConteudoConstrutor);
            show.MdiParent = ActiveForm;
            show.Dock = DockStyle.Fill;
            show.Show();
            Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var show = new fmrAdicionarConteudo1Titulo(conteudoConstrutor, anexoConteudoConstrutor);
            show.MdiParent = ActiveForm;
            show.Dock = DockStyle.Fill;
            show.Show();
            Close();
        }
    }
}
