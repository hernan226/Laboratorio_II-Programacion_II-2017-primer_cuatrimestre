using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int ElMayor;
            string dato;
          
            Console.WriteLine("Hola mundo.");
            ElMayor = Comparadora.RetornarMayor(10, 5);
            Sello.color = ConsoleColor.DarkRed;
            Sello.mensaje = "Nuevo mensaje.";
            
            dato=Sello.imprimir();
            Console.WriteLine(dato);
            Sello.ImprimirColor();

        }
    }
}
