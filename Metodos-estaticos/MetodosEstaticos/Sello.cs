using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        /// <summary>
        /// Borra el mensaje.
        /// </summary>
        public static void BorrarMensaje()
        {

            Sello.mensaje = "";

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string imprimir()
        {

            return mensaje;
        
        }


        public static void ImprimirColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.mensaje);
        }
    }
}
