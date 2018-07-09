using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class AulaLlenaException:Exception
    {
        public AulaLlenaException(string mensaje) : base(mensaje) { }

        public AulaLlenaException() : base() { }

        public AulaLlenaException(string mensaje, Exception ex) : base(mensaje, ex) { }
    }
}
