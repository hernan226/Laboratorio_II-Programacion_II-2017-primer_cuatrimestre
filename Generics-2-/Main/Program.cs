using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Generics;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Container<Muebles> MiContainer = new Container<Muebles>(10);
            Muebles mueble1 = new Muebles("Arce", 50, "1,20 m");
            Muebles mueble2 = new Muebles("Cedro", 40, "1,30 m");
            Muebles mueble3 = new Muebles("Pino", 30, "1,10 m");
            Muebles mueble4 = new Muebles("Arce", 50, "1,20 m");
            bool m;

            m = MiContainer + mueble1;
            m = MiContainer + mueble2;
            m = MiContainer + mueble3;
            m = MiContainer + mueble4;


        }
    }
}
