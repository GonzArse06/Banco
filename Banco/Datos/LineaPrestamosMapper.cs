using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class LineaPrestamosMapper
    {
        public static List<TipoPrestamos> GetLineaPrestamos()
        {
            string json = webHelper.Get("/prestamotipo/");
            return JsonConvert.DeserializeObject<List<TipoPrestamos>>(json);
        }
    }
}
