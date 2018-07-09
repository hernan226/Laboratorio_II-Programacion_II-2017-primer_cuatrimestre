using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herenciado
{
    public class AlumnoEgresado:Alumno
    {
        private DateTime _FechaDeEgreso;

        public AlumnoEgresado(int dni,string legajo,DateTime fechaDeEgreso):base(dni,legajo)
        {
            this._FechaDeEgreso = fechaDeEgreso;
        }

        public override string ToString()
        {
            StringBuilder Bloque = new StringBuilder();

            Bloque.AppendLine(base.ToString());
            Bloque.AppendLine("Fecha de egreso: "+this._FechaDeEgreso);

 	         return base.ToString();
        }

        public static bool operator ==(AlumnoEgresado uno, AlumnoEgresado dos)
        {
            return (uno._FechaDeEgreso == dos._FechaDeEgreso);
        }

        public static bool operator !=(AlumnoEgresado uno, AlumnoEgresado dos)
        {
            return !(uno._FechaDeEgreso == dos._FechaDeEgreso);
        }


        public override bool Equals(object obj)
        {
            return (obj is AlumnoEgresado);
        }
    }

}
