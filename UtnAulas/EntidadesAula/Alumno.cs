using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAula
{
    public class Alumno
    {
        private int _Legajo;
        public int Legajo
        {
            get { return _Legajo; }
            set { this._Legajo = value; }
        }

        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { this._Nombre = value; }
        }

        private SexoEnum _Sexo;
        public SexoEnum Sexo
        {
            get { return _Sexo; }
            set { this._Sexo = value; }
        }


        public Alumno(int legajo, SexoEnum sexo, string nombre)
        {
            this._Legajo = legajo;
            this._Nombre = nombre;
            this._Sexo = sexo;
        }
    }
}
