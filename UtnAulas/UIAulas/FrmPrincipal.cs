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
    public partial class FrmPrincipal : Form
    {
        public EntidadesAula.Aula MiAula;

        public FrmPrincipal()
        {
            InitializeComponent();
            MiAula = new EntidadesAula.Aula(123);
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarAlumno FormularioAlumno = new FrmAgregarAlumno();
            if (FormularioAlumno.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                MiAula.ListaDeAlumnos.Add(FormularioAlumno.NuevaAula);
            }
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListar FormularioListar = new FrmListar(MiAula);

            FormularioListar.Show();
        }

    }
}
