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
    public partial class _8_MenuPrincipal : Form
    {

        private ClsGestionLogin login;

        public _8_MenuPrincipal()
        {
            InitializeComponent();
            login = new ClsGestionLogin();
            txtPassword.PasswordChar = '*';
        }

        private void _8_MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String usuario = txtUsuario.Text;
            String password = txtPassword.Text;

            if (login.Validar(usuario, password))
            {
                Thread hiloInterfaz = new System.Threading.Thread
                    (new System.Threading.ThreadStart(AbrirIntefazMenu));
                this.Close();
                hiloInterfaz.SetApartmentState(System.Threading.ApartmentState.STA);
                hiloInterfaz.Start();
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
            }

        }

        private void AbrirIntefazMenu()
        {
            _8_1_Productos vistaProductos = new _8_1_Productos();
            vistaProductos.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread hiloInterfaz = new System.Threading.Thread(
                new System.Threading.ThreadStart(AbrirRegistroUsuarios));
            this.Close();
            hiloInterfaz.SetApartmentState(System.Threading.ApartmentState.STA);
            hiloInterfaz.Start();
        }


        private void AbrirRegistroUsuarios()
        {
            _8_1_RegistrarUsuarios vistaProductos = new _8_1_RegistrarUsuarios();
            vistaProductos.ShowDialog();
        }
    }
}
