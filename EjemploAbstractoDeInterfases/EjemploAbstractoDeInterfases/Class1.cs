using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploAbstractoDeInterfases
{
    public abstract class Class1:InterfaceA
    {
        public void algo()
        {
            Console.WriteLine("este es el viejo");
        }

        public void Algo()
        {
            Console.WriteLine("este es el viejo");
        }
    }
}
