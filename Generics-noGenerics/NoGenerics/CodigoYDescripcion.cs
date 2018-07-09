using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoGenerics
{
    public class CodigoYDescripcion
    {
        public static int codigo;
        public static string descripcion;

        public void Mostrar()
        {
            Console.WriteLine("codigo: "+codigo+"\tdescripcion: "+descripcion);
        }

        public CodigoYDescripcion(string desc)
        {
            CodigoYDescripcion.descripcion=desc;
        }
    }
}
