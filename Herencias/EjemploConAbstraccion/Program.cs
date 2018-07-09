using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploConAbstraccion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ConClasesAbstractas.Humano> Humanos=new List<ConClasesAbstractas.Humano>();

            Humanos.Add(new ConClasesAbstractas.Persona("324234","hernan"));
            Humanos.Add(new ConClasesAbstractas.Alumno("3534534","dario",33));

            foreach (ConClasesAbstractas.Humano item in Humanos)
	        {
                item.Mostrar();
	        }
        }
    }
}
