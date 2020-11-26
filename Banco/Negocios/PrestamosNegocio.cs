using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;


namespace Negocios
{
    public class PrestamosNegocio
    {
        List<TipoPrestamos> _lstTipoPrestamos;
        List<Prestamos> _lstPrestamos;
        public PrestamosNegocio()
        {
            _lstTipoPrestamos = new List<TipoPrestamos>();
            _lstPrestamos = new List<Prestamos>();
            RecargarListas();
        }
        private void RecargarListas()
        {
            _lstTipoPrestamos = LineaPrestamosMapper.GetLineaPrestamos();
            _lstPrestamos = PrestamosMapper.GetPrestamos();
        }
        public List<TipoPrestamos> TraerTipoPrestamos()
        {
            return _lstTipoPrestamos;
        }
        public List<Prestamos> TraerPrestamos()
        {
            return _lstPrestamos;
        }
        public int IngresarPrestamo(Prestamos prestamo)
        {
            string validacion = Reglas(prestamo);
            if (!string.IsNullOrEmpty(validacion))
            {
                throw new PrestamosException(validacion);
            }
            else
            {
                TransactionResult resultado = PrestamosMapper.Insert(prestamo);
                if (resultado.IsOk)
                {
                    RecargarListas();
                    return resultado.Id;
                }
                else
                {
                    throw new PrestamosException(resultado.Error);
                }
            }
        }
        private string Reglas(Prestamos prestamo)
        {
            string mensaje = "";



            return mensaje;
        }
    }
}
