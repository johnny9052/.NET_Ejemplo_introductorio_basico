using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace _1.IntroduccionDotNet
{
    public partial class _4_ListasUno : Form
    {
        public _4_ListasUno()
        {
            InitializeComponent();
        }

        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            LinkedList<String> nombres = new LinkedList<String>();

            nombres.AddLast("Johnny");
            nombres.AddLast("Pedro");
            nombres.AddLast("Juan");
            nombres.AddLast("Andres");

            for (int x = 0; x < nombres.Count; x++)
            {
                MessageBox.Show(nombres.ElementAt(x));
            }
        }
    }
}
