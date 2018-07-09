using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public class Aula
    {
        private List<Alumno> _Alumnos;
        private int _Espacio;
        public int Espacio
        {
            set
            {
                if (value > 0 && value < 51)
                    this._Espacio = value;
                else
                {
                    if (value < 0)
                        this._Espacio = 1;
                    else
                        this._Espacio = 50;
                }
            }
        }

        private Aula()
        {
            this._Alumnos = new List<Alumno>();
        }

        public Aula(int espacio):this()
        {
            this.Espacio = espacio;
        }

        public int EspacioDisponible
        {
            get { return this._Espacio - this._Alumnos.Count; }
        }

        public List<Alumno> Alumnos
        {
            get { return this._Alumnos; }
        }

        public static Aula operator +(Aula aula,Alumno alumno)
        {
            if (aula.EspacioDisponible == 0)
                throw new AulaLlenaException("Aula llena.");

            aula._Alumnos.Add(alumno);
            
            return aula;
        }

        public static bool operator ==(Aula aula, Alumno alumno)
        {
            foreach (Alumno item in aula.Alumnos)
            {
                if (item==alumno)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Aula aula, Alumno alumno)
        {
            return !(aula == alumno);
        }
    }
}
