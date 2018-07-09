using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Alumno:Personas
    {
        private int _Legajo;
        public int Legajo
        {
            get { return this._Legajo; }
            set { this._Legajo = value; }
        }
    }
}
