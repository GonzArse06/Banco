using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocios;

namespace Formularios
{
    public partial class FrmCuentas : Form
    {
        private CuentaNegocio _cuentaNegocio;
        public FrmCuentas()
        {
            InitializeComponent();
            _cuentaNegocio = new CuentaNegocio();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {

        }

        private void FrmCuentas_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = _cuentaNegocio.TraerCuentas(); //Traer solo cuentas que son de mi legajo
        }
    }
}
