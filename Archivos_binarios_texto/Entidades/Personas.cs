using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Profesor))]
    [XmlInclude(typeof(Alumno))]
    public class Personas:Humano
    {
        
        ///para que el serializador acceda a los atributos privados
        ///este debe tener una propiedad con los metodos get y set,
        ///si no tiene ambos no los serializara.
        ///si los atributos son publicos, no es neceario que tengan
        ///ninguna propiedad


        private string _Nombre;
        public string Nombre
        {
            get { return this._Nombre; }
            set { this._Nombre = value; }
        }
        private string _Apellido;
        public string Apellido
        {
            get { return this._Apellido; }
            set { this._Apellido = value; }
        }
        
        public Personas()
        {
            this.Nombre = "Natalia";
            this.Apellido = "Natalia";
            this.Dni = 0;
        }
        
        public Personas(string nombre, string apellido,int dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
        }


        public bool Serializarme()
        {
            try
            {
                XmlSerializer serializador= new XmlSerializer(typeof(Personas));

                using(StreamWriter escritor = new StreamWriter("laruta.xml") )
                {
                    serializador.Serialize(escritor, this);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }



    }
}
