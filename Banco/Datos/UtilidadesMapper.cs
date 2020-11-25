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
    public class UtilidadesMapper
    {
        public static TransactionResult EnviarMail(Utilidades mail)
        {
            NameValueCollection obj = new NameValueCollection();
            obj.Add("Para", mail.Para);
            obj.Add("Asunto", mail.Asunto);
            obj.Add("Mensaje", mail.Mensaje);

            string json = webHelper.Post("/utilidades/", obj);
            TransactionResult resultado = webHelper.MapResultado(json);
            return resultado;
        }
    }
}
