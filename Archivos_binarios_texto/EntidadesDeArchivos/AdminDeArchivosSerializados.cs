using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EntidadesDeArchivos.serialize
{
    public class AdminDeArchivosSerializados
    {
        private const string _PATH = @"D:\Coronel\Archivos\TesteoDeArchivos\ArchivoSerializado.xml";

        public static void SerializarPersonaxml()
        {
            Personas persona = new Personas();
            try
            {
                XmlSerializer personaxml = new XmlSerializer(typeof(Personas));

                using (StreamWriter Escritor = new StreamWriter(_PATH))
                {
                    personaxml.Serialize(Escritor, persona);
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Boludo, serializo mal");
            }
        }

        public static Personas DeserializarPersonaxml()
        {
            try
            {
                XmlSerializer personaxml = new XmlSerializer(typeof(Personas));

                using (StreamReader Lector = new StreamReader(_PATH))
                {
                    return (Personas)personaxml.Deserialize(Lector);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Boludo, deserializo mal");
            }
            return null;
        }
    }
}
