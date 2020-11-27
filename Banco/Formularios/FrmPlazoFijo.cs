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
    public partial class FrmPlazoFijo : Form
    {
        private PlazoFijoNegocios _plazoFijoNegocios; 
        public FrmPlazoFijo()
        {
            InitializeComponent();
            _plazoFijoNegocios = new PlazoFijoNegocios();
        }
        private void RecargarListBox()
        {
            lstPlazoFijo.DataSource = null;
            lstPlazoFijo.DataSource = _plazoFijoNegocios.TraerPlazoFijos();
        }
        private void FrmPlazoFijo_Load(object sender, EventArgs e)
        {
            RecargarListBox();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string mensaje = ValidacionesForm.CamposVacios(Controls);
            if (!string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    PlazoFijo plazofijo = new PlazoFijo(int.Parse(txtIDCliente.Text), int.Parse(txtTipo.Text), int.Parse(txtDias.Text), double.Parse(txtCapitalInicial.Text), double.Parse(txtTasa.Text));
                    int resultado = _plazoFijoNegocios.Insert(plazofijo);
                    MessageBox.Show("Ingreso exitoso del plazo fijo. ID" + resultado);
                    RecargarListBox();
                }
                catch (PlazoFijoException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmBuscarCliente formulario = new FrmBuscarCliente();
            formulario.Owner = this.Owner;
            formulario.ShowDialog();
            var tag = formulario.Tag;
            if (tag != null && tag is Cliente)
            {
                txtIDCliente.Text = ((Cliente)tag).Id.ToString();
            }
        }

        private void txtCapitalInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            RecargarInteres();
        }

        private void txtTasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            RecargarInteres();
        }
        private void RecargarInteres()
        {
            if (string.IsNullOrEmpty(txtCapitalInicial.Text) || string.IsNullOrEmpty(txtTasa.Text) || string.IsNullOrEmpty(txtDias.Text))
            {
            }
            else
            {
                txtInteres.Text = ( double.Parse(txtCapitalInicial.Text) * (( double.Parse(txtTasa.Text) / 365 / 100) * int.Parse(txtDias.Text))).ToString("{0:c}");
            }
        }
    }
}
