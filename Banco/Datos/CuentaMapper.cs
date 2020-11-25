using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Newtonsoft.Json;

namespace Datos
{
    public class CuentaMapper//: GenericMapper<Cuenta>
    {
        public static List<Cuenta> TraerTodo()
        {
            string json = webHelper.Get("/cuenta/");
            List<Cuenta> retorno = JsonConvert.DeserializeObject<List<Cuenta>>(json);
            return retorno;
        }
        public static TransactionResult Insert(Cuenta cuenta)
        {
            NameValueCollection obj = ReverseMap(cuenta);
            string json = webHelper.Post("/cuenta/", obj);
            TransactionResult resultado = webHelper.MapResultado(json);
            return resultado;
        }
        private static NameValueCollection ReverseMap(Cuenta cuenta)
        {
            NameValueCollection a = new NameValueCollection();
            a.Add("id", cuenta.Id.ToString());
            a.Add("idCliente", cuenta.IdCliente.ToString());
            a.Add("Activo", cuenta.Activo.ToString());
            a.Add("FechaApertura", cuenta.FechaApertura.ToString("yyyy-MM-dd"));
            a.Add("FechaModificacion", cuenta.FechaModificacion.ToString("yyyy-MM-dd"));
            a.Add("Saldo", cuenta.Saldo.ToString());
            a.Add("Descripcion", cuenta.Descripcion);
            a.Add("NroCuenta", cuenta.NroCuenta.ToString());
            return a;
        }
    }
}
