using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maestro_Rework.Forms
{
    public class AlterarEstiloDoBackground
    {
        public static void CarregarBackGroundColourDoMDIContainer(Form form)
        {
            MdiClient chld;

            foreach (Control ctrl in form.Controls)
            {
                try
                {
                    chld = (MdiClient)ctrl;

                    chld.BackColor = form.BackColor;
                }

                catch (Exception){}
            }
        }
    }
}
