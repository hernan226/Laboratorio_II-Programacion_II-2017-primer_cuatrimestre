using System;
using System.Collections.Generic;
using System.Collections;// NO TE OLVIDES DE AGREGAR ESTO
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoGenerics// sin tipo, sin genero
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList Coleccion;

            CodigoYDescripcion objeto;

            objeto = new CodigoYDescripcion();
            

            Coleccion = new ArrayList(2);

            Coleccion.Add(objeto);

            Coleccion.Add(3);
            Coleccion.Add("Hola.");
            Coleccion.Add("Chau.");//Aca la capacidad se duplica de 2 a 4
            Coleccion.Add(5.4);
            Coleccion.Add("Otro.");//Aca se duplica de 4 a 8

            //Coleccion.Sort();//el vacio los ordena de menor a mayor

            //LIFO= LAST IN FIRST OUT 
            Stack pila = new Stack();

            pila.Push(1);
            //pila.Pop(); devuelve un objeto y lo elimina del stack
            //pila.Peek(); devuelve un objeto sin eliminarlo del stack

            Queue Cola;

            //Cola.Peek(); devuelve un objeto sin eliminarlo del stack
            
            
            foreach (CodigoYDescripcion item in Coleccion)
            {
               // item.Mostrar(); eso generaun error al no se todos objetos del tipo producto
                
            }

        }
    }
}
