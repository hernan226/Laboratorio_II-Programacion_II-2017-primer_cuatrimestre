using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herenciado
{
    public class Persona
    {
        protected int _Dni;

        private string _Nombre;

        protected string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        private string _Apellido;
        protected string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        public Persona(int dni)
        {
            this._Dni = dni;
        }

        public override string ToString()
        {
            StringBuilder Bloque = new StringBuilder();
            Bloque.AppendLine("DNI: " + this._Dni);
            Bloque.AppendLine("Apellido: " + this._Apellido);
            Bloque.AppendLine("Nombre: " + this._Nombre);
            return Bloque.ToString();
        }

        public void Mostrar()
        {
            Console.WriteLine(this.ToString());
        }

        public static bool operator ==(Persona uno, Persona dos)
        {            
            return (uno._Dni==dos._Dni);
        }

        public static bool operator !=(Persona uno, Persona dos)
        {
            return !(uno._Dni == dos._Dni);
        }

        public override bool Equals(object obj)
        {
            return (obj is Persona);
        }
    }
}
