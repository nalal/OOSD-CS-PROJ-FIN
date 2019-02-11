using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_CS_PROJ
{
    //author: Helen Lin
    class PackagesProductSuppliersDB
    {

        public static int InsertPackagesProductSuppliers(PackagesProductSuppliers newPackagesProductSuppliers)
    
        {
            int yay = 0;
            //using package db to initialize connection
            DBCall.InitSQL();

            using (SqlConnection conn = new SqlConnection(DBCall.builder.ConnectionString))
            {
                string insertStatement = "INSERT INTO Packages_Products_Suppliers(PackageId, ProductSupplierId) VALUES(@PackageId, @ProductSupplierId)";

                SqlCommand cmd = new SqlCommand(insertStatement, conn);

                //Takes values from the main page and puts into database
                cmd.Parameters.AddWithValue("@PackageId", newPackagesProductSuppliers.PackageId);
                cmd.Parameters.AddWithValue("@ProductSupplierId", newPackagesProductSuppliers.ProductSupplierId);


                try
                {
                    conn.Open();
                    yay= cmd.ExecuteNonQuery(); //run DML statements

                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }

            }
            return yay;

        }
    }
}
