using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CuentaException : Exception
    {
        public CuentaException(string mensaje) : base(mensaje) { }
    }
}
