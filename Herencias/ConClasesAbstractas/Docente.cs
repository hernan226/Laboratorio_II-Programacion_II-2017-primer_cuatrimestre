using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConClasesAbstractas
{
    public class Docente:Empleado
    {
        public Docente(string nombre) : base(nombre)
        {

        }

        public override float Sueldo
        {
            get
            {
                //throw new NotImplementedException();
                return 0;
            }
            set
            {
               // throw new NotImplementedException();
            }
        }
    }
}
