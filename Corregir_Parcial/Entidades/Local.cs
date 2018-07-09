using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using System.IO;

namespace Entidades
{
    

    public abstract class Local:IArchivos<Tienda>
    {
        public int datos_direccion;
        public int _anchoDeFrente;
        protected abstract int Legajo
        {
            get;
            set;
        }

        public override string ToString()
        {
            return "Direccion: " + this.datos_direccion +
                "\nAncho de frente: " + this._anchoDeFrente
                +"\n";
        }

        public bool Guardar(string datos)
        {
            try
            {
                using (StreamWriter Escritor = new StreamWriter("Locales.xml"))
                {
                    Escritor.WriteLine(datos);
                }
                return true;
            }
            catch (Exception)
            {
                throw new Excepciones.NoGuardaException("No pudo guardar");
            }
        }

        public bool Leer(out string datos)
        {

            using (StreamReader Lector = new StreamReader("Locales.xml"))
            try
            {
                string Recuperado;
                StringBuilder sb=new StringBuilder();
                while ((Recuperado = Lector.ReadLine()) != null)
                {
                    sb.Append(Recuperado);
                }
                datos=sb.ToString();
                return true;
            }
            catch (Exception)
            {
                throw new Excepciones.NoLeeException("No pudo guardar");
            }
        }
    }
}
