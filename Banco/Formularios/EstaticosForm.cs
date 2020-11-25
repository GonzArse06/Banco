using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Formularios
{
    public class EstaticosForm
    {
        public static void LimpiarTextBox(ControlCollection control)
        {
            foreach (Control a in control)
            {
                if (a is TextBox)
                    a.Text = string.Empty;
            }
        }
    }
}
