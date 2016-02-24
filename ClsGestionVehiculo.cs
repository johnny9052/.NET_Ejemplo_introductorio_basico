using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.IntroduccionDotNet
{
    class ClsGestionVehiculo
    {
        LinkedList<ClsVehiculo> listaVehiculos = new LinkedList<ClsVehiculo>();
        private int indice = 0;

        public bool GuardaVehiculo(String placa, String marca, String color)
        {
            try
            {
                ClsVehiculo vehiculo = new ClsVehiculo(placa, marca, color);
                listaVehiculos.AddLast(vehiculo);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public ClsVehiculo BuscarVehiculo(String placa)
        {
            ClsVehiculo vehiculo = null;

            for (int i = 0; i < listaVehiculos.Count; i++)
            {
                if (listaVehiculos.ElementAt(i).GetPlaca().Equals(placa))
                {
                    indice = i;
                    return listaVehiculos.ElementAt(i);
                }
            }

            return vehiculo;
        }



        public bool EditarVehiculo(String placa, String marca, String color)
        {
            try
            {
                for (int i = 0; i < listaVehiculos.Count; i++)
                {
                    if (listaVehiculos.ElementAt(i).GetPlaca().Equals(placa))
                    {
                        listaVehiculos.ElementAt(i).SetMarca(marca);
                        listaVehiculos.ElementAt(i).SetColor(color);
                        return true;
                    }
                }

                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }



        public bool EliminarVehiculo(String placa){
            var node = listaVehiculos.First;
            while (node != null){
                var nextNode = node.Next;
                if (node.Value.GetPlaca().Equals(placa)){
                    listaVehiculos.Remove(node);
                    indice = 0;
                    return true;
                }
                node = nextNode;
            }
            return false;
        }

        public ClsVehiculo ObtenerPrimero(){
            indice = 0;

            if (listaVehiculos.Count > 0){
                return listaVehiculos.First();
            }
            else{
                return null;
            }
        }

        
        public ClsVehiculo ObtenerAnterior(){
            if (listaVehiculos.Count > 0){
                if (indice > 0){
                    indice--;
                }

                return listaVehiculos.ElementAt(indice);
            }
            else
            {
                return null;
            }
        }



        public ClsVehiculo ObtenerSiguiente()
        {
            if (listaVehiculos.Count > 0)
            {
                if (indice < listaVehiculos.Count-1)
                {
                    indice++;
                }

                return listaVehiculos.ElementAt(indice);
            }
            else
            {
                return null;
            }
        }


        public ClsVehiculo ObtenerUltimo()
        {
            indice = listaVehiculos.Count-1;

            if (listaVehiculos.Count > 0)
            {
                return listaVehiculos.Last();
            }
            else
            {
                return null;
            }
        }
    }

}
