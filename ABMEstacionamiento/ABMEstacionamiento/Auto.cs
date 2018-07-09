using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMEstacionamiento.Motorizado
{
    public class Auto:Vehiculos
    {
        public int CantidadDePuertas;

        public Auto(string matricula) : base(matricula) { }

        public Auto(string matricula,int puertas):base(matricula)
        {
            this.CantidadDePuertas = puertas;
        }
       
        public override bool Equals(object obj)
        {
            return (obj is Auto);
        }

    }
}
