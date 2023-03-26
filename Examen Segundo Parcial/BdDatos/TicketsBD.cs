using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Entidades;
using MySql.Data.MySqlClient;

namespace BdDatos
{
    public class TicketsBD
    {
        string cadena = "server=localhost; User=root; database=factura; password=123456";
        public bool guardar(Tickets tickets)
        {
            bool inserto = false;
            int idFactura= 0;

            try
            {
                StringBuilder sqlTickets = new StringBuilder();
                sqlTickets.Append("INSERT INTO Tickets VALUES ( @Fecha, @Usuario,@IdentidadCliente,@CodigoUsuario,@TipodeSoporte,@TipodeSoporte, @DescripciondeRespuesta, @Precio, @impuesto, @Descuento,@Total)");
                sqlTickets.Append("SELECT LAST_INSERT_id();");

                using (MySqlConnection  con= new MySqlConnection(cadena))
                {
                    con.Open();
                    MySqlTransaction tran = con.BeginTransaction((System.Data.IsolationLevel)System.Data.IsolationLevel.ReadCommitted);
                    using (MySqlCommand cmd = new MySqlCommand(sqlTickets.ToString(), con, tran)) 
                    {
                        //cmd.CommandType = System.Data.CommandType.Text;
                        //cmd.Parameters.Add("@Fecha", MySqlDbType.Datetime).Value = tickets
                    }
                    //cmd.CommandType = System.Data.CommandType.Text;
                    //cmd.Parameters.Add("@Fecha",MySqlDbType.Datetime).Value = tickets



                }
            }
            catch (System.Exception)
            {
            }
            return inserto;
        }
    }
}
