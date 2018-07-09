using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploAbstractoDeInterfases
{
    public class Class4:Class1,InterfaceB,InterfaceC
    {


        public void algoC()
        {
            Console.WriteLine("este es el C");
        }

        void InterfaceB.algo()
        {
            throw new NotImplementedException();
        }

        void InterfaceB.otracosa()
        {
            throw new NotImplementedException();
        }
    }
}
