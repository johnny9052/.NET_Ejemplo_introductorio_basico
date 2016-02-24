using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _1.IntroduccionDotNet
{
    class ClsEntidad
    {

        protected int nit;
        protected String nombre;
        protected String direccion;

        public void SetNit(int nit)
        {
            this.nit = nit;
        }

        public void SetNombre(String nombre)
        {
            this.nombre = nombre;
        }


        public void SetDireccion(String direccion)
        {
            this.direccion = direccion;
        }


        public int GetNit()
        {
            return this.nit;
        }

        public String GetNombre()
        {
            return this.nombre;
        }

        public String GetDireccion()
        {
            return this.direccion;
        }
    }
}
