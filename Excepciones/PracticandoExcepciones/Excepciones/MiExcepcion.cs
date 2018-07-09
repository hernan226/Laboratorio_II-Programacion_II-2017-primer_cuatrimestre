using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class MiExcepcion:Exception
    {
        public MiExcepcion(string mensaje) : base(mensaje) { }

        public MiExcepcion() : base() { }

        public MiExcepcion(string mensaje,Exception ex) : base(mensaje, ex) { }
    }
}
