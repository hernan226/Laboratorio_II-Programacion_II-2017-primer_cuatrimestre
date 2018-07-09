using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABMEstacionamiento.Motorizado;
using ABMEstacionamiento.Complemento;

namespace ABMEstacionamiento
{
    class Estacionamiento:Iguardable
    {
        public string Nombre;
        public List<Iguardable> vehiculos;

        public Estacionamiento()
        {
            this.vehiculos = new List<Iguardable>();
        }

        public Estacionamiento(string nombre):this()
        {
            this.Nombre = nombre;
        }

        public static implicit operator Estacionamiento(string nombre)
        {           
            return new Estacionamiento(nombre);
        }

        public static Estacionamiento operator +(Estacionamiento est,Vehiculos auto)
        {
            est.vehiculos.Add(auto);
            return est;
        }

        public static Estacionamiento operator -(Estacionamiento est,Vehiculos auto)
        {
            if (est==auto)
            {
                est.vehiculos.RemoveAt(RetornarIndice(est, auto));
            }
            return est;
        }

        public static bool operator ==(Estacionamiento est, Vehiculos auto)
        {
            foreach (Vehiculos item in est.vehiculos)
            {
                if (item==auto)
                {
                    return true;
                }
            }
            return false;
        }

        public static int RetornarIndice(Estacionamiento est, Vehiculos auto)
        {
            int indice=0;
            foreach (Vehiculos item in est.vehiculos)
            {
                if (item == auto)
                {
                    return indice;
                }
                indice++;
            }
            return -1;
        }

        public static bool operator !=(Estacionamiento est, Vehiculos auto)
        {
            return !(est == auto);
        }

        DateTime Iguardable.fechaDeIngreso
        {
            get { throw new NotImplementedException(); }
        }

        void Iguardable.MostrarPago()
        {
            throw new NotImplementedException();
        }
    }
}
