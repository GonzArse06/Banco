using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmInicio : Form
    {
        private Form _formulario;
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void aBMClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formulario = new FrmClienteABM();
            _formulario.Show();
        }

        private void tarjetasDeCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aBMTarjetaDeCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formulario = new FrmTarjetaCredito();
            _formulario.Show();
        }
    }
}
