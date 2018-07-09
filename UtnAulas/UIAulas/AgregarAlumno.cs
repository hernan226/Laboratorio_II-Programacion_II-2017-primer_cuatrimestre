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
    public partial class FrmAgregarAlumno : Form
    {
        private EntidadesAula.Alumno _NuevaAula;
        public EntidadesAula.Alumno NuevaAula
        {
            get { return this._NuevaAula; }
        }

        public FrmAgregarAlumno()
        {
            InitializeComponent();
        }

        private void FrmAgregarAlumno_Load(object sender, EventArgs e)
        {
            this.CmbSexo.Items.Add(EntidadesAula.SexoEnum.Femenino);
            this.CmbSexo.Items.Add(EntidadesAula.SexoEnum.Masculino);
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this._NuevaAula = new EntidadesAula.Alumno(int.Parse(TxtLegajo.Text), (EntidadesAula.SexoEnum)CmbSexo.SelectedItem, TxtNombre.Text);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }


    }
}
