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
        // creating list of instances of the ProdSuppliers class
        public static List<ProdSupplier> GetProdSuppliers()
        {
            // create new list of ProdSuppliers
            List<ProdSupplier> ProdSuppliers = new List<ProdSupplier>(); // make an empty list
            ProdSupplier prodSup; // reference to new ProdSupplier object

            //
            DBCall.InitSQL();

            using (SqlConnection connection = new SqlConnection(DBCall.builder.ConnectionString))
            {
                // create select command
                string selectString = "SELECT ProductSupplierId, ps.ProductId, ps.SupplierId, ProdName, SupName " +
                    "FROM Products_Suppliers ps " +
                    "join Products p on ps.ProductId = p.ProductId " +
                    "join Suppliers s on ps.SupplierId = s.SupplierId";

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
                        prodSup.ProdName = (reader["ProdName"]).ToString();
                        prodSup.SupName = (reader["SupName"]).ToString();
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
//Helen 
//Here we will get a ProductSupplier Id and a SupId
//which will be used in the supplier combo box within add packages and then insert method later in same
        public static List<ProdSupplier> GetProdSuppliersBasedOnProductId(ProdSupplier newProductSupplier)
        {
            List<ProdSupplier> SupplierListBasedOnProd = new List<ProdSupplier>(); // make an empty list
             
            DBCall.InitSQL();
            ProdSupplier prodSupListObj;// reference to new ProdSupplier object

            using (SqlConnection connection = new SqlConnection(DBCall.builder.ConnectionString))
            {
                // create select command
                string selectString = "select ps.SupplierId, ps.ProductSupplierId from Products_Suppliers ps " +
                    "join Suppliers s on ps.SupplierId = s.SupplierId " +
                    "where ProductId = @ProductId";

                // selects records from data source based on connection and string
                SqlCommand selectCommand = new SqlCommand(selectString, connection);
                selectCommand.Parameters.AddWithValue("@ProductId", newProductSupplier.ProductId);
                try
                {
                    // open connection
                    connection.Open();
                    // run the select command and process the results
                    SqlDataReader reader = selectCommand.ExecuteReader();
                    while (reader.Read())// process next row
                    {
                        // create Prod Supplier objects to populate list
                        prodSupListObj = new ProdSupplier();
                        prodSupListObj.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                        prodSupListObj.ProductSupplierId = Convert.ToInt32(reader["ProductSupplierId"]);
                       
                        SupplierListBasedOnProd.Add(prodSupListObj);
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
                //return the list 
                return SupplierListBasedOnProd;
            }
        }

        public static ProdSupplier GetProdSuppliersOBJECT(int yolo)
        {
            // create new list of ProdSuppliers
            //List<ProdSupplier> ProdSuppliers = new List<ProdSupplier>(); // make an empty list
            ProdSupplier prodSup = null; // reference to new ProdSupplier object

            //
            DBCall.InitSQL();

            using (SqlConnection connection = new SqlConnection(DBCall.builder.ConnectionString))
            {
                // create select command
                string selectString = "SELECT ProductSupplierId, ps.ProductId, ps.SupplierId, ProdName, SupName " +
                    "FROM Products_Suppliers ps " +
                    "join Products p on ps.ProductId = p.ProductId " +
                    "join Suppliers s on ps.SupplierId = s.SupplierId " +
                    "where ProductSupplierId = @ProductSupplierId";

                // selects records from data source based on connection and string
                SqlCommand selectCommand = new SqlCommand(selectString, connection);
                selectCommand.Parameters.AddWithValue("ProductSupplierId", yolo);
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
                        prodSup.ProdName = (reader["ProdName"]).ToString();
                        prodSup.SupName = (reader["SupName"]).ToString();
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
            }
            // return list of ProdSuppliers
            return prodSup;
        }



/*Add new Product Supplier to the list
Author: Helen Lin */

        public static void AddNewProdSupplier(ProdSupplier newProductSupplier)
        //returns the auto-generated ID of the new Package
        {
            //using package db to initialize connection
            DBCall.InitSQL();

            using (SqlConnection conn = new SqlConnection(DBCall.builder.ConnectionString))
            {
                string insertStatement = "INSERT INTO Products_Suppliers(ProductId, SupplierId) VALUES(@ProductId, @SupplierId)";

                SqlCommand cmd = new SqlCommand(insertStatement, conn);

                //Takes values from the main page and puts into database
                cmd.Parameters.AddWithValue("@ProductId", newProductSupplier.ProductId);
                cmd.Parameters.AddWithValue("@SupplierId", newProductSupplier.SupplierId);


                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery(); //run DML statements

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

        //Maryam
        //Update statement Product Suppliers
        public static bool UpdateProdSupplier(ProdSupplier newProSup, ProdSupplier oldProSup)
        {
            bool ProdsSupplier = false;
            using (SqlConnection connection = new SqlConnection(DBCall.builder.ConnectionString))
            {
                string updateStatement = "UPDATE Products_Suppliers " +
                                     "SET SupplierId = @NewSupplierId, " +
                                     " ProductId = @NewProductId " +
                                     "WHERE ProductSupplierId = @OldProductSupplierId " +
                                     "AND SupplierId = @OldSupplierId " +
                                     "AND ProductId = @OldProductId ";
                SqlCommand cmd = new SqlCommand(updateStatement, connection);
                cmd.Parameters.AddWithValue("@NewSupplierId", newProSup.SupplierId);
                cmd.Parameters.AddWithValue("@NewProductId", newProSup.ProductId);
                cmd.Parameters.AddWithValue("@OldProductSupplierId", oldProSup.ProductSupplierId);
                cmd.Parameters.AddWithValue("@OldSupplierId", oldProSup.SupplierId);
                cmd.Parameters.AddWithValue("@OldProductId", oldProSup.ProductId);

                try
                {
                    connection.Open();
                    ProdsSupplier = Convert.ToBoolean(cmd.ExecuteNonQuery());
                    if (ProdsSupplier)
                        ProdsSupplier = true;
                    else
                        ProdsSupplier = false;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
                return ProdsSupplier;
            }
        }
    }
}
