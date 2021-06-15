using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialPav.Db._Entities
{
    public static class DbCb
    {
        public static DataTable ObtenerCbCategorias()
        {
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["Cad_bdd"];
            SqlConnection cn = new SqlConnection(strConnect);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Categorias";
                cmd.Parameters.Clear();
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
        public static DataTable ObtenerCbPosiciones()
        {
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["Cad_bdd"];
            SqlConnection cn = new SqlConnection(strConnect);

            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT * FROM Posiciones";
                cmd.Parameters.Clear();
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

        public static bool Transaccion(int nroEquipo, DateTime fecha ,string nombreEquipo, List lista)
        {

            string strConnect = System.Configuration.ConfigurationManager.AppSettings["Cad_bdd"];
            SqlTransaction objtrans = null; 
            SqlConnection cn = new SqlConnection(strConnect);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "INSERT INTO Equipos VALUES(@NombreEquipo,@FechaCreacion)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@NombreEquipo",nombreEquipo);
                cmd.Parameters.AddWithValue("@fechaCreacion",DateTime.Now);
  
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;
                objtrans = cn.BeginTransaction("Transaccion");
                cmd.ExecuteNonQuery();
                foreach (i in lista)
                {
                    string consultas = "INSERT INTO JugadoresPorEquipos VALUES(@IdJugador,@IdEquipo, @FechaAsignacion)";
                    cmd.Parameters.AddWithValue("@idJugador", i);
                    cmd.Parameters.AddWithValue("@idequipos",nroEquipo );
                    cmd.Parameters.AddWithValue("@FechaAsignacion", DateTime.Now);

                    cmd.CommandText = consultas;
                    cmd.ExecuteNonQuery();
                }

                objtrans.Commit();

                return true;

            }

            catch (Exception)
            {

                return -1;
            }
            finally
            {
                cn.Close();
            }

        }

    }  
}
