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
    public class TarjetaCreditoMapper
    {
        public static List<TarjetaCredito> TraerTodoTarjetaCredito()
        {
            string json = webHelper.Get("/tarjetacredito/"+ ConfigurationManager.AppSettings["Legajo"]);
            List<TarjetaCredito> resultado = JsonConvert.DeserializeObject<List<TarjetaCredito>>(json);
            return resultado;
        }
        public static TransactionResult Insert(TarjetaCredito tarjeta)
        {
            NameValueCollection obj = ReverseMap(tarjeta);
            string result = webHelper.Post("/tarjetacredito/", obj);
            TransactionResult resultadoTransaccion = webHelper.MapResultado(result);
            return resultadoTransaccion;
        }
        public static TransactionResult Update(TarjetaCredito tarjeta)
        {
            NameValueCollection obj = ReverseMap(tarjeta);
            string result = webHelper.Post("/tarjetacredito/", obj);
            TransactionResult resultadoTransaccion = webHelper.MapResultado(result);
            return resultadoTransaccion;
        }
        public static TransactionResult Delete(int id)
        {
            NameValueCollection obj = new NameValueCollection();
            obj.Add("Id", id.ToString());
            string result = webHelper.Delete("/tarjetacredito/", obj);
            TransactionResult resultadoTransaccion = webHelper.MapResultado(result);
            return resultadoTransaccion;
        }
        private static NameValueCollection ReverseMap(TarjetaCredito tarjeta)
        {
            NameValueCollection a = new NameValueCollection();
            a.Add("Tipo", tarjeta.Tipo.ToString());
            a.Add("PeriodoVencimiento", tarjeta.PeriodoVencimiento.ToString());
            a.Add("LimiteCompra", tarjeta.LimiteCompra.ToString());
            a.Add("NroPlastico", tarjeta.NroPlastico);
            a.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
            a.Add("IdCliente", tarjeta.IdCliente.ToString());
            return a;
        }
    }
}
