using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public class Humano
    {
        private int _Dni;
        public int Dni
        {
            get { return this._Dni; }
            set { this._Dni = value; }
        }

        
    }
}
