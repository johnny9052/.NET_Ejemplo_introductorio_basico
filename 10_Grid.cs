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
    public partial class _10_Grid : Form
    {

        List<string[]> list = new List<string[]>();
        LinkedList<ClsInventario> listaInventarios = new LinkedList<ClsInventario>();

        public _10_Grid()
        {
            InitializeComponent();
            
            inicializarGrid();
        }


        public void inicializarGrid()
        {
            cargarDatos();

            // Convert to DataTable.
            DataTable table = ConvertListToDataTable(list);
            dataGridView1.DataSource = table;
        }

        public void cargarDatos()
        {
            list.Clear();

            for (int x = 0; x < listaInventarios.Count; x++)
            {
                list.Add(new string[] {listaInventarios.ElementAt(x).GetProducto(), 
                                       listaInventarios.ElementAt(x).GetCantidad()+"", 
                                       listaInventarios.ElementAt(x).GetPrecio()+""});
            }
        }


        static DataTable ConvertListToDataTable(List<string[]> list)
        {
            // New table.
            DataTable table = new DataTable();

            // Get max columns.
            int columns = 0;

            foreach (var array in list)
            {
                if (array.Length > columns)
                {
                    columns = array.Length;
                }
            }

            table.Columns.Add("Producto");
            table.Columns.Add("Cantidad");
            table.Columns.Add("Precio");

            // Add rows.
            foreach (var array in list)
            {
                table.Rows.Add(array);
            }

            return table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String producto = txtProducto.Text;
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            double precio = Convert.ToDouble(txtPrecio.Text);

            ClsInventario inventario = new ClsInventario(producto, cantidad, precio);

            listaInventarios.AddLast(inventario);

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            inicializarGrid();
        }
    }
}
