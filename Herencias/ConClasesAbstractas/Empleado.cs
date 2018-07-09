using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConClasesAbstractas
{
    public abstract class Empleado:Humano
    {
        public abstract float Sueldo
        {
            get;
            set;
        }

        public Empleado(string nombre):base(nombre) 
        {
        }
        public override void Mostrar()
        // se puede implementar pero no es obligatorio
        {
 	       //throw new NotImplementedException();
        }//si se implementa aca no se debera implementar obligatoriamente en otro lado

    }
}
