using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Configuration;
using Newtonsoft.Json;
using Entidades;

namespace Datos
{
    public class GenericMapper<T>
    {
        public static List<T> TraerTodo(string url)
        {
            string json = webHelper.Get(url);
            return JsonConvert.DeserializeObject<List<T>>(json);
        }
        //https://sparraguerra.wordpress.com/2015/07/01/net-que-son-los-generics-y-su-implementacion-en-c-y-ii/
        //public TransactionResult Insert(T t)
        //{
        //    NameValueCollection obj = new NameValueCollection();//aca hay que generar un patron fabrica para instanciar todos los reverse mapper en una clase estatica.
        //}
        //public T ReverseMap(T t);
    }
    public class ReverseFactory<T>
    {
        public static NameValueCollection ReverseMap(T t)
        {
            NameValueCollection a = new NameValueCollection();
            //switch (t.GetType())
            //{
            //    case Cliente:
            //        break;
            //}
            if (t is Cliente cliente)
            {
                a.Add("Id", cliente.Id.ToString());
                a.Add("Dni", cliente.Dni.ToString());
                a.Add("Nombre", cliente.Nombre);
                a.Add("Apellido", cliente.Apellido);
                a.Add("Direccion", cliente.Direccion);
                a.Add("Email", cliente.Email);
                a.Add("Telefono", cliente.Telefono);
                a.Add("FechaNacimiento", cliente.FechaNacimiento.ToString("yyyy-MM-dd"));
                a.Add("FechaAlta", cliente.FechaAlta.ToString("yyyy-MM-dd"));
                a.Add("Activo", cliente.Activo.ToString());
                //a.Add("host", cliente.Host.ToString());
                a.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
            }
            return a;
        }
    }
}
