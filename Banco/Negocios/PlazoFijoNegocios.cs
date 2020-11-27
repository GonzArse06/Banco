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
    public class PlazoFijoNegocios
    {
        private List<PlazoFijo> _lstPlazoFijo;
         
        public PlazoFijoNegocios()
        {
            _lstPlazoFijo = new List<PlazoFijo>();
            RecargarLista();
        }
        private void RecargarLista()
        {
            _lstPlazoFijo = PlazoFijoMapper.TraerPlazoFijos();
        }
        public List<PlazoFijo> TraerPlazoFijos()
        {
            return _lstPlazoFijo;
        }
        public int Insert(PlazoFijo plazoFijo)
        {
            string reglas = Reglas(plazoFijo);
            if (!string.IsNullOrEmpty(reglas))
            {
                throw new PlazoFijoException(reglas);
            }
            else 
            {
                TransactionResult resultado = PlazoFijoMapper.Insert(plazoFijo);
                if (resultado.IsOk)
                {
                    RecargarLista();
                    return resultado.Id;
                }
                else
                {
                    throw new PlazoFijoException(resultado.Error);
                }

            }
        
        }
        private string Reglas(PlazoFijo plazofijo)
        {
            string mensaje = "";
            int minimoDias = int.Parse(ConfigurationManager.AppSettings["MinimoPlazoFijoDias"]);
            double minimoSaldo = double.Parse(ConfigurationManager.AppSettings["MinimoSaldo"]);

            if (plazofijo.Dias < minimoDias)
                mensaje +="La cantidad de dias debe superar el minimo de dias. "+ minimoDias + "\n";
            if(plazofijo.CapitalInicial < minimoSaldo)
                mensaje += "El capital debe ser mayor a " + minimoSaldo + ".\n";

            return mensaje;
        }

    }
}
