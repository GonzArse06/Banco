using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PlazoFijoException : Exception
    {
        public PlazoFijoException(string mensaje) : base(mensaje) { }
    }
}
