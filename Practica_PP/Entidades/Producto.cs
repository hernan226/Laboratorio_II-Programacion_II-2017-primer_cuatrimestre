using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        protected int _CodigoDeBarra;

        private EMarcaProducto _Marca;
        protected EMarcaProducto Marca { get { return _Marca; } }

        private float _Precio;
        protected float Precio { get { return _Precio; } }
        /*
        explicit operator int(Producto prod)
        {
            return 1;
        }*/

    }
}
