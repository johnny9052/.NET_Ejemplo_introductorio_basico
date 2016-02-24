using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.IntroduccionDotNet
{
    internal class ClsGestionLogin
    {

        private static LinkedList<ClsLogin> listaUsuarios = new LinkedList<ClsLogin>();
        private static int pos;

        public ClsGestionLogin()
        {
            
        }


        public bool Validar(String usuario, String password)
        {

            for (int x = 0; x < listaUsuarios.Count; x++)
            {
                if (listaUsuarios.ElementAt(x).GetUsuario().Equals(usuario) 
                    && listaUsuarios.ElementAt(x).GetPassword().Equals(password))
                {
                    pos = x;
                    return true;                    
                }
            }

            return false;
        }

        public bool GuardarUsuario(String usuario, String password)
        {
            if (!BuscarUsuario(usuario))
            {
                ClsLogin login = new ClsLogin(usuario, password);
                listaUsuarios.AddLast(login);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool BuscarUsuario(String usuario)
        {            

            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (listaUsuarios.ElementAt(i).GetUsuario().Equals(usuario))
                {

                    return true;
                }
            }

            return false;
        }

        public String buscarNombreUsuario()
        {
            return listaUsuarios.ElementAt(pos).GetUsuario();
        }

    }
}