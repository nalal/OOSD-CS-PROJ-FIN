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
        //Init connection
        public static SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        public static bool CSucces = false;
        public static void InitSQL()
        {
            //check connection type
            if (ConnectionPage.Local)
            {
                //get connection data
                builder.DataSource = ConnectionPage.Name;
                builder.InitialCatalog = "TravelExperts";
                builder.IntegratedSecurity = true;
                using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
                {
                    //test connection
                    try
                    {
                        conn.Open();
                        CSucces = true;
                        conn.Close();
                    }
                    catch(SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("SQL connection attempt returned error code " + ex.ErrorCode, "SQL Error");
                    }
                }
            }
            else if (!ConnectionPage.Local)
            {
                builder.DataSource = ConnectionPage.Name;
                builder.UserID = ConnectionPage.User;
                builder.Password = ConnectionPage.Pass;
                builder.InitialCatalog = "TravelExperts";
                using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
                {
                    try
                    {
                        conn.Open();
                        CSucces = true;
                        conn.Close();
                    }
                    catch (SqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("SQL connection attempt returned error code " + ex.ErrorCode, "SQL Error");
                    }
                }
            }

        }
        //Get DB Table data
        public static DataTable GetPackages()
        {
            DataTable TB = new DataTable();
            using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
            {
                string query = "select * from Packages";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(TB);
                conn.Close();
                da.Dispose();
            }
            return TB;
        }
        public static DataTable GetProducts()
        {
            DataTable TB = new DataTable();
            using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
            {
                string query = "select * from Products";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(TB);
                conn.Close();
                da.Dispose();
            }
            return TB;
        }
        public static DataTable GetPSuppliers()
        {
            DataTable TB = new DataTable();
            using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
            {
                string query = "select * from Products_suppliers";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(TB);
                conn.Close();
                da.Dispose();
            }
            return TB;
        }
        public static DataTable GetSuppliers()
        {
            DataTable TB = new DataTable();
            using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
            {
                string query = "select * from Suppliers";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(TB);
                conn.Close();
                da.Dispose();
            }
            return TB;
        }
        public static DataTable GetPPSuppliers()
        {
            DataTable TB = new DataTable();
            using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
            {
                string query = "select * from Packages_products_suppliers";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(TB);
                conn.Close();
                da.Dispose();
            }
            return TB;
        }
    }
}