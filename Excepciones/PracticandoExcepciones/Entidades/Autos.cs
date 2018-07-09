using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace Entidades
{
    public class Autos
    {
        public string Marca;
        public Ruedas RuedaDelanteraDerecha;
        public Ruedas RuedaDelanteraIzquierda;
        public Ruedas RuedaTraseraDerecha;
        public Ruedas RuedaTraseraIzquierda;
        public Motor  MiMotor;
        public int NumeroDeCorredor;

        public Autos(int Corredor)
        {
            this.NumeroDeCorredor = Corredor;
            this.Marca = "Sin marca.";
            this.MiMotor = new Motor();
            this.RuedaDelanteraDerecha = new Ruedas();
            this.RuedaDelanteraIzquierda = new Ruedas();
            this.RuedaTraseraDerecha = new Ruedas();
            this.RuedaTraseraIzquierda = new Ruedas();
        }

        public void Andar()
        {
            try
            {
                this.MiMotor.Fallar();
                this.RuedaDelanteraDerecha.Pinchar();
                this.RuedaDelanteraIzquierda.Pinchar();
                this.RuedaTraseraDerecha.Pinchar();
                this.RuedaTraseraIzquierda.Pinchar();

            }
            catch (MotorExcepcion ex)
            {
                throw new MiExcepcion("Corredor: " + this.NumeroDeCorredor + "\t"+ex.Message, ex);
            }
            catch (RuedaExcepcion ex)
            {
                throw new MiExcepcion("Corredor: " + this.NumeroDeCorredor + "\t"+ex.Message, ex);
            }
            catch (MiExcepcion ex)
            {
                throw new MiExcepcion("Corredor: " + this.NumeroDeCorredor + "\t"+ex.Message, ex);
            }
        }

    }
}
