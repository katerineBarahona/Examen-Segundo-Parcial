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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void usuariotoolStripButton1_Click(object sender, EventArgs e)
        {
            usuariosform userform = new usuariosform();

            userform.MdiParent = this;

            userform.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void GeneTicketstoolStripButton1_Click(object sender, EventArgs e)
        {
            Ticketsform facturaForm =  new Ticketsform();
            facturaForm.MdiParent = this;
            facturaForm.Show(); 
        }
    }
}
