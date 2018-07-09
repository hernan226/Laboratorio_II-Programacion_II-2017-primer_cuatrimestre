using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;

namespace TestUnitarioAula
{
    [TestClass]
    public class TestUnitarioAula
    {
        /// <summary>
        /// Testeamos que la lista estee instancciada
        /// </summary>
        [TestMethod]
        public void ListaCorrecta()
        {
            Aula TestAula = new Aula(5);
            Assert.IsNotNull(TestAula.Alumnos);
        }
        
        /// <summary>
        /// Verificar que el espacio se encuentre entre los valores:
        /// Minmo: 1
        /// Maximo: 50
        /// </summary>
        [TestMethod]
        public void EspacioAulaIncorrecto()
        {
            Aula AulaGrande = new Aula(51);
            if (AulaGrande.EspacioDisponible > 50)
                Assert.Fail("Espacio disponible mal validado: {0}",AulaGrande.EspacioDisponible);

            Aula AulaChica = new Aula(0);
            Assert.AreNotEqual(AulaChica.EspacioDisponible, 0,"Espacio disponible mal validado {0}",AulaChica.EspacioDisponible);

            Aula AulaCorrecta = new Aula(20);
            Assert.AreEqual(AulaCorrecta.EspacioDisponible, 20, "Espacio disponible mal validado {0}", AulaCorrecta.EspacioDisponible);
        }

        [TestMethod]
        public void AgregarAlumnoEspacioDisponible()
        {
            Aula MiAula = new Aula(2);

            Alumno a1 = new Alumno("Juan Carlos", "1");
            Alumno a2 = new Alumno("Juan Carlos", "2");

            MiAula = MiAula + a1;
            Assert.AreEqual(MiAula.EspacioDisponible, 1);

            MiAula = MiAula + a2;
            Assert.AreEqual(MiAula.EspacioDisponible, 0);

        }

        [TestMethod]
        public void AgregarAlumnosAulaLlena()
        {
            Aula MiAula = new Aula(1);

            Alumno a1 = new Alumno("Juan Carlos", "1");
            Alumno a2 = new Alumno("Juan Carlos", "2");

            MiAula = MiAula + a1;
            try
            {                
                MiAula = MiAula + a2;
                Assert.Fail("Nunca deberia llegar aqui.");
            }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex, typeof(AulaLlenaException));
            }
        }

        [TestMethod]
        public void AgregarAlumnoVerDato()
        {
            Aula MiAula = new Aula(1);

            Alumno a1 = new Alumno("Juan Carlos", "1");
            Alumno testeo = new Alumno("Juan Carlos", "1");

            if (MiAula != testeo)
                Assert.Fail("No son iguales");   
        }
        [TestMethod]
        public void AgregarAlumnoMostrarCantidad()
        {
            Alumno a1 = new Alumno("Juan Carlos", "1");
            Alumno a2 = new Alumno("Pedro Parrilla", "2");
            Alumno a3 = new Alumno("Carlos Juarez", "3");

            
            //agregar 3 alumnos, recorrerlos sin saber el limite y devolver cuantos elementos tiene (CAP > 3)
        }// buscar TDD
    }
}
