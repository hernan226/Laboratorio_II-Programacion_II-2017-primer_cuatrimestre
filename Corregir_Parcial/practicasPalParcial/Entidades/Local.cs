using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Local
    {
        protected string _direccion;
        public string Direccion
        {
            get { return this._direccion; }
            set{this._direccion=value;}
        }
        protected int _anchoDeFrente;
        public int AnchoDeFrente
        {
            get { return this._anchoDeFrente; }
            set
            {
                if (value<2||value%2!=0)
                    throw new Exception("Ancho de frente invalido.");
                else
                    this._anchoDeFrente = value;
            }
        }
        public string AnchoDeFrenteString
        {
            
            set
            {
                int Ancho;
                if (int.TryParse(value, out Ancho))
                    this.AnchoDeFrente = Ancho;
                else
                    throw new Exception("Ancho de frente invalido.");
            }
        }

        protected abstract int Legajo { get; set; }

        public override string ToString()
        {
            return "Direccion: " 
                + this._direccion 
                + "  Ancho de frente: " 
                + this._anchoDeFrente
                + "mts.";
        }
    }
}
