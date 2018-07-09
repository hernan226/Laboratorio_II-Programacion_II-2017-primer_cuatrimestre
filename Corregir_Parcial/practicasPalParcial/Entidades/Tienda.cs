using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using Interfaces;
using Excepciones;

namespace Entidades
{
    public class Tienda : Local, IArchivos<Tienda>
    {

        public Tienda() { }
        public Tienda(string direccion, string anchoDeFrente)
            :this(anchoDeFrente)
        {
            this._direccion = direccion;
        }
        private Tienda(string anchoDeFrente)
        {
            try
            {                
                this.AnchoDeFrenteString = anchoDeFrente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected override int Legajo
        {
            get
            {
                return this._anchoDeFrente;
            }
            set
            {
                this._anchoDeFrente = value;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    
        
        public bool Guardar(List<Tienda> datos, string archivo)
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Tienda>));

                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    xs.Serialize(sw, datos);
                }
                return true;
            }
            catch (Exception)
            {
                throw new NoGuardaException("No se pudo guardar.");
            }
        }

        public string Leer(string archivo)
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Tienda>));
                StringBuilder sb = new StringBuilder();
               

                using (StreamReader sr = new StreamReader(archivo))
                {
                    List<Tienda> lt = (List<Tienda>)xs.Deserialize(sr);
                    foreach (Tienda item in lt)
                    {
                        sb.AppendLine(item.ToString());
                    }
                    return sb.ToString();
                }
            }
            catch (Exception)
            {
                throw new NoLeeException("No se pudo leer.");
            }
        }
    }
}
