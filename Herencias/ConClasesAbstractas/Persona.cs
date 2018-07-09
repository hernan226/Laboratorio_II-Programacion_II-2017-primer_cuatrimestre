using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConClasesAbstractas
{
    public class Persona:Humano
    {
        /////////////////////////////////////////////////////////////////
        //  los metodos abstractos se definen en clases                //
        //  abstractas pero se deben sobreescribir en las clases hijas //
        /////////////////////////////////////////////////////////////////
        protected string _Dni;

        public override void Mostrar()
        //  Aca es obligatorio sobreescribir el metodo
        {
            Console.WriteLine(this._Dni);
            Console.WriteLine(this._Nombre);
        }


        public Persona(string dni, string nombre):base(nombre)
        {
            this._Dni = dni;
        }

        
    }
}
