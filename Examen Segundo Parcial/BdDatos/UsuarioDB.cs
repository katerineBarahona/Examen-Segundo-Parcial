using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System. Data;

namespace BdDatos
{
    public class UsuarioDB
    {

        string cadena = "server=localhost; User=root; database=factura; password=123456";

        public Usuario Autenticar(Login login)
        {
            Usuario user = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM usuario WHERE CodigoUsuario =  @CodigoUsuario AND Contrasena = @Contrasena;");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {

                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;

                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = login.codigousuario;
                        comando.Parameters.Add("@Contrasena", MySqlDbType.VarChar, 50).Value = login.contrasena;

                        MySqlDataReader dr = comando.ExecuteReader();
                        if (dr.Read())
                        {
                            user = new Usuario();
                            user.codigousuario = dr["CodigoUsuario"].ToString();
                            user.nombre = dr["Nombre"].ToString();
                            user.contrasena = dr["Contrasena"].ToString();
                            user.correo = dr["Correo"].ToString();

                            user.Foto = (byte[])dr["Foto "];

                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
            }
            return user;
        }

        public bool insertar(Usuario user)

        {
            bool inserto = false;
             
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("INSERT INTO usuario VALUES ");
                sql.Append("(@CodigoUsuario, @Nombre, @Contrasena, @Correo, @Foto);");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {

                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                       

                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = user.codigousuario;
                        comando.Parameters.Add("@Contrasena", MySqlDbType.VarChar, 80).Value = user.contrasena;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 45).Value = user.nombre;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = user.correo;
                        comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = user.Foto;

                        comando.ExecuteNonQuery();
                        inserto = true;


                         
                    }
                }
            }

            catch (Exception ex )
            {

            }
            return inserto;
        }

        public bool Editar(Usuario user)
        {
            bool edito = false;
            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append("UPDATE usuario SET (Nombre =  @Nombre,Contrasena =  @Contrasena,Correo =  Correo, Fotp =  @Foto);");
                sql.Append("WHERE CodigoUsuario =@CodigoUsuario ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {

                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;

                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = user.codigousuario;
                        comando.Parameters.Add("@Contrasena", MySqlDbType.VarChar, 50).Value = user.contrasena;
                        comando.Parameters.Add("@Nombre", MySqlDbType.VarChar, 45).Value = user.nombre;
                        comando.Parameters.Add("@Correo", MySqlDbType.VarChar, 45).Value = user.correo;
                        comando.Parameters.Add("@Foto", MySqlDbType.LongBlob).Value = user.Foto;

                        comando.ExecuteNonQuery();
                        edito = true;



                    }

                }

            }

            catch (Exception)
            {
            }
            return edito;
        }

        public bool Eliminar(string codigoUsuario)
        {

            bool elimino = false;
            try
            {

                StringBuilder sql = new StringBuilder();
                sql.Append("DELETE * FROM usuario");
                sql.Append("WHERE CodigoUsuario =@CodigoUsuario ");

                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {

                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@CodigoUsuario", MySqlDbType.VarChar, 50).Value = codigoUsuario;
                        comando.ExecuteNonQuery();
                        elimino = true;
                    }
                }

            }
            catch (Exception)
            {
            }
            return elimino;
        }

        public DataTable DevolverUsuario()
        {
            DataTable datatable = new DataTable();

            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT* FROM usuario");
                using (MySqlConnection _conexion = new MySqlConnection(cadena))
                {
                    _conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        MySqlDataReader dr = comando.ExecuteReader();
                        datatable.Load(dr);



                    }
                }

            }
            catch (Exception ex)
            {

            }
            return datatable;
        }
    }
}
