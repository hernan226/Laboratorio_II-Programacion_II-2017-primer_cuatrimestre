using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ABMEstacionamiento
{
    public interface Iguardable
    {
        DateTime fechaDeIngreso { get; }

        void MostrarPago();
    }
}
