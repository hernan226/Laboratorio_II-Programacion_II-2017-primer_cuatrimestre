using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Generics
{
    public class Tv
    {
        public string Marca;
        public int Pulgadas;
        public string Resolucion;

        public Tv(string marca, int pulg, string res)
        {
            this.Marca = marca;
            this.Pulgadas = pulg;
            this.Resolucion = res;
        }

        public override bool Equals(object obj)
        {            
            return ((Tv)obj==this);
        }

        public static bool operator ==(Tv m1, Tv m2)
        {
            return (m1.Marca == m2.Marca && m1.Pulgadas == m2.Pulgadas && m1.Resolucion == m2.Resolucion);
        }

        public static bool operator !=(Tv m1, Tv m2)
        {
            return !(m1==m2);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Marca: " + this.Marca+"Pulgadas: "+this.Pulgadas+"Resolucion:"+this.Resolucion);

            return base.ToString();

            /// TOSTRING PARA CADA CLASE
        }
    }
}
