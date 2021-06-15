using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace ParcialPav.Db._Entities
{
    public class DbEquipos
    {


        public static int ObtenerCantidadquipos()
        {
            
            string strConnect = System.Configuration.ConfigurationManager.AppSettings["Cad_bdd"];
            SqlConnection cn = new SqlConnection(strConnect);
            try
            {
                SqlCommand cmd = new SqlCommand();
                string consulta = "SELECT MAX(Id) FROM Equipos";
                cmd.Parameters.Clear();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = consulta;

                cn.Open();
                cmd.Connection = cn;

                int rta = (int)cmd.ExecuteScalar();

                return rta;
            }

            catch (Exception)
            {

                return 0;
            }
            finally
            {
                cn.Close();
            }

        }


    }
}
