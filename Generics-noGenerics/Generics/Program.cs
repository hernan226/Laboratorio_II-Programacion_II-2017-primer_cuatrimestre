using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using NoGenerics;// allias, otra forma de referenciar

namespace Generics //con tipo, con genero
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaEnteros = new List<int>();
            List<string> listaPalabras = new List<string>();
            //List<CodigoYDescripcion> listaProductos = new List<CodigoYDescripcion>(); instanciado usando allias
            List<NoGenerics.CodigoYDescripcion> listaProductos = new List<NoGenerics.CodigoYDescripcion>();//instanciado usando referencia
           
            listaEnteros.Add(55);
            listaEnteros.Add(33);

            listaProductos.Add(new NoGenerics.CodigoYDescripcion("Galletitas"));
            listaProductos.Add(new NoGenerics.CodigoYDescripcion("Papas fritas"));
            listaProductos.Add(new NoGenerics.CodigoYDescripcion("Alfajor"));
            listaProductos.Add(new NoGenerics.CodigoYDescripcion("Gaseosa"));
            listaProductos.Add(new NoGenerics.CodigoYDescripcion("Helado"));

        }
    }
}
