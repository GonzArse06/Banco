using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Negocios;

namespace Formularios
{
    public partial class FrmTarjetaCredito : Form
    {
        private List<TarjetaCredito> _lstTarjetasCredito;
        private TarjetaCreditoNegocio _tarjetaNegocios;
        public FrmTarjetaCredito()
        {
            InitializeComponent();
            _lstTarjetasCredito = new List<TarjetaCredito>();
            _tarjetaNegocios = new TarjetaCreditoNegocio();
        }

        private void FrmTarjetaCredito_Load(object sender, EventArgs e)
        {
            cbTipo.DataSource = Enum.GetValues(typeof(TipoTarjeta));
            cbPeriodoVencimiento.DataSource = Enum.GetValues(typeof(PeriodoDeCierre));
            RecargarListBox();
        }
        private void RecargarListBox()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = _tarjetaNegocios.TraerTarjetasCredito();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string validaciones = ValidacionesForm.CamposVacios(Controls);
            if (!string.IsNullOrEmpty(validaciones))
            {
                MessageBox.Show(validaciones, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    TarjetaCredito tarjeta = new TarjetaCredito(int.Parse(txtIDCliente.Text), (int)cbTipo.SelectedValue, (int)cbPeriodoVencimiento.SelectedValue, double.Parse(txtLimiteCompra.Text));
                    int resultado = _tarjetaNegocios.IngresarTarjetaCredito(tarjeta);
                    MessageBox.Show("Se registro con exito la nueva tarjeta. ID:" + resultado);
                    RecargarListBox();
                    EstaticosForm.LimpiarTextBox(Controls);
                }
                catch (TarjetaCreditoException ex)
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


    //revisar DropDownList
    //var lstStatus = Enum.GetValues(typeof(TipoTarjeta)).Cast<TipoTarjeta>().ToList().Select(x => new DropDownList
    //{
    //    Text = x.GetDescription(),
    //    Value = x.GetHashCode()
    //})
}
