using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIAulas
{
    public partial class FrmListar : Form
    {
        public FrmListar()
        {
            InitializeComponent();
        }

        public FrmListar(EntidadesAula.Aula MiAula) : this()
        {
            foreach (EntidadesAula.Alumno item in MiAula.ListaDeAlumnos)
            {
                LstListado.Items.Add(item.Nombre);
            }
        }

    }
}
