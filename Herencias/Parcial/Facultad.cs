using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class Facultad
    {
        public static int numero;
        public int numeroInst;

        static Facultad()
        {
            numero = 22;
        }

        public Facultad()
        {
            numero = 33;
        }

        public static implicit operator int(Facultad obj)
        {
            return 0;
        }

        public static void mostrar(Facultad aux)
        {
            Console.WriteLine("el numero es" + aux.numeroInst);
        }
    }
}
