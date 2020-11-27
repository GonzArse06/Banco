using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocios
{
    public class ClienteNegocios
    {
        private List<Cliente> _lstClientes;
        public ClienteNegocios()
        {
            _lstClientes = new List<Cliente>();
            RecargarListCliente();
        }
        public int IngresarCliente(Cliente cliente)
        {
            string reglas = ReglasClientes(cliente);
            if (!string.IsNullOrEmpty(reglas))
            {
                throw new ClienteException(reglas);
            }
            else
            { 
                TransactionResult resultado = ClienteMapper.InsertGeneric(cliente);
                if (resultado.IsOk)
                {
                    RecargarListCliente();
                    return resultado.Id;
                }
                else
                {
                    throw new ClienteException("Error " + resultado.Error);
                }
            }
        }
        private void RecargarListCliente()
        {
            _lstClientes = ClienteMapper.TraerTodoClientesGeneric();
        }
        public List<Cliente> TraerTodoClientes()
        {
            return _lstClientes;
        }
        public int ModificarCliente(Cliente cliente)
        {
            string reglas = ReglasClientes(cliente);
            if (!string.IsNullOrEmpty(reglas))
            {
                throw new ClienteException(reglas);
            }
            else
            {
                TransactionResult resultado = ClienteMapper.Update(cliente);
                if (resultado.IsOk)
                {
                    RecargarListCliente();
                    return resultado.Id;
                }
                else
                {
                    throw new ClienteException(resultado.Error);
                }
            }
        }
        public bool EliminarCliente(int id)
        {
            Cliente cliente = _lstClientes.SingleOrDefault(x => x.Id == id);
            if (cliente == null)
            { 
                throw new ClienteException("El cliente no existe");
            }

            TransactionResult resultado = ClienteMapper.Delete(id);
            if (resultado.IsOk)
            {
                RecargarListCliente();
                return true;
            }
            else
            {
                throw new ClienteException(resultado.Error);
            }

        }

        private string ReglasClientes(Cliente cliente)
        {
            string resultado = "";
            if (cliente.Edad < 18)
                resultado += "El cliente debe tener mas de 18 años\n";

            if (_lstClientes.Any(x => x.Dni == cliente.Dni))
                resultado += "El Cliente ya existe\n";

            return resultado;
        }
    }
}
