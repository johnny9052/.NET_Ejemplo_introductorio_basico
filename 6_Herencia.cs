using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.IntroduccionDotNet
{
    public partial class _6_Herencia : Form
    {
        public _6_Herencia()
        {
            InitializeComponent();
        }

        private void btnDemostrar_Click(object sender, EventArgs e)
        {
            int nit = Convert.ToInt32(txtNit.Text);
            String nombre = txtNombreEmpresa.Text;
            String direccion = txtDireccion.Text;
            int numeroVeh = Convert.ToInt32(txtNumeroVehiculos.Text);
            int precioCupo = Convert.ToInt32(txtPrecio.Text);

            ClsTransporte transporte = new ClsTransporte(nit,nombre,direccion,numeroVeh,precioCupo);

            MessageBox.Show("Nombre: " + transporte.nombre + "\n" +
                            "Nit: "+transporte.nit+"\n" +
                            "Direccion: "+transporte.direccion + "\n" +
                            "Numero de vehiculos: " + transporte.numeroVehiculos + "\n" +
                            "Precio cupo: " + transporte.precioCupo + "");
        }
    }
}
