using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.IntroduccionDotNet
{
    public partial class _8_1_RegistrarUsuarios : Form
    {

        private ClsGestionLogin login;

        public _8_1_RegistrarUsuarios()
        {
            InitializeComponent();
            login = new ClsGestionLogin();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Thread hiloInterfaz = new System.Threading.Thread(
                new System.Threading.ThreadStart(AbrirLogin));
            this.Close();
            hiloInterfaz.SetApartmentState(System.Threading.ApartmentState.STA);
            hiloInterfaz.Start();
        }

        private void AbrirLogin()
        {
            _8_MenuPrincipal vistaProductos = new _8_MenuPrincipal();
            vistaProductos.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String usuario = txtNombre.Text;
            String password = txtPassword.Text;

            if (login.GuardarUsuario(usuario, password))
            {
                MessageBox.Show("Guardado con exito");
                limpiar();
            }
            else
            {
                MessageBox.Show("El usuario ya existe");
            }
        }

        public void limpiar()
        {
            txtPassword.Text = "";
            txtNombre.Text = "";
        }
    }
}
