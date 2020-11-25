using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Utilidades
    {
        private string _para,_asunto,_mensaje;

        public Utilidades(string para, string asunto, string mensaje)
        {
            this._para = para;
            this._asunto = asunto;
            this._mensaje = mensaje;
        }
        public string Para { get => _para; set => _para = value; }
        public string Asunto { get => _asunto; set => _asunto = value; }
        public string Mensaje { get => _mensaje; set => _mensaje = value; }
    }
}
