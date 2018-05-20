using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maestro_Rework.Forms
{
    public static class MostrarErro
    {
        public static void DeixarLabelVisivelMostrarErro(Label lblErro, Exception ex)
        {
            lblErro.Visible = true;
            lblErro.Text = ex.Message;
        }
        public static void DeixarLabelVisivelMostrarErro(Label lblErro, string mensagem)
        {
            lblErro.Visible = true;
            lblErro.Text = mensagem;
        }
    }
}
