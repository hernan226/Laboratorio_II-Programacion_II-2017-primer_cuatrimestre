using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Generics
{
    public class Personas
    {
        public string Dni;
        public string Nombre;

        public Personas(string dni, string nombre)
        {
            this.Nombre = nombre;
            this.Dni = dni;
        }

        public override bool Equals(object obj)
        {            
            return ((Personas)obj==this);
        }

        public static bool operator ==(Personas p1, Personas p2)
        {
            return (p1.Dni == p2.Dni && p1.Nombre == p2.Nombre);
        }

        public static bool operator !=(Personas p1, Personas p2)
        {
            return !(p1==p2);
        }
    }
}
