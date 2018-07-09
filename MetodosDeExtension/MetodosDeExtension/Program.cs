using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades2;

namespace MetodosDeExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alu1 = new Alumno(false, 1, "Juan", 1111);
            int i=0;
            
            Console.WriteLine(alu1.MostrarDatos(564));
            Console.WriteLine("tjdyjdyjdy".MostrarDatos());
            Console.WriteLine(i.MostrarDatos());
            Console.ReadKey();
        }
    }
    /// <summary>
    /// Clase que contiene un metodo de extension
    /// </summary>
    public static class ClaseExtendedora
    {
        /// <summary>
        /// Metodo de extension
        /// </summary>
        /// <param name="alumnoAux">siempre va "this" y
        /// el tipo de dato del parametro(no cuenta como parametro)
        /// </param>
        /// <param name="algo">un numero que muestra</param>
        /// <returns>trulala + algo</returns>
        public static string MostrarDatos
            (this Alumno alumnoAux,int algo)
        {
            return "trulala "+algo;
        }

        public static string MostrarDatos
            (this string alumnoAux)
        {
            return "coliflor";
        }

        public static int MostrarDatos
            (this int alumnoAux)
        {
            return 22;
        }
    }
}
