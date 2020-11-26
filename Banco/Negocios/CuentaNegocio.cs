using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
using System.Configuration;

namespace Negocios
{
    public class CuentaNegocio
    {
        private List<Cuenta> _lstCuenta;
        private List<Cliente> _lstCliente;
        public CuentaNegocio()
        {
            _lstCuenta = new List<Cuenta>();
            _lstCliente = new List<Cliente>();
            RecargarLista();
        }
        private void RecargarLista()
        {
            List<Cuenta> lstCuentas = new List<Cuenta>();
            _lstCliente = ClienteMapper.TraerTodoClientes();
            _lstCuenta = CuentaMapper.TraerTodo();
            foreach (Cliente a in _lstCliente)
                lstCuentas.AddRange(_lstCuenta.Where(x => x.IdCliente == a.Id).ToList());

            _lstCuenta = lstCuentas;
        }
        public List<Cuenta> TraerCuentas()
        {
            return _lstCuenta;
        }
        public int IngresarCuenta(Cuenta cuenta)
        {
            string validaciones = Reglas(cuenta);
            if (!string.IsNullOrEmpty(validaciones))
            {
                throw new CuentaException(validaciones);
            }
            else
            {
                TransactionResult resultado = CuentaMapper.Insert(cuenta);
                if (resultado.IsOk)
                {
                    RecargarLista();
                    return resultado.Id;
                }
                else
                {
                    throw new CuentaException(resultado.Error);
                }
            }
        }

        public string ActualizarSaldo(Cuenta cuenta)
        {
            string validaciones = ReglasActualizacion(cuenta);
            if (!string.IsNullOrEmpty(validaciones))
            {
                throw new CuentaException(validaciones);
            }
            else
            {
                TransactionResult resultado = CuentaMapper.Insert(cuenta);
                if (resultado.IsOk)
                {
                    RecargarLista();
                    TransactionResult resultadoMail = EnviarMail(cuenta);
                    return resultado.Id.ToString() + "Envio de mail: "+resultado.IsOk.ToString();
                }
                else
                {
                    throw new CuentaException(resultado.Error);
                }
            }
        }
        private TransactionResult EnviarMail(Cuenta cuenta)
        {
            Cliente cliente = _lstCliente.SingleOrDefault(x => x.Id == cuenta.IdCliente);
            if (cliente != null && cliente.Email != null)
            {
                Utilidades envio = new Utilidades(cliente.Email, "Actualizacion de Saldo", "Nuevo saldo: $" + cuenta.Saldo.ToString("C") + "\nFecha Actualizacion: " + DateTime.Now.ToString());
                TransactionResult resultado = UtilidadesMapper.EnviarMail(envio);
                return resultado;
            }
            else
            {
                return null;
            }
        }
        private string Reglas(Cuenta cuenta)
        {
            string mensaje="";
            if (!_lstCliente.Any(x => x.Id == cuenta.IdCliente))
                mensaje += "No existe el cliente\n";

            return mensaje;
        }
        private string ReglasActualizacion(Cuenta cuenta)
        {
            string mensaje = "";
            if (!_lstCuenta.Any(x => x.Id == cuenta.Id))
                mensaje += "La cuenta no existe\n";

            if (cuenta.Saldo < double.Parse(ConfigurationManager.AppSettings["MinimoSaldo"]))
                mensaje += "El saldo debe ser mayor al minimo ($"+ ConfigurationManager.AppSettings["MinimoSaldo"]+")";

            return mensaje;
        }

    }
}
