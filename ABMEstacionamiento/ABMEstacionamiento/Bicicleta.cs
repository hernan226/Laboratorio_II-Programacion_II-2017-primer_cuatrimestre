using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABMEstacionamiento.Complemento
{
    public class Bicicleta:Iguardable,Iimprimible
    {
        void Iimprimible.MostrarPago()
        {
            Console.WriteLine("garcaaa!!");
        }

        string Iimprimible.DamelTicket()
        {
            return "garcaaa!!";
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
