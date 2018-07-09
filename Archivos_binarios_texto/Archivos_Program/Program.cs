using Entidades;
using EntidadesDeArchivos.Bin;
using EntidadesDeArchivos.serialize;
using EntidadesDeArchivos.Texto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Archivos_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Personas persona = new Personas();
            //AdminDeArchivos.Saludar();
            //SerializarPersonaxml();
            //persona = EntidadesDeArchivos.serialize.AdminDeArchivosSerializados.DeserializarPersonaxml();
            //EntidadesDeArchivos.Bin.AdminDeArchivosBin.SerializarPersonaBinaria();
            //Console.WriteLine("{0}\t{1}", persona.Apellido, persona.Nombre);
            Aula MiAula = new Aula(662, true);
            /*
            MiAula.Alumnos.Add(new Personas("Juan", "Carlos",11111));
            MiAula.Alumnos.Add(new Personas("Juan", "Carlos",22222));
            MiAula.Alumnos.Add(new Personas("Juan", "Carlos",33333));
            MiAula.Alumnos.Add(new Personas());
            */
            Profesor profe1 = new Profesor();
            profe1.Apellido = "Diaz";
            profe1.Dni = 12345;
            profe1.Nombre = "Juan";
            profe1.Titulo = "Licenciado en boludologia";
            Alumno Alu1 = new Alumno();
            Alu1.Apellido = "Diaz";
            Alu1.Dni = 12345;
            Alu1.Nombre = "Juan";
            Alu1.Legajo = 1;
            Alumno Alu2 = new Alumno();
            Alu2.Apellido = "Diaz";
            Alu2.Dni = 12345;
            Alu2.Nombre = "Juan";
            Alu2.Legajo = 1;
            Alumno Alu3 = new Alumno();
            Alu3.Apellido = "Diaz";
            Alu3.Dni = 12345;
            Alu3.Nombre = "Juan";
            Alu3.Legajo = 1;
            Alumno Alu4 = new Alumno();
            Alu4.Apellido = "Diaz";
            Alu4.Dni = 12345;
            Alu4.Nombre = "Juan";
            Alu4.Legajo = 1;

            MiAula = MiAula + profe1;
            MiAula = MiAula + Alu1;
            MiAula = MiAula + Alu2;
            MiAula = MiAula + Alu3;
            MiAula = MiAula + Alu4;

           
            
            MiAula.SerializarAula();

            

        } 
    }    
}
