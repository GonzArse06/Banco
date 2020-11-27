using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace Datos
{
    public class ClienteMapper
    {
        #region Uso de Generics
        public static List<Cliente> TraerTodoClientesGeneric()
        {
            //GenericMapper<Cliente> generico = new GenericMapper<Cliente>();
            //return generico.TraerTodo("/cliente/" + ConfigurationManager.AppSettings["Legajo"]);
            return GenericMapper<Cliente>.TraerTodo("/cliente/" + ConfigurationManager.AppSettings["Legajo"]);
        }
        public static TransactionResult InsertGeneric(Cliente cliente)
        {
            NameValueCollection obj = ReverseFactory<Cliente>.ReverseMap(cliente);
            string resultado = webHelper.Post("/cliente/", obj);
            TransactionResult resultadoTransaction = webHelper.MapResultado(resultado);
            return resultadoTransaction;
        }
        #endregion
        public static List<Cliente> TraerTodoClientes()
        {
            string json = webHelper.Get("/cliente/" + ConfigurationManager.AppSettings["Legajo"]);
            List<Cliente> resultado = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return resultado;
        }
        public static TransactionResult Insert(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);
            string resultado = webHelper.Post("/cliente/", obj);
            TransactionResult resultadoTransaction = webHelper.MapResultado(resultado);
            return resultadoTransaction;
        }
        public static TransactionResult Update(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);
            string resultado = webHelper.Put("/cliente/", obj);
            TransactionResult resultadoTransaction = webHelper.MapResultado(resultado);
            return resultadoTransaction;
        }
        public static TransactionResult Delete(int id)
        {
            NameValueCollection obj = new NameValueCollection();
            obj.Add("Id", id.ToString());
            string resultado = webHelper.Delete("/cliente/", obj);
            TransactionResult transactionResult = webHelper.MapResultado(resultado);
            return transactionResult;
        }
        private static NameValueCollection ReverseMap(Cliente cliente)
        {

            //NameValueCollection n = new NameValueCollection();

            //n.Add("Nombre", cliente.Nombre);
            //n.Add("Apellido", cliente.Apellido);
            //n.Add("Direccion", cliente.Direccion);
            //n.Add("Email", cliente.Email); // STRING
            //n.Add("Telefono", cliente.Telefono.ToString()); // INT
            //n.Add("FechaNacimiento", cliente.FechaNacimiento.ToString("yyyy-MM-dd")); // DateTime
            //n.Add("Activo", cliente.Activo.ToString()); // bool
            //n.Add("Dni", cliente.Dni.ToString());
            //n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
            ////n.Add("Usuario", numeroRegistro);
            //return n;

            NameValueCollection a = new NameValueCollection();
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
            return a;
        }

    }
}
