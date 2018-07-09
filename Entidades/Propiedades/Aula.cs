using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propiedades
{
    /// <summary>
    /// En eta clase realizaremos la practica
    /// sobre el concepto de propiedades
    /// </summary>
    public class Aula
    {
        private int _Numero;
        public int Numero
        {
            get
            {
                return this._Numero;
            }
        }
        //  Una propiedad puede ser de lectura y escritura,
        //  solo lectura o solo escritura
        private string _Profesor;
        public string Profesor
        {
            get {   return this._Profesor;  }
            set {   this._Profesor = value; }
        }

        private int _Capacidad;
        private List<Entidades.Alumno> _MisAlumnos;

        public Aula()
        {
            _MisAlumnos = new List<Entidades.Alumno>();
        }

        public int LugaresLibres
        {
            get{    return this._Capacidad - this._MisAlumnos.Count;    }
            // siempre se escribe dentro de un get o un set
        }// Una propiedad no necesariamente debe estar emparejada con una variable

        public int AgregarAlumno
        {
            set
            {
                bool bandera = false;//se pueden declarar variables dentro de una propiedad

                foreach (Entidades.Alumno item in this._MisAlumnos)
                {
                    if (item == value)
                    {
                        bandera = true;
                        break;
                    } 
                }

                if (!bandera)
                {
                    this._MisAlumnos.Add(new Entidades.Alumno("n","n",value));
                }

            }
        }//puedo programar todauna funcion dentro de una propiedad
        
        
        
                /*     esto queda innecesario al usar propiedades 
                public int GetteCapacidad()
                {
                    return this._Capacidad;
                }

                public void SetterCapacidad(int numero)
                {
                    this._Capacidad = numero;
                }*/
    }
}
