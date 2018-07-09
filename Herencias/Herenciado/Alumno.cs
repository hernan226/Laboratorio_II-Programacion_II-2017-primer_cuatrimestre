using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herenciado
{
    public class Alumno : Persona
    {
        protected string _Legajo;

        public Alumno(int dni, string legajo)
            : base(dni)
        {
            this._Legajo = legajo;
        }

        public override string ToString()
        {
            StringBuilder Bloque = new StringBuilder();
            Bloque.AppendLine(base.ToString());

            Bloque.AppendLine("Legajo: " + this._Legajo);
            return Bloque.ToString();
        }

        public static bool operator ==(Alumno uno, Alumno dos)
        {
            return (uno._Legajo==dos._Legajo);
        }
        public static bool operator !=(Alumno uno, Alumno dos)
        {
            return !(uno._Legajo == dos._Legajo);
        }


        public override bool Equals(object obj)
        {
            return (obj is Alumno);
        }

    }
}