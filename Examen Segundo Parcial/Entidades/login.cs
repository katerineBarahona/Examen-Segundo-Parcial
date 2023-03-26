using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Login
    {

        public string codigousuario { get; set; }
        public string contrasena { get; set; }


        public Login()
        {
        }

        public Login(string codigousuario, string contrasena)
        {
            this.codigousuario = codigousuario;
            this.contrasena = contrasena;

        }
    }
}
