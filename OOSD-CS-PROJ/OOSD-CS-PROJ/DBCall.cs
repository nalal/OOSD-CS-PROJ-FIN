using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace OOSD_CS_PROJ
{
    class DBCall
    {
        public static DataTable TB = new DataTable();
        public static void SQL()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "10.163.37.67";   // update me
            builder.UserID = "sa";              // update me
            builder.Password = "N1o2a3h4!"; // update me
            builder.InitialCatalog = "TravelExperts";
            using(SqlConnection conn = new SqlConnection(builder.ConnectionString))
            {
                string query = "select * from Packages";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(TB);
                conn.Close();
                da.Dispose();
            }
        }
    }
}
