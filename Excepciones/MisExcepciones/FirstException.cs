using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisExcepciones
{
    public class FirstException:Exception
    {
        public FirstException(string mensaje) : base(mensaje) { }

        public FirstException() : base() { }

        public FirstException(string mensaje, Exception excepcion) : base(mensaje, excepcion) { }
    }
}
