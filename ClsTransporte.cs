using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.IntroduccionDotNet
{
    internal class ClsTransporte : ClsEntidad
    {
        public int numeroVehiculos { get; set; }
        public int precioCupo { get; set; }

        public ClsTransporte(int nit, String nombre, String direccion, int numero, int precio)
        {
            this.nit = nit;
            this.nombre = nombre;
            this.direccion = direccion;
            this.numeroVehiculos = numero;
            this.precioCupo = precio;
        }
    
    }
}
