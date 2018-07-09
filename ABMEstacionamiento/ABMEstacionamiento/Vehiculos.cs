using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMEstacionamiento.Motorizado
{
    public abstract class Vehiculos:Iguardable
    {
        public string Patente;
        private DateTime _fechaDeIngreso;

        public Vehiculos(string patente)
        {
            this.Patente = patente;
        }

        public Vehiculos(string patente, DateTime fecha):this(patente)
        {
            this._fechaDeIngreso = fecha;
        }

        public static bool operator ==(Vehiculos auto1, Vehiculos auto2)
        {            
            if (auto1.Patente==auto2.Patente && Equals(auto1,auto2))
                return true;
            return false;
        }

        public static bool operator !=(Vehiculos auto1, Vehiculos auto2)
        {
            return !(auto2 == auto1);
        }



        DateTime Iguardable.fechaDeIngreso
        {
            get { return this._fechaDeIngreso; }
        }

        void Iguardable.MostrarPago()
        {
            Console.WriteLine("garcaaa!!");
        }
    }
}
