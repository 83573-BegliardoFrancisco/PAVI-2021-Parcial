using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPav.Db._Entities
{
    class Jugador
    {

        public static DataTable ObtenerJugadoresxid(int jugador)
        {
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["Cad_bdd"];
            SqlConnection cn = new SqlConnection(strConnect);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Jugadores WHERE Id=@IdJugador";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue('@IdJuagdor', jugador);
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                DataTable table = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(table);

                return table;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
