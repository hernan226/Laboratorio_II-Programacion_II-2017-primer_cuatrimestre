using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Entidades;


namespace PracticandoExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrera MiCarrera = new Carrera();

            MiCarrera.ListaAutos.Add(new Autos(1));
            MiCarrera.ListaAutos.Add(new Autos(2));
            MiCarrera.ListaAutos.Add(new Autos(3));
            MiCarrera.ListaAutos.Add(new Autos(4));
            MiCarrera.ListaAutos.Add(new Autos(5));
            MiCarrera.ListaAutos.Add(new Autos(6));

            MiCarrera.Correr();

            Console.WriteLine("Carrera finalizada");
            Console.ReadLine();

        }
    }
}
