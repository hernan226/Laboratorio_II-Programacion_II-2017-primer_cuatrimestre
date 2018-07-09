using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private string _NombreCompleto;
        private string _Legajo;

        public Alumno(string nombre, string legajo):this(legajo)
        {
            this._NombreCompleto = nombre;

        }

        private Alumno(string legajo)
        {
            this._Legajo = legajo;
        }


        public static bool operator ==(Alumno alumno1, Alumno alumno2)
        {
            return (alumno1._Legajo == alumno2._Legajo && alumno1._NombreCompleto == alumno2._NombreCompleto);
        }

        public static bool operator !=(Alumno alumno1, Alumno alumno2)
        {
            return !(alumno1 == alumno2);
        }
    }
}
