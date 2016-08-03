using System;

namespace _1.IntroduccionDotNet
{
    class clsUsuario
    {

        public String nombre { get; set; }
        public String apellido { get; set; }
        public int cedula { get; set; }
        public String fecha { get; set; }
        
        public clsUsuario(String nombre,String apellido,int cedula, String fecha)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.fecha = fecha;
        }

    }
}
