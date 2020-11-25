using Entidades;
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

namespace Formularios
{
    public partial class FrmClienteABM : Form
    {
        private Cliente _cliente;
        private ClienteNegocios _clienteNegocios;
        private List<Cliente> _lstClientes;
        public FrmClienteABM()
        {
            InitializeComponent();
            _clienteNegocios = new ClienteNegocios();
            _lstClientes = new List<Cliente>();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!rbAlta.Checked && !rbModificacion.Checked && !rbBaja.Checked)
            {
                MessageBox.Show("Debe elegir una opcion del ABM de clientes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Validaciones();
                    if (rbAlta.Checked)
                    {
                        //Validaciones();
                        _cliente = new Cliente(int.Parse(txtDni.Text), txtNombre.Text, txtApellido.Text, txtDireccion.Text, int.Parse(txtTelefono.Text), txtEmail.Text, dtFechaNacimiento.Value);
                        int resultado = _clienteNegocios.IngresarCliente(_cliente);
                        MessageBox.Show("Cliente ingresado con exito. ID:" + resultado);                    
                    }
                    if (rbModificacion.Checked)
                    {
                        //Validaciones();
                        _cliente = new Cliente(int.Parse(txtDni.Text), txtNombre.Text, txtApellido.Text, txtDireccion.Text, int.Parse(txtTelefono.Text), txtEmail.Text, dtFechaNacimiento.Value);
                        int resultado = _clienteNegocios.ModificarCliente(_cliente);
                        MessageBox.Show("Cliente se modifico con exito. ID:" + resultado);
                    }
                    if (rbBaja.Checked)
                    {
                       //Validaciones();
                        bool resultado = _clienteNegocios.EliminarCliente(int.Parse(txtIdCliente.Text));
                        if (resultado)
                            MessageBox.Show("El cliente se elimino con exito.");
                    }
                    LimpiarControles();
                    RecargarListBox();
                }
                catch (ClienteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
        private void LimpiarControles()
        {
            EstaticosForm.LimpiarTextBox(Controls);
        }
        private void Validaciones()
        {
            string validoVacios = ValidacionesForm.CamposVacios(Controls);
            if (!string.IsNullOrEmpty(validoVacios))
            {
                throw new ClienteException(validoVacios);
            }
            else if (!ValidacionesForm.IsValidEmail(txtEmail.Text))
            {
                throw new ClienteException("Mail Invalido.");
            }
        }

        private void rbAlta_CheckedChanged(object sender, EventArgs e)
        {
            txtIdCliente.Enabled = false;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
            txtDni.Enabled = true;
        }

        private void rbBaja_CheckedChanged(object sender, EventArgs e)
        {
            txtIdCliente.Enabled = true;
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            txtEmail.Enabled = false;
            txtDni.Enabled = false;
        }

        private void rbModificacion_CheckedChanged(object sender, EventArgs e)
        {
            txtIdCliente.Enabled = true;
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
            txtDni.Enabled = true;
        }

        private void FrmClienteABM_Load(object sender, EventArgs e)
        {
            RecargarListBox();            
        }
        private void RecargarListBox()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = _clienteNegocios.TraerTodoClientes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = (Cliente)listBox1.SelectedItem;
                txtIdCliente.Text = cliente.Id.ToString();
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtDireccion.Text = cliente.Direccion;
                txtTelefono.Text = cliente.Telefono;
                txtEmail.Text = cliente.Email;
                txtDni.Text = cliente.Dni.ToString();
                dtFechaNacimiento.Value = cliente.FechaNacimiento;
            }
            catch (Exception ex)
            {
                throw new ClienteException("Cliente con datos basura.");
            }
        }
    }
}
