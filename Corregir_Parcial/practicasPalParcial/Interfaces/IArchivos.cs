using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IArchivos<T>
    {
        bool Guardar(List<T> datos, string archivo);
        string Leer(string archivo);
    }
}
