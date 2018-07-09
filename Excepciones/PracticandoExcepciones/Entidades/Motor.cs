using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public class Motor
    {
        public string Marca;

        public Motor()
        {
            this.Marca = "Sin marca";
        }


        public void Fallar()
        {
            int numero = Carrera.Fallo.Next(1, 100);

            if (numero == 7)
                throw new MotorExcepcion(Marca + " Fallo");
        }
    }
}
