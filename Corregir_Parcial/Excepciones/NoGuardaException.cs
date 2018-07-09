using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NoGuardaException:Exception
    {
        public NoGuardaException() : base() { }

        public NoGuardaException(string message)
            :base(message) { }

        public NoGuardaException(string message,
            Exception innerException)
            : base(message, innerException) { }
    }
}
