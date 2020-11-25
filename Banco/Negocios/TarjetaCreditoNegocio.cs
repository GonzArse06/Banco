using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocios
{
    public class TarjetaCreditoNegocio
    {
        private List<TarjetaCredito> _lstTarjetaCredito;
        //private List<Cliente> _lstCliente;

        public TarjetaCreditoNegocio()
        {
            _lstTarjetaCredito = new List<TarjetaCredito>();
            //_lstCliente = new List<Cliente>();
            RecargarListaTarjeta();
        }
        private void RecargarListaTarjeta()
        {
            _lstTarjetaCredito = TarjetaCreditoMapper.TraerTodoTarjetaCredito();
        }
        public int IngresarTarjetaCredito(TarjetaCredito tarjeta)
        {
            tarjeta.NroPlastico = GeneradorPlastico(tarjeta.Tipo);

            string reglas = ReglasTarjetaCredito(tarjeta);
            if (!string.IsNullOrEmpty(reglas))
            {
                throw new TarjetaException("Error " + reglas);
            }
            else
            {
                TransactionResult resultado = TarjetaCreditoMapper.Insert(tarjeta);
                if (resultado.IsOk)
                {
                    RecargarListaTarjeta();
                    return resultado.Id;
                }
                else
                {
                    throw new TarjetaException("Error al ingresar tarjeta " + resultado.Error);
                }
            }
        }
        public List<TarjetaCredito> TraerTarjetasCredito()
        {
            return _lstTarjetaCredito;
        }

        //public int ModificarTarjetaCredito(TarjetaCredito tarjeta)
        //{
        //    string reglas = ReglasTarjetaCredito(tarjeta);
        //    if (!string.IsNullOrEmpty(reglas))
        //    { 
        //        throw new TarjetaException("Error " + reglas);
        //    }
        //    else
        //    { 
        //        TransactionResult resultado = TarjetaCreditoMapper.Update(tarjeta);
        //        if (resultado.IsOk)
        //        {
        //            return resultado.Id;
        //        }
        //        else
        //        {
        //            throw new TarjetaException("Error al modificar tarjeta " + resultado.Error);
        //        }
        //    }
        //}
        //public int EliminarTarjetaCredito(int idTarjeta)
        //{
        //    TransactionResult resultado = TarjetaCreditoMapper.Delete(idTarjeta);
        //    if (resultado.IsOk)
        //    {
        //        return resultado.Id;
        //    }
        //    else
        //    {
        //        throw new TarjetaException("Error al eliminar tarjeta " + resultado.Error);
        //    }
        //}
        private string ReglasTarjetaCredito(TarjetaCredito tarjeta)
        {
            string resultado = "";
            if (_lstTarjetaCredito.Any(x => x.NroPlastico == tarjeta.NroPlastico))
                resultado += "La tarjeta ya se encuentra registrada.\n";
            if (!ClienteMapper.TraerTodoClientes().Any(x => x.Id == tarjeta.IdCliente))
                resultado += "El Cliente no existe.\n";

            return resultado;
        }
        private string GeneradorPlastico(int tipo)
        {
            string nroPlastico = "";
            Random numero = new Random();

            switch (tipo)
            {
                case (int)TipoTarjeta.Visa:
                    nroPlastico = numero.Next(4000,4999).ToString();
                    break;
                case (int)TipoTarjeta.Master:
                    nroPlastico = numero.Next(5000, 5999).ToString();
                    break;
                case (int)TipoTarjeta.Amex:
                    nroPlastico = numero.Next(300, 399).ToString();
                    break;
            }
            nroPlastico += numero.Next(1000, 9999).ToString();
            nroPlastico += numero.Next(1000, 9999).ToString();
            nroPlastico += numero.Next(1000, 9999).ToString();

            return nroPlastico;
        }
    }
}
