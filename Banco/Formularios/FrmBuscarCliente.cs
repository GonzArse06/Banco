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
    public partial class FrmBuscarCliente : Form
    {
        private ClienteNegocios _clienteNegocios;
        public FrmBuscarCliente()
        {
            InitializeComponent();
            _clienteNegocios = new ClienteNegocios();
        }

        private void FrmBuscarCliente_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = _clienteNegocios.TraerTodoClientes();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            Seleccionar();
        }
        private void Seleccionar()
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Tag = (Cliente)listBox1.SelectedItem;
                this.Close();
            }
        }
    }
}
