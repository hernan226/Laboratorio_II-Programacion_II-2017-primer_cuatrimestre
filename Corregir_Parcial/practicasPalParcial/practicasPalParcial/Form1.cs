using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;
using Entidades;
using Excepciones;

namespace practicasPalParcial
{
    delegate void DLeer();

    public partial class FrmPpal : Form
    {
        public List<Tienda> lista;
        public const string PATH = "Tiendas.xml";

        public FrmPpal()
        {
            InitializeComponent();
            if (File.Exists(PATH))
            {
                this.lista = new List<Tienda>(Cargar());
            }
            else
                this.lista = new List<Tienda>();
        }

        private List<Tienda> Cargar()
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Tienda>));
                StringBuilder sb = new StringBuilder();


                using (StreamReader sr = new StreamReader(PATH))
                {
                    List<Tienda> lt = (List<Tienda>)xs.Deserialize(sr);
                    return lt;
                }
            }
            catch (Exception)
            {
                throw new NoLeeException("No se pudo leer.");
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                lista.Add(new Tienda(this.TxtDireccion.Text, this.TxtAnchoDeFrente.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLeer_Click(object sender, EventArgs e)
        {
            Thread hilo = new Thread(LlenarLista);
            hilo.Start();
        }
        private void LlenarLista()
        {
            guardarTiendas();
            LeerTiendas();
        }
        private void guardarTiendas()
        {       
            try
            {
                    Tienda nuevaTienda =new Tienda();
                    nuevaTienda.Guardar(lista, PATH);
            }
            catch (NoGuardaException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LeerTiendas()
        {
            Tienda tienda= new Tienda();
            try
            {
                if (this.RtbLista.InvokeRequired)
                {
                    DLeer DelegadoLeer = new DLeer(LeerTiendas);
                    this.Invoke(DelegadoLeer);
                }
                else
                    RtbLista.Text = tienda.Leer(PATH);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
