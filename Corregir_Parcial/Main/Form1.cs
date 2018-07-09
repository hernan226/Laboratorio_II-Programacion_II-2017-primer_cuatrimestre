using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using System.Threading;

namespace Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Tienda nuevaTienda = new Tienda(this.TxtDireccion.Text,
                this.TxtAnchoDelLocal.Text);
            try
            {
                //nuevaTienda.Guardar(nuevaTienda.ExponerDatos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLeer_Click(object sender, EventArgs e)
        {
            Tienda nuevaTienda = new Tienda("0",
                "0");
            try
            {
                //this.LstLocales.Text=

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void guardartienda(string direccion, string ancho)
        {

        }
    }
}
