using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.IntroduccionDotNet
{
    class ClsInventario
    {

        private String producto;
        private int cantidad;
        private double precio;

        public ClsInventario()
        {
            
        }
        
        public ClsInventario(String producto, int cantidad, double precio)
        {
            this.producto = producto;
            this.cantidad = cantidad;
            this.precio = precio;
        }


        public String GetProducto()
        {
            return this.producto;
        }

        public int GetCantidad()
        {
            return this.cantidad;
        }

        public double GetPrecio()
        {
            return this.precio;
        }


        public void SetProducto(String producto)
        {
            this.producto = producto;
        }


        public void SetCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public void SetPrecio(double precio)
        {
            this.precio = precio;
        }
    }
}
