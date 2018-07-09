using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesDeArchivos.Texto
{
    public class AdminDeArchivos
    {
        private const string _PATHARCH = "D:\\Coronel\\Archivos\\TesteoDeArchivos\\Archivo.txt";

        public static void Saludar()
        {//se guardo en D:\Coronel\Archivos\Archivos_Program\bin\Debug
            try
            {
                using (StreamWriter Escritor = new StreamWriter(_PATHARCH))
                {
                    Escritor.WriteLine("Juan,Carlos,40006220,Buenos Aires");
                    Escritor.WriteLine("Pedro,Escorza,33344411,Cordoba");
                    Escritor.WriteLine("Jorge,Lopez,23165463,Chubur");
                }
                using (StreamReader Lector = new StreamReader(@"D:\Coronel\Archivos\TesteoDeArchivos\Archivo.txt"))
                {
                    string Recuperado;

                    while ((Recuperado = Lector.ReadLine()) != null)
                    {
                        Console.WriteLine(Recuperado);
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Boludo, escribio mal");
                //throw ex;
            }
            finally
            {
                Console.WriteLine("Terminus");
                Console.ReadKey();
            }
        }
    }
}
