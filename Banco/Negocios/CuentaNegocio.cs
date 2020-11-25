using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocios
{
    public class CuentaNegocio
    {
        private List<Cuenta> _lstCuenta;
        public CuentaNegocio()
        {
            _lstCuenta = new List<Cuenta>();
            RecargarLista();
        }
        private void RecargarLista()
        {
            _lstCuenta = CuentaMapper.TraerTodo();
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
        private string Reglas(Cuenta cuenta)
        {
            string mensaje="";

            return mensaje;
        }

    }
}
