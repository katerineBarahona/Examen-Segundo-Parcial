using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BdDatos;
using System.Windows.Forms;
using Entidades;

     

namespace Vistas
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void acepbtn_Click(object sender, EventArgs e)
        {

            if (usuaritxt.Text == string.Empty)
            {
                errorProvider1.SetError(usuaritxt, "Porfavor Ingrese el Usuario");

                return;
            }
            errorProvider1.Clear();
            if (contrasentxt.Text == "")
            {
                errorProvider1.SetError(contrasentxt, "Ingrese una contrasena");
                return;
            }
            errorProvider1.Clear();

           
            Login login = new Login(usuaritxt.Text, contrasentxt.Text);

            UsuarioDB usuarioDB = new UsuarioDB();
            Usuario usuario = new Usuario();
            usuario = usuarioDB.Autenticar(login);

            if (usuario != null)    
            {
                //Mandar al menu 
                Menu menuformulario = new Menu();
                this.Hide();
                menuformulario.Show();
            }
            else
            {
                MessageBox.Show("datos del usurio incorrectos");
            }
        }

        private void cancelabtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (contrasentxt.PasswordChar == '*')
            {
                contrasentxt.PasswordChar = '\0';
            }
            else
            {
                contrasentxt.PasswordChar = '*';
            }

        }
    }
}
