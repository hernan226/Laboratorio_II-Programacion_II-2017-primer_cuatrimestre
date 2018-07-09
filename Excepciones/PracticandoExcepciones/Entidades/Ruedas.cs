using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public class Ruedas
    {
        public string Marca;

        public Ruedas()
        {
            this.Marca = "Sin marca";
        }

        public void Pinchar()
        {
            int numero = Carrera.Fallo.Next(1, 1000);

            if (numero == 7)
                throw new RuedaExcepcion(Marca + " Pincho");
        }
    }
}
