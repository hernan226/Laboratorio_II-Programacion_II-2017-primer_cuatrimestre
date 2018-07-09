using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjemploAbstractoDeInterfases;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class3 hola = new Class3();
            Class4 chau = new Class4();

            hola.Algo();
            hola.algo();

            chau.algoC();
            chau.Algo();

        }
    }
}
