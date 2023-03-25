using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {

        public string codigousuario { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string contrasena { get; set; }
       
        
        public byte[] Foto { get; set; }

        public Usuario()
        {
        }

        public Usuario(string codigousuario, string nombre, string correo, string contrasena,  byte[] foto)
        {
            this.codigousuario = codigousuario;
            this.nombre = nombre;
            this.correo = correo;
            this.contrasena = contrasena;
            
            Foto = foto;
        }
    }
}
