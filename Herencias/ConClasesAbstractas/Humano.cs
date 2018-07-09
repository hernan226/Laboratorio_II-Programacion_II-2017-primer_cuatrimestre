using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConClasesAbstractas
{
    /////////////////////////////////////////////////////////////////////////
    //  lo objetos de una clase abstracta no se pueden instanciar y        //
    //  no se puede invocar alconstructor de la misma                      //
    //  los metodos abstractos solo pueden etar en clases abstractas       //
    //  los metodos abstractos notienen implementacion (y terminan en ;)   //
    //                                                                     //
    //  una clase abstracta puede heredar otra clase abstracta             //
    /////////////////////////////////////////////////////////////////////////

    public abstract class Humano
    {
        protected string _Nombre;

        public abstract void Mostrar();

        public Humano(string nombre)
        {
            this._Nombre = nombre;
        }


    }
}
