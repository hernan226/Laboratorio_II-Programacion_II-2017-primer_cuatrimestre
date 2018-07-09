using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinHerencias
{
    public class AlumnoEgresado:Alumno
    {
        private DateTime _FechaDeEgreso;

        public AlumnoEgresado(int dni,string legajo,DateTime fechaDeEgreso):base(dni,legajo)
        {
            this._FechaDeEgreso = fechaDeEgreso;
        }
        public override void Mostrar()
        {
            base.Mostrar();
            StringBuilder Bloque = new StringBuilder();

            Bloque.AppendLine("Fecha de egreso: "+this._FechaDeEgreso);

            Console.WriteLine(Bloque.ToString());
        }
    }
}
