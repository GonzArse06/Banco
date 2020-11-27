using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Newtonsoft.Json;
using System.Collections.Specialized;
using System.Configuration;

namespace Datos
{
    public class PlazoFijoMapper
    {
        public static List<PlazoFijo> TraerPlazoFijos()
        {
            string json = webHelper.Get("/plazofijo/" + ConfigurationManager.AppSettings["Legajo"]);
            return JsonConvert.DeserializeObject<List<PlazoFijo>>(json);
        }
        public static TransactionResult Insert(PlazoFijo plazoFijo)
        {
            NameValueCollection obj = ReverseMap(plazoFijo);
            string json = webHelper.Post("/plazofijo/",obj);
            TransactionResult resultado = webHelper.MapResultado(json);
            return resultado;
        }
        public static NameValueCollection ReverseMap(PlazoFijo plazoFijo)
        {
            NameValueCollection a = new NameValueCollection();
            a.Add("idCliente", plazoFijo.IdCliente.ToString());
            a.Add("id", plazoFijo.Id.ToString());
            a.Add("Tipo", plazoFijo.Tipo.ToString());
            a.Add("Dias", plazoFijo.Dias.ToString());
            a.Add("CapitalInicial", plazoFijo.CapitalInicial.ToString());
            a.Add("Tasa", plazoFijo.Tasa.ToString());
            a.Add("Interes", plazoFijo.Interes.ToString());
            a.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
            return a;
        }
    }
}
