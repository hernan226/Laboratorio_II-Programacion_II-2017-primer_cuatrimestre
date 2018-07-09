using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploAbstractoDeInterfases
{
    public abstract class Class2:Class1,InterfaceA
    {

        public new void algo()
        {
            Console.WriteLine("este es el nuevo");
        }

        public new void Algo()
        {
            Console.WriteLine("este es el nuevo");
        }
    }
}
