using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TarjetaException:Exception
    {
        public TarjetaException(string mensaje) : base(mensaje)
        { }
    }
}
