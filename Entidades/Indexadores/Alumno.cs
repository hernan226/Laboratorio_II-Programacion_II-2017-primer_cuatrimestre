using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores
{
    public class Alumno
    {
        private int Legajo;
        private string Nombre;

        public Alumno(int legajo)
        {
            this.Legajo = legajo;
        }

        public Alumno(string nombre, int legajo):this(legajo)
        {
            this.Nombre = nombre;
        }
    }
}
