using System;

namespace _1.IntroduccionDotNet
{
    class clsUsuario
    {

        String nombre;
        String apellido;
        int cedula;
        String fecha;

        

        public clsUsuario(String nombre,String apellido,int cedula, String fecha)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.fecha = fecha;
        }


        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public void setApellido(String apellido)
        {
            this.apellido = apellido;
        }

        public void setCedula(int cedula)
        {
            this.cedula = cedula;
        }

        public void setFecha(String fecha)
        {
            this.fecha = fecha;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public String getApellido()
        {
            return this.apellido;
        }

        public int getCedula()
        {
            return this.cedula;
        }

        public String getFecha()
        {
            return this.fecha;
        }
    }
}
