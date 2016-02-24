using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.IntroduccionDotNet
{
    class ClsLogin
    {

        private String usuario;
        private String password;

        public ClsLogin()
        {
            
        }

        public ClsLogin(String usuario,String password)
        {
            this.usuario = usuario;
            this.password = password;
        }

        public String GetUsuario()
        {
            return this.usuario;
        }

        public String GetPassword()
        {
            return this.password;
        }

        public void SetUsuario(String usuario)
        {
            this.usuario = usuario;
        }

        public void SetPassword(String password)
        {
            this.password = password;
        }
    }
}
