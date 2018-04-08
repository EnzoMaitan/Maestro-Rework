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
        public static void DeixarLabelVisivelMostrarErro(Label lblErro, ArgumentException ex)
        {
            lblErro.Visible = true;
            lblErro.Text = ex.Message;
        }
    }
}
