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
    public partial class _8_1_Productos : Form
    {

        private ClsGestionLogin login;

        public _8_1_Productos()
        {
            InitializeComponent();
            login = new ClsGestionLogin();
            prepararSaludo();
        }

        public void prepararSaludo()
        {
            lblSaludo.Text = "Bienvenido al sistema Sr(a) " + login.buscarNombreUsuario() + "!";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Thread hiloInterfaz = new System.Threading.Thread(new System.Threading.ThreadStart(AbrirLogin));
            this.Close();
            hiloInterfaz.SetApartmentState(System.Threading.ApartmentState.STA);
            hiloInterfaz.Start();
        }

        private void AbrirLogin()
        {
            _8_MenuPrincipal vistaProductos = new _8_MenuPrincipal();
            vistaProductos.ShowDialog();
        }
    }
}
