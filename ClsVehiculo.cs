using System;

namespace _1.IntroduccionDotNet
{
    class ClsVehiculo
    {

        private String placa;
        private String marca;
        private String color;


        public ClsVehiculo(String placa,String marca,String color)
        {
            this.placa = placa;
            this.marca = marca;
            this.color = color;
        }

        public void SetPlaca(String placa)
        {
            this.placa = placa;
        }

        public void SetMarca(String marca)
        {
            this.marca = marca;
        }


        public void SetColor(String color)
        {
            this.color = color;
        }

        public String GetPlaca()
        {
            return this.placa;
        }

        public String GetMarca()
        {
            return this.marca;
        }

        public String GetColor()
        {
            return this.color;
        }
    }
}
