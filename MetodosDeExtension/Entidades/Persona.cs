using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string _Nombre;
        private int _Dni;

        public Persona()
        {
            this._Nombre = "Natalia Natalia";
        }

        private Persona(string nombre)
        {
            this._Nombre = nombre;
        }

        public Persona(string nombre,int dni):this(nombre)
        {
            this._Dni = dni;
        }
    }
}
