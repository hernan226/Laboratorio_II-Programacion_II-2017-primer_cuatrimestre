using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Profesor:Personas
    {
        private string _Titulo;
        public string Titulo
        {
            get { return this._Titulo; }
            set { this._Titulo = value; }
        }

        
    }
}
