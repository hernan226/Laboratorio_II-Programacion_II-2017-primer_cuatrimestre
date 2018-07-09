using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABMEstacionamiento.Motorizado
{
    public class Moto:Vehiculos,Iimprimible
    {
        public int Cilindrada;

        public Moto(string matricula) : base(matricula) { }

        public Moto(string matricula,int cilind):base(matricula)
        {
            this.Cilindrada = cilind;
        }

        
        public override bool Equals(object obj)
        {
            return (obj is Moto);
        }


        void Iimprimible.MostrarPago()
        {
            Console.WriteLine("garcaaa!!");
        }

        string Iimprimible.DamelTicket()
        {
            return "garcaaa!!";
        }
    }
}
