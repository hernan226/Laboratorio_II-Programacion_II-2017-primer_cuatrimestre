using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Generics
{
    public class Container<T>:IEnumerable<T>
    {
        private List<T> _Elementos;
        private int CantidadMaxima;

        public Container(int cant)
        {
            this._Elementos = new List<T>();
            this.CantidadMaxima = cant;
        }

        private bool EstaLleno()
        {
            return (this._Elementos.Count == this.CantidadMaxima);
        }

        private bool EstaElElemento(T Elemento)
        {
            foreach (T item in this._Elementos)
            {
                if (item.Equals(Elemento))
                    return true;
            }
            return false;
        }

        public bool Agregar(T Elemento)
        {
            this._Elementos.Add(Elemento);
                return true;
        }

        public static bool operator +(Container<T> Lista,T Elemento)
        {
            if (!(Lista.EstaLleno()) && !(Lista.EstaElElemento(Elemento)))
            {
                Lista.Agregar(Elemento);
                return true;
            }
            return false;
        }




        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in this._Elementos)
            {
                /// este te permite modificar
                /// el contenido del objeto
                yield return item;
            }
            ///return this._Elementos.GetEnumerator();
            ///esto solo retorna el elemento
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
