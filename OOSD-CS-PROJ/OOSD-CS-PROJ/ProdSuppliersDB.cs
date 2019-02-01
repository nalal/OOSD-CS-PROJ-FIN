using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_CS_PROJ
{
    // class for SQL commands regarding the ProdSuppliers class on the main view form
    class ProdSuppliersDB
    {
        // connecting to the DB
        public static SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        public static void InitSQL()
        {
            builder.DataSource = "ELF8OOSD197691\\SQLEXPRESS";
            builder.IntegratedSecurity = true;
            builder.InitialCatalog = "TravelExperts";
        }

        // creating list of instances of the ProdSuppliers class
        public static List<ProdSupplier> GetProdSuppliers()
        {
            // create new list of ProdSuppliers
            List<ProdSupplier> ProdSuppliers = new List<ProdSupplier>(); // make an empty list
            ProdSupplier prodSup; // reference to new ProdSupplier object

            //
            InitSQL();

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                // create select command
                string selectString = "SELECT ProductSupplierId, ProductId, SupplierId FROM Products_Suppliers";

                // selects records from data source based on connection and string
                SqlCommand selectCommand = new SqlCommand(selectString, connection);
                try
                {
                    // open connection
                    connection.Open();
                    // run the select command and process the results adding ProdSuppliers to the list
                    SqlDataReader reader = selectCommand.ExecuteReader();
                    while (reader.Read())// process next row
                    {
                        // create ProdSupplier objects to populate list
                        prodSup = new ProdSupplier();
                        prodSup.ProductSupplierId = Convert.ToInt32(reader["ProductSupplierId"]);
                        prodSup.ProductId = Convert.ToInt32(reader["ProductId"]);
                        prodSup.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                        ProdSuppliers.Add(prodSup);
                    }
                    reader.Close();
                }
                // general exception
                catch (Exception ex)
                {
                    throw ex; // throw it to the form to handle
                }
                finally
                {
                    connection.Close();
                }
                // return list of ProdSuppliers
                return ProdSuppliers;
            }
        }
/*Add new Product Supplier to the list
Author: Helen Lin */

        public static void AddNewProdSupplier(ProdSupplier newProductSupplier)
        //returns the auto-generated ID of the new Package
        {
            //using package db to initialize connection
            PackageDB.InitSQL();

            using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
            {
                string insertStatement = "INSERT INTO Packages(ProductSupplierId, ProductId, SupplierId) VALUES(@ProductSupplierId, @ProductId, @SupplierId)";

                SqlCommand cmd = new SqlCommand(insertStatement, conn);

                cmd.Parameters.AddWithValue("@PkgName", newProductSupplier.ProductSupplierId);
                cmd.Parameters.AddWithValue("@PkgStartDate", newProductSupplier.ProductId);
                cmd.Parameters.AddWithValue("@PkgStartDate", newProductSupplier.SupplierId);


                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery(); //run DML statements

                    SqlCommand selectCommand = new SqlCommand(insertStatement, conn);
                    selectCommand.ExecuteScalar(); //selects one value

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

        }
    }
}
