using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using Entidades;
using Newtonsoft.Json;

namespace Datos
{
    public class webHelper
    {
        static WebClient _client;
        static string _rutaBase;

        static webHelper()
        {
            _client = new WebClient();
            _client.Encoding = Encoding.UTF8;
            _rutaBase = ConfigurationSettings.AppSettings["urlRest"];
            _client.Headers.Add("ContentType", "Application/json");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }
        ///<summary></summary>
        ///<param name="url">/tarjetacredito/</param>
        ///<returns></returns>
        public static string Get(string url)
        {
            string uri = _rutaBase + url;
            return _client.DownloadString(uri);
        }
        public static string Post(string url, NameValueCollection parametros)
        {
            string uri = _rutaBase + url;
            try
            {
                var respuesta = _client.UploadValues(uri, parametros);
                return Encoding.Default.GetString(respuesta);
            }
            catch (Exception ex)
            {
                return "{\"isOk\":false,\"id\":-1,\"error\":'"+ex.Message+"' }";
            }
        }
        public static string Delete(string url, NameValueCollection parametros)
        {
            string uri = _rutaBase + url;
            try
            {
                var respuesta = _client.UploadValues(uri,"DELETE", parametros);
                return Encoding.Default.GetString(respuesta);
            }
            catch (Exception ex)
            {
                return "{\"isOk\":false,\"id\":-1,\"error\":'" + ex.Message + "' }";
            }
        }
        public static string Put(string url, NameValueCollection parametros)
        {
            string uri = _rutaBase + url;
            try
            {
                var respuesta = _client.UploadValues(uri, "PUT", parametros);
                return Encoding.Default.GetString(respuesta);
            }
            catch (Exception ex)
            {
                return "{ \"isOk\":false,\"id\":-1,\"error\":'" + ex.Message + "' }";
            }
        }

        public static TransactionResult MapResultado(string result)
        {
            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(result);
            return resultado;
        }
    }
}
