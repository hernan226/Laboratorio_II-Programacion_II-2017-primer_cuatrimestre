using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        /*
         * try puede tener un Throw; pero no se usa.
         * el throw va en metodos, try y catch
         * 
         * 3- en el final siempre tiene try
         * 2- los intermedios tienen try y throw
         * 1- en el principio va solo throw
         * 
         * ej:  
         * ________________________________
         * |              |  try|     throw|
         * |1- propiedad  |     |     x    |
         * |2- constructor|  x  |     x    |
         * |3- instancia  |  x  |     x    |
         * |4- static     |  x  |     x    |
         * |5- main       |  x  |          |
         * |_______________________________|
         */

        static void Main(string[] args)
        {
            int num1;
            int num2 = 10;
            int resultado=0;
            try     
            {
                CapturarExcepcion();
            }
            catch (Exception ex)
            {

                Console.Write(ex.Message);
            }

            try
            {                
                num1 = int.Parse(Console.ReadLine());
                resultado = num2 / num1;
            }
            catch (DivideByZeroException DivEx)
            {
                Console.WriteLine(DivEx.Message);
                Console.WriteLine("Estas dividiendo por cero, boludo.");
                resultado = num2;
            }
            catch (FormatException FormatEx)
            {
                Console.WriteLine(FormatEx.Message);
                Console.WriteLine("Numero ingresado no valido");
                resultado = num2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine(resultado);
            }

            Console.ReadLine();
        }

        public static void CapturarExcepcion()
        {
            Calculadora.calcular();
        }
    }
}
