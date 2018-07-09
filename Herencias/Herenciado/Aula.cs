using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herenciado
{
    
    public class Aula
    {
        public List<Herenciado.Persona> MiLista;

        public Aula()
        {
            this.MiLista = new List<Herenciado.Persona>();
        }

        public int CantidadDePersonas()
        {
            return this.MiLista.Count;
        }

        public int CantidadDeAlumnos()
        {
            int count=0;
            foreach (Herenciado.Persona item in this.MiLista)
            {
                if (item is Herenciado.Alumno)
                {
                    count++;
                }
                
            }

            return count;
        }

        public int CantidadDeEgresados()
        {
            int count = 0;
            foreach (Herenciado.Persona item in this.MiLista)
            {
                if (item is Herenciado.AlumnoEgresado)
                {
                    count++;
                }

            }

            return count;
        }

        public int CantidadDeProfesores()
        {
            int count = 0;
            foreach (Herenciado.Persona item in this.MiLista)
            {
                if (item is Herenciado.Profesor)
                {
                    count++;
                }

            }

            return count;
        }

        public void AgregarPersona(Herenciado.Persona persona)
        {
            this.MiLista.Add(persona);
        }




        public bool BorrarPersona(Herenciado.Persona persona)
        {

            
            foreach (var item in MiLista)
            {                
                if(persona is AlumnoEgresado)
                {

                    if (((AlumnoEgresado)persona).Equals(item) && persona == item)
                    {
                        MiLista.Remove((AlumnoEgresado)item);
                    }
                }
                else
                {
                    if (persona is Alumno)
                    {
                        if (((Alumno)persona).Equals(item) && (Alumno)persona == (Alumno)item)
                        {
                            MiLista.Remove((Alumno)item);
                        }
                        
                    }
                    else
                    {

                        if (((Persona)persona).Equals(item) && (Persona)persona == (Persona)item)
                        {
                            MiLista.Remove((Persona)item);
                        }
                    }
                }
            }



            return true;
        }
    }
}
