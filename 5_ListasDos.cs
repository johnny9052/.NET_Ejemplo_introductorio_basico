using System;
using System.Windows.Forms;

namespace _1.IntroduccionDotNet
{

    public partial class _5_ListasDos : Form
    {
        ClsGestionVehiculo gestion;
        public _5_ListasDos(){
            InitializeComponent();
            gestion = new ClsGestionVehiculo();
        }

        private void btnGuardar_Click(object sender, EventArgs e){
            String placa = txtPlaca.Text;
            String marca = txtMarca.Text;
            String color = txtColor.Text;

            if (!gestion.GuardaVehiculo(placa, marca, color))
            {
                MessageBox.Show("Error al guardar los datos");
            }
            else
            {
                MessageBox.Show("Guardado con exito");
                limpiar();
            }
        }


        public void limpiar()
        {
            txtColor.Text = "";
            txtMarca.Text = "";
            txtPlaca.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e){
            try{
                String placa = txtPlaca.Text;
                ClsVehiculo vehiculo = gestion.BuscarVehiculo(placa);

                if (vehiculo != null){
                    CargarInformacion(vehiculo);
                }
                else{
                    MessageBox.Show("No existe la placa ingresada");
                }
            }
            catch (Exception exception){
                MessageBox.Show("Error al buscar la informacion");
            }
        }


        private void CargarInformacion(ClsVehiculo vehiculo){
            txtMarca.Text = vehiculo.GetMarca();
            txtColor.Text = vehiculo.GetColor();
            txtPlaca.Text = vehiculo.GetPlaca();
        }

        private void btnModificar_Click(object sender, EventArgs e){
            String placa = txtPlaca.Text;
            String marca = txtMarca.Text;
            String color = txtColor.Text;

            if (gestion.EditarVehiculo(placa, marca, color)){
                MessageBox.Show("Editado con exito");
                limpiar();
            }
            else{
                MessageBox.Show("No se encuentra el elemento");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            String placa = txtPlaca.Text;

            if (gestion.EliminarVehiculo(placa))
            {
                MessageBox.Show("Eliminado exitosamente");
                limpiar();
            }
            else
            {
                MessageBox.Show("No se encuentra el elemento");
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {

            ClsVehiculo vehiculo = gestion.ObtenerPrimero();

            if (vehiculo != null)
            {
                CargarInformacion(vehiculo);
            }
            else
            {
                MessageBox.Show("No existen vehiculos");
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            ClsVehiculo vehiculo = gestion.ObtenerAnterior();

            if (vehiculo != null)
            {
                CargarInformacion(vehiculo);
            }
            else
            {
                MessageBox.Show("No existen vehiculos");
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            ClsVehiculo vehiculo = gestion.ObtenerSiguiente();

            if (vehiculo != null)
            {
                CargarInformacion(vehiculo);
            }
            else
            {
                MessageBox.Show("No existen vehiculos");
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            ClsVehiculo vehiculo = gestion.ObtenerUltimo();

            if (vehiculo != null)
            {
                CargarInformacion(vehiculo);
            }
            else
            {
                MessageBox.Show("No existen vehiculos");
            }
        }

    }
}
