using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tienda:Local
    {
        protected override int Legajo
        {
            get
            {
                return this.datos_direccion;
            }
            set
            {
                this.datos_direccion = value;
            }
        }
        public Tienda(string dir, string ancho)
        {
            this.Legajo = int.Parse(dir);
            this.SetAnchoDeFrente(int.Parse(ancho));
        }

        public void SetAnchoDeFrente(int nuevoAncho)
        {
            this._anchoDeFrente = nuevoAncho;
        }

        public string ExponerDatos()
        {
            return base.ToString();
        }
    }
}
