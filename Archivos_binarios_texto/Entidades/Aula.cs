using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Entidades
{
    
    public class Aula
    {
        private int _Numero;
        public int Numero
        {
            get { return this._Numero; }
        }

        private bool _Internet;
        public bool Internet
        {
            set { this._Internet = value; }
        }

        private List<Personas> _Ocupantes;
        public List<Personas> Ocupantes
        {
            get { return this._Ocupantes; }
            set { this._Ocupantes = value; }
        }

        private Aula()
        {
            this._Ocupantes = new List<Personas>();
        }

        public Aula(int numero, bool internet):this()
        {
            this._Internet = internet;
            this._Numero = numero;
        }

        public static Aula operator +(Aula aula,Alumno alumno)
        {
            aula.Ocupantes.Add(alumno);

            return aula;
        }

        public static Aula operator +(Aula aula, Profesor profe)
        {
            aula.Ocupantes.Add(profe);

            return aula;
        }

        public static Aula operator +(Aula aula, Personas persona)
        {
            aula.Ocupantes.Add(persona);

            return aula;
        }

        public bool SerializarAula()
        {
            string _Path = @"D:\Coronel\Archivos\TesteoDeArchivos\Aula_"+this.Numero+".xml";

            try
            {
                XmlSerializer AulaXml = new XmlSerializer(typeof(Aula));

                using (StreamWriter Escritor = new StreamWriter(_Path))
                {
                    AulaXml.Serialize(Escritor, this);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }

        public bool DeserializarAula()
        {
            const string _PATH = @"D:\Coronel\Archivos\TesteoDeArchivos\Aula2.xml";
            Aula aux;
            try
            {
                XmlSerializer AulaXml = new XmlSerializer(typeof(Aula));

                using (StreamReader Lector = new StreamReader(_PATH))
                {
                    aux = (Aula)AulaXml.Deserialize(Lector);

                    this.Ocupantes = aux.Ocupantes;
                    this._Numero = aux.Numero;
                    this.Internet = aux._Internet;
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
