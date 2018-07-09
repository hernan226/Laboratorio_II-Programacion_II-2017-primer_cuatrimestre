using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    class Comparadora
    {
        /// <summary>
        /// Este metodo retorna el numero mayor entre dos enteros.
        /// </summary>
        /// <param name="num1">Primer entero.</param>
        /// <param name="num2">Segundo entero.</param>
        /// <returns>Retorna el mayor entero.</returns>
        public static int RetornarMayor(int num1, int num2)
        {
            int retorno=0;

            if (num1 < num2)
                retorno = num2;
            else
                retorno = num1;


            return retorno;
        }
        /// <summary>
        /// Este metodo retorna el numero de valor intermedio entre tres numeros.
        /// </summary>
        /// <param name="num1">Primer entero.</param>
        /// <param name="num2">Segundo entero.</param>
        /// <param name="num3">Tercer entero.</param>
        public static void MostrarElDelMedio(int num1, int num2, int num3)
        {
            if (num1 > num2)
            {
                
            
            }
        
        }
    }
}
