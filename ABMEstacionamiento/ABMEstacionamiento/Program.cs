using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABMEstacionamiento.Motorizado;
using ABMEstacionamiento.Complemento;

namespace ABMEstacionamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Estacionamiento CarlosAparca = new Estacionamiento();

            CarlosAparca = "Carlos Aparca";
           
            CarlosAparca = CarlosAparca + new Auto("A3", 4);

            CarlosAparca = CarlosAparca + new Moto("A3", 2);

            CarlosAparca = CarlosAparca - new Auto("A3");
            

        }
    }
}
