using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Formularios
{
    public class ValidacionesForm
    {
        public static string CamposVacios(ControlCollection control)
        {
            string mensaje = "";
            foreach (Control a in control)
            {
                if ((a is TextBoxNumeros || a is TextBoxSoloCaracteres || a is TextBox) && a.Enabled == true)
                {
                    if (string.IsNullOrEmpty(a.Text))
                        mensaje += a.Name;
                }
            }
            if (!string.IsNullOrEmpty(mensaje))
                mensaje = "Debe completar los campos vacios \n" + mensaje;

            return mensaje;
        }
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
