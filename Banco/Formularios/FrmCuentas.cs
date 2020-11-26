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
            string mensaje = ValidacionesForm.CamposVacios(groupBoxAlta.Controls);
            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Cuenta cuenta = new Cuenta(int.Parse(txtIdCliente.Text), txtDescripcion.Text);
                    int resultado = _cuentaNegocio.IngresarCuenta(cuenta);
                    MessageBox.Show("Cuenta ingresada con exito. ID: " + resultado);
                    RecargarListBox();
                }
                catch (CuentaException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmCuentas_Load(object sender, EventArgs e)
        {
            RecargarListBox();
        }
        private void RecargarListBox()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = _cuentaNegocio.TraerCuentas(); //Traer solo cuentas que son de mi legajo
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente formulario = new FrmBuscarCliente();
            formulario.Owner = this;
            formulario.ShowDialog();
            var tag = formulario.Tag;
            if (tag != null && tag is Cliente)
            {
                txtIdCliente.Text = ((Cliente)tag).Id.ToString();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cuenta cuenta = (Cuenta)listBox1.SelectedItem;
            if (cuenta != null)
            { 
                txtIdCuenta.Text = cuenta.Id.ToString();
                txtSaldo.Text = cuenta.Saldo.ToString();
            }
        }

        private void btnActualizarSaldo_Click(object sender, EventArgs e)
        {
            string mensaje = ValidacionesForm.CamposVacios(groupBox1.Controls);
            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Cuenta cuenta = new Cuenta(int.Parse(txtIdCuenta.Text),double.Parse(txtSaldo.Text));
                    string resultado = _cuentaNegocio.ActualizarSaldo(cuenta);
                    MessageBox.Show("Actualizacion de saldo exitosa. id" + resultado);
                    RecargarListBox();
                }
                catch (CuentaException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
