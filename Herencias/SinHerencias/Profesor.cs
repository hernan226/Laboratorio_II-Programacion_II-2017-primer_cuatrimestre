using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinHerencias
{
    public class Profesor
    {
        private int _Dni;
        private string _FichaDocente;
        private string _Nombre;
        private string _Apellido;
        private DateTime _FechaDeIngreso;

        public Profesor(int dni, string fichaDocente)
        {
            this._Dni = dni;
            this._FichaDocente = fichaDocente;
            
        }

        public void Mostrar()
        {
            StringBuilder Bloque = new StringBuilder();

            Bloque.AppendLine("Dni:" + this._Dni);
            Bloque.AppendLine("Nombre:" + this._Nombre);
            Bloque.AppendLine("Apellido:" + this._Apellido);
            Bloque.AppendLine("Ficha docente:" + this._FichaDocente);
            Bloque.AppendLine("Fecha de ingreso:" + this._FechaDeIngreso);

            Console.WriteLine(Bloque.ToString());
        }
    }
}
