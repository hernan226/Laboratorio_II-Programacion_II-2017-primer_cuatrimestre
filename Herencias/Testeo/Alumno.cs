using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinHerencias
{
    public class Alumno
    {
        protected int _Dni;
        protected string _Legajo;
        protected string _Nombre;
        protected string _Apellido;

        public Alumno(int dni,string legajo)
        {
            this._Dni = dni;
            this._Legajo = legajo;
        }

        public virtual void Mostrar()
        {
            StringBuilder Bloque = new StringBuilder();

            Bloque.AppendLine("Dni:" + this._Dni);
            Bloque.AppendLine("Nombre:" + this._Nombre);
            Bloque.AppendLine("Apellido:" + this._Apellido);
            Bloque.AppendLine("Legajo:" + this._Legajo);

            Console.WriteLine(Bloque.ToString());
        }
    }
}
