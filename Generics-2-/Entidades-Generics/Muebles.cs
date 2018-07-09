using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Generics
{
    public class Muebles
    {
        public string Material;
        public int Peso;
        public string Tamanio;

        public Muebles(string material, int peso, string tam)
        {
            this.Material = material;
            this.Tamanio = tam;
            this.Peso = peso;
        }

        public override bool Equals(object obj)
        {
            return ((Muebles)obj == this);
        }

        public static bool operator ==(Muebles m1, Muebles m2)
        {
            return (m1.Material == m2.Material && m1.Peso == m2.Peso && m1.Tamanio == m2.Tamanio);
        }

        public static bool operator !=(Muebles m1, Muebles m2)
        {
            return !(m1 == m2);
        }
    }
}
