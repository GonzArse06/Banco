using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Entidades;

namespace Formularios
{
    public partial class FrmPrestamos : Form
    {
        private PrestamosNegocio _prestamosNegocio;
        private TipoPrestamos _tipo;
        private Operador _operador;
        private List<Prestamos> _lstPrestamos;
        public FrmPrestamos()
        {
            InitializeComponent();
            _prestamosNegocio = new PrestamosNegocio();
            _tipo = new TipoPrestamos();
            _lstPrestamos = new List<Prestamos>();
        }

        private void FrmPrestamos_Load(object sender, EventArgs e)
        {
            RecargarListBox();
            txtMonto.Enabled = false;
            txtPlazo.Enabled = false;
        }
        private void RecargarListBox()
        {
            _lstPrestamos = _prestamosNegocio.TraerPrestamos();
            lstPrestamos.DataSource = null;
            lstPrestamos.DataSource = _lstPrestamos;
            lstTipoPrestamos.DataSource = null;
            lstTipoPrestamos.DataSource = _prestamosNegocio.TraerTipoPrestamos();

            _operador = new Operador(_lstPrestamos);
            if (_operador != null)
            {
                textBox1.Text = string.Format("{0:c}", _operador.Comision);//_operador.Comision.ToString();
            }
        }

        private void lstTipoPrestamos_SelectedIndexChanged(object sender, EventArgs e)
        {
            _tipo = (TipoPrestamos)lstTipoPrestamos.SelectedItem;
            if (_tipo != null)
            {
                txtLinea.Text = _tipo.Linea;
                txtTna.Text = _tipo.TNA.ToString();

                txtMonto.Enabled = true;
                txtPlazo.Enabled = true;
            }
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            GestionPrestamos(sender);
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            GestionPrestamos(sender);
        }

        private void GestionPrestamos(object sender)
        {
            string validacion = ValidacionesForm.CamposVacios(gbTipoPrestamos.Controls);
            if (!string.IsNullOrEmpty(validacion))
            {
                MessageBox.Show(validacion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (_tipo != null)
                    {
                        Prestamos prestamos = new Prestamos(_tipo, int.Parse(txtPlazo.Text), double.Parse(txtMonto.Text),int.Parse(txtIdCliente.Text));
                        txtCuotaCapital.Text = prestamos.CuotaCapital.ToString("#.##");
                        txtCuotaInteres.Text = prestamos.CuotaInteres.ToString("#.##");
                        txtCuotaTotal.Text = prestamos.Cuota.ToString("#.##");

                        if (((ButtonBase)sender).Text == "ALTA")
                        {
                            if (MessageBox.Show("Confirma el ingreso del prestamos?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                            {
                                int resultado = _prestamosNegocio.IngresarPrestamo(prestamos);
                                MessageBox.Show("El prestamo se ingreso con exito. Id " + resultado);
                                RecargarListBox();
                            }
                        }
                    }
                }
                catch (PrestamosException ex)
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
