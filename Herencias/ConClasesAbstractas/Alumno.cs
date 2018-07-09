using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConClasesAbstractas
{
    public class Alumno:Persona
    {
        protected int _Legajo;
        
        public Alumno(string dni, string nombre,int legajo):base(dni,nombre)
        {
            this._Legajo = legajo;
        }

        public override void Mostrar()
        // Aca es opcional sobreescribir el metodo            
        {
            base.Mostrar();
            Console.WriteLine(this._Legajo);
        }

    }
}
