using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class login
    {

        public string codigousuario { get; set; }
        public string contrasena { get; set; }


        public login()
        {
        }

        public login(string codigousuario, string contrasena)
        {
            this.codigousuario = codigousuario;
            this.contrasena = contrasena;

        }
    }
}
