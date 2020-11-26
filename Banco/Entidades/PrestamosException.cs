using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PrestamosException : Exception
    {
        public PrestamosException(string mensaje) : base(mensaje)
        { }
    }
}
