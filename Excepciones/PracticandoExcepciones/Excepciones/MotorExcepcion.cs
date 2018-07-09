using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class MotorExcepcion:MiExcepcion
    {
        public MotorExcepcion(string mensaje) : base(mensaje) { }

        public MotorExcepcion() : base() { }

        public MotorExcepcion(string mensaje, Exception ex) : base(mensaje, ex) { }
    }
}
