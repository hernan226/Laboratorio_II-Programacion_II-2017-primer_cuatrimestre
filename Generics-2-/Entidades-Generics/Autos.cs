using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Generics
{
    public class Autos
    {
        public string Marca;
        public string Patente;
        public string Color;

        public Autos(string marca, string color, string patente) 
        {
            this.Patente = patente;
            this.Marca = marca;
            this.Color = color;
        }


        public override bool Equals(object obj)
        {
            return ((Autos)obj == this);
        }

        public static bool operator ==(Autos m1, Autos m2)
        {
            return (m1.Marca == m2.Marca && m1.Color == m2.Color && m1.Patente == m2.Patente);
        }

        public static bool operator !=(Autos m1, Autos m2)
        {
            return !(m1 == m2);
        }
    }
}
