using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class Login : Form
    {
        public Login()
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

            Menu menuformulario = new Menu();
            this.Hide();
            menuformulario.Show();

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
