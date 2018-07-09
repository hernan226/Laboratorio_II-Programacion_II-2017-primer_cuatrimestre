using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades2
{
    public sealed class Alumno:Persona
    {
        private int _Legajo;
        private bool _Egresado;

        public Alumno()
        {
            this._Egresado = false;
        }

        private Alumno(bool egresado,string nombre,int dni)
            : base(nombre,dni)
        {
            this._Egresado = egresado;
        }

        public Alumno(bool egresado, int legajo,
            string nombre, int dni)
            : this(egresado, nombre, dni)
        {
            this._Legajo = legajo;
        }
    }
}
