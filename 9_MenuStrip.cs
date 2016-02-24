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
    public partial class _9_MenuStrip : Form
    {
        public _9_MenuStrip()
        {
            InitializeComponent();
        }

        private void prodoctosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMensaje.ForeColor = Color.Red;
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMensaje.ForeColor = Color.Blue;
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMensaje.ForeColor = Color.Green;
        }

        private void rojoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtMensaje.BackColor = Color.Red;
        }

        private void azulToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtMensaje.BackColor = Color.Blue;
        }

        private void verdeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtMensaje.BackColor = Color.Green;
        }

        private void pequeñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMensaje.Font = new Font("Times New Roman",6);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMensaje.Font = new Font("Times New Roman", 11);
        }

        private void grandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtMensaje.Font = new Font("Times New Roman", 20);
        }
    }
}
