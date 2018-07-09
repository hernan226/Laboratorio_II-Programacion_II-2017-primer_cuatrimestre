using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EntidadesDeArchivos.Bin
{
    public class AdminDeArchivosBin
    {
        private const string _PATH = @"D:\Coronel\Archivos\TesteoDeArchivos\ArchivoBinario.bin";

        public static void SerializarPersonaBinaria()
        {
            Personas persona = new Personas();
            IFormatter Formateador = new BinaryFormatter();

            using (Stream archivo = new FileStream(_PATH, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                Formateador.Serialize(archivo, persona);
            }
        }
        
        public static void DeserializarPersonaBinaria()
        {
            IFormatter Formateador = new BinaryFormatter();

            using (Stream archivo = new FileStream(_PATH, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                Personas aux = (Personas)Formateador.Deserialize(archivo);
                Console.WriteLine(aux.Nombre, aux.Apellido);
            }            
        }
    }
}
