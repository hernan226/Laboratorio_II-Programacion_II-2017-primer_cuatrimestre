using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConClasesAbstractas
{
    public sealed class AlumnoEgresado:Alumno
    {
        private DateTime FechaDeEgreso;

        public AlumnoEgresado(string nombre,string dni, int legajo, DateTime fecha ) : base(dni,nombre,legajo)
        {
            this.FechaDeEgreso = fecha;
        }
    }
}
