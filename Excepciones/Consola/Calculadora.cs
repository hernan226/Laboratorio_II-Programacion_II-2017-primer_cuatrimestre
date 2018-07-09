using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MisExcepciones;

namespace Consola
{
    public class Calculadora
    {
        

        public static void calcular()
        {
            Calculadora cosa = new Calculadora();

            
            try
            {
                cosa.GenerarExcepcion();
            }
            catch (Exception ex)
            {

                throw new Exception("static calcular - " + ex.Message);
            }
        }

        public void GenerarExcepcion()
        {
            throw new FirstException("error mio");
        }


    }
}
