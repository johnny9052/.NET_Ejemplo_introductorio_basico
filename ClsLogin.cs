using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.IntroduccionDotNet
{
    class ClsLogin
    {

        public String usuario { get; set; }
        public String password { get; set; }

        public ClsLogin()
        {
            
        }

        public ClsLogin(String usuario,String password)
        {
            this.usuario = usuario;
            this.password = password;
        }

    }
}
