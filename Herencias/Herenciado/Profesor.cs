using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herenciado
{
    public class Profesor : Persona
    {
        private string _FichaDocente;
        private DateTime _FechaDeIngreso;

        public Profesor(int dni, string fichaDocente)
            : base(dni)
        {
            this._FichaDocente = fichaDocente;

        }

        public override string ToString()
        {
            StringBuilder Bloque = new StringBuilder();
            Bloque.AppendLine(base.ToString());

            Bloque.AppendLine("Ficha docente: " + this._FichaDocente);
            Bloque.AppendLine("Fecha de ingreso: " + this._FechaDeIngreso);
            return Bloque.ToString();
        }

        public static bool operator ==(Profesor uno, Profesor dos)
        {
            return (uno._FichaDocente == dos._FichaDocente);
        }

        public static bool operator !=(Profesor uno, Profesor dos)
        {
            return !(uno._FichaDocente == dos._FichaDocente);
        }


        public override bool Equals(object obj)
        {
            return (obj is Profesor);
        }
    }
}
