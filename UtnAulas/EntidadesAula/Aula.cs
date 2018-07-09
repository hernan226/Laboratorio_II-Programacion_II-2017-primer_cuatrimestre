using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAula
{
    public class Aula
    {
        private int _Numero;

        private List<Alumno> _ListaDeAlumnos;
        public List<Alumno> ListaDeAlumnos
        {
            get { return this._ListaDeAlumnos; }
        }

        public Aula(int numero):this()
        {
            this._Numero = numero;
        }
        private Aula()
        {
            this._ListaDeAlumnos = new List<Alumno>();
        }
    }
}
