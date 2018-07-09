using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class RuedaExcepcion:MiExcepcion
    {
        public RuedaExcepcion(string mensaje) : base(mensaje) { }

        public RuedaExcepcion() : base() { }

        public RuedaExcepcion(string mensaje, Exception ex) : base(mensaje, ex) { }
    }
}
