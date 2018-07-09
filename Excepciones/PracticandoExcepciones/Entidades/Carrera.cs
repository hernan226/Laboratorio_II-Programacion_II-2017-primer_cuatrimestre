using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public class Carrera
    {
        public List<Autos> ListaAutos;
        public static Random Fallo;
        public int Vuelta;
        public int corredor;

        static Carrera()
        {
            Fallo = new Random();
        }

        public Carrera()
        {
            this.Vuelta = 0;
            this.ListaAutos = new List<Autos>();
        }

        public void Correr()
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    foreach (Autos item in this.ListaAutos)
                    {
                        item.Andar();
                        corredor=item.NumeroDeCorredor;
                    }

                    this.Vuelta++;
                }
            }
            catch(MiExcepcion ex)
            {
                Console.WriteLine("Vuelta: " + this.Vuelta + "\t"+"Marca: "+ ex.InnerException.Message);
                throw ex;
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }
    }
}
