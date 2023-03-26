using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entidades;
using BdDatos;

namespace Vistas
{
    public partial class usuariosform : Syncfusion.Windows.Forms.Office2010Form
    {
            public usuariosform()
            {
                InitializeComponent();
            }
            string tipooperacion = string.Empty;

           UsuarioDB usuarioDB = new UsuarioDB();
            Usuario user = new Usuario();

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            
              
                    habilitarcontoles();

                    guardarbtn.Enabled = true;
                    tipooperacion = "nuevo";



        }
            private void habilitarcontoles()
            {
                codigotxt.Enabled = true;
                nombretxt.Enabled = true;
                contrasenatxt.Enabled = true;
                correotxt.Enabled = true;
                
                adjuntarimagensbtn.Enabled = true;
                cancelrabtn.Enabled = true;



            }
            private void desabilitarcontoles()
            {
                codigotxt.Enabled = false;
                nombretxt.Enabled = false;
                contrasenatxt.Enabled = false;
                correotxt.Enabled = false;
                
                adjuntarimagensbtn.Enabled = false;


            }

           
            private void Limpiarcontoles()
            {
                codigotxt.Clear();
                nombretxt.Clear();
                contrasenatxt.Clear();
                correotxt.Clear();
                fotopictureBox2.Image = null;



            }

            

            
        private void cancelrabtn_Click_1(object sender, EventArgs e)
        {
            desabilitarcontoles();
            Limpiarcontoles();
            modificarbtn.Enabled = false;
            guardarbtn.Enabled = false;
            eliminarbtn.Enabled = false;
            cancelrabtn.Enabled = false;
        }

        private void guardarbtn_Click_1(object sender, EventArgs e)
        {
            if (tipooperacion == "nuevo")
            {
                if (string.IsNullOrEmpty(codigotxt.Text))
                {
                    errorProvider1.SetError(codigotxt, "Ingrese el Codigo");
                    codigotxt.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(nombretxt.Text))
                {
                    errorProvider1.SetError(nombretxt, "Favor ingresar el nombre");
                    nombretxt.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(contrasenatxt.Text))
                {
                    errorProvider1.SetError(contrasenatxt, "Favor ingresar su contraña");
                    contrasenatxt.Focus();
                    return;
                }
                errorProvider1.Clear();

                
                user.codigousuario = codigotxt.Text;
                user.nombre = nombretxt.Text;
                user.contrasena = contrasenatxt.Text;
                user.correo = correotxt.Text;




                if (fotopictureBox2.Image != null)
                {
                    System.IO.MemoryStream MS = new System.IO.MemoryStream();
                    fotopictureBox2.Image.Save(MS, System.Drawing.Imaging.ImageFormat.Jpeg);
                    user.Foto = MS.GetBuffer();
                }

                bool inserto = usuarioDB.insertar(user);
                if (inserto)
                {
                    MessageBox.Show("Registro Guardado");
                }
                else
                {
                    MessageBox.Show("No se pudo guardar el Registro");
                }

                // Insertar en la base de datos

            }
            else if (tipooperacion == "modificar")
            {

            }
        }

        private void modificarbtn_Click_1(object sender, EventArgs e)
        {
            tipooperacion = "modificar";
        }

        private void eliminarbtn_Click(object sender, EventArgs e)
        {

        }
        
        private void traerusuarios()
        {
            DataTable dt = new DataTable();
            dt = usuarioDB.DevolverUsuario();
            UsuariosdataGridView1.DataSource = dt;

        }

        private void usuariosform_Load(object sender, EventArgs e)
        {
            traerusuarios();
        }

        private void adjuntarimagensbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult dialogResult = dialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                fotopictureBox2.Image = Image.FromFile(dialog.FileName);
            }

        }
    }

    
}
