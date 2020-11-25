using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public abstract class GenericMapper<T>
    {
        public abstract T TraerTodo();
        public abstract T Insert(T t);
        public abstract T ReverseMap(T t);
    }
}
