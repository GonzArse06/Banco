using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Newtonsoft.Json;

namespace Datos
{
    public class PrestamosMapper
    {
        public static List<Prestamos> GetPrestamos()
        {
            string json = webHelper.Get("/prestamo/" + ConfigurationManager.AppSettings["Legajo"]);
            return JsonConvert.DeserializeObject<List<Prestamos>>(json);
        }
        public static TransactionResult Insert(Prestamos prestamos)
        {
            NameValueCollection obj = ReverseMap(prestamos);
            string json = webHelper.Post("/prestamo/", obj);
            TransactionResult resultado = webHelper.MapResultado(json);
            return resultado;
        }
        private static NameValueCollection ReverseMap(Prestamos prestamos)
        {
            NameValueCollection a = new NameValueCollection();
            a.Add("TNA", prestamos.TipoPrestamos.TNA.ToString());
            a.Add("Linea", prestamos.TipoPrestamos.Linea);
            a.Add("Plazo", prestamos.Plazo.ToString());
            a.Add("IdCliente", prestamos.IdCliente.ToString());
            a.Add("Monto", prestamos.Monto.ToString("#.##")); //habia un error con los decimales.
            a.Add("Cuota", prestamos.Cuota.ToString("#.##"));
            a.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
            return a;
        }
    }
}
