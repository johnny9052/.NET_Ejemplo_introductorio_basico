using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.IntroduccionDotNet
{
    internal class ClsTransporte : ClsEntidad
    {
        private int numeroVehiculos;
        private int precioCupo;

        public ClsTransporte(int nit, String nombre, String direccion, int numero, int precio)
        {
            this.nit = nit;
            this.nombre = nombre;
            this.direccion = direccion;
            this.numeroVehiculos = numero;
            this.precioCupo = precio;
        }

        public void SetNumeroVehiculos(int numeroVehiculos)
        {
            this.numeroVehiculos = numeroVehiculos;
        }

        public void SetPrecioCupo(int precioCupo)
        {
            this.precioCupo = precioCupo;
        }

        public int GetNumeroVehiculos()
        {
            return this.numeroVehiculos;
        }

          public int GetPrecioCupo()
        {
            return this.precioCupo;
        }
    }
}
