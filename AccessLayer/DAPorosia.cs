using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace AccessLayer
{
    public class DAPorosia
    {
        public static SqlConnection GetSQLCnn()
        {
            return new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings.Get("sqlConnection"));

        }

        public static List<Puntori> ListaPuntorve()
        {
            List<Puntori> lst = new List<Puntori>();

            SqlConnection cnn = GetSQLCnn();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "selectAllPuntoret";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            try
            {
                cnn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Puntori p = new Puntori();

                    p.Puntori_ID = int.Parse(dr["Puntori_ID"].ToString());
                    p.Emri = dr["Emri"].ToString();
                    p.Mbiemri = dr["Mbiemri"].ToString();
                    p.Gjinia = Convert.ToBoolean(dr["Gjinia"].ToString());
                    p.NumriTelefonit= dr["NumriTelefonit"].ToString();

                    lst.Add(p);

                }

            }
            catch (Exception e)
            {
            }
            finally
            {
                cnn.Close();
                cnn.Dispose();
            }

            return lst;

        }

    }
}
