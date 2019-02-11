using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_CS_PROJ
{
//Chad
//class for SQL commands regarding the Products class on the main view form
    class ProductsDB
    {
        // creating list of instances of the ProdSuppliers class
        public static List<Product> GetProducts()
        {
            // create new list of Products
            List<Product> Products = new List<Product>(); // make an empty list
            Product prod; // reference to new Product object

            //
            DBCall.InitSQL();

            using (SqlConnection connection = new SqlConnection(DBCall.builder.ConnectionString))
            {
                // create select command
                string selectString = "SELECT ProductId, ProdName FROM Products";

                // selects records from data source based on connection and string
                SqlCommand selectCommand = new SqlCommand(selectString, connection);
                try
                {
                    // open connection
                    connection.Open();
                    // run the select command and process the results adding Products to the list
                    SqlDataReader reader = selectCommand.ExecuteReader();
                    while (reader.Read())// process next row
                    {
                        // create Product objects to populate list
                        prod = new Product();
                        prod.ProductId = Convert.ToInt32(reader["ProductId"]);
                        prod.ProdName = reader["ProdName"].ToString();
                        Products.Add(prod);
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
                // return list of Products
                return Products;
            }
        }
//Helen Lin
//Adding a new product to database
        public static void AddNewProduct(Product newProduct)
        //returns the auto-generated ID of the new Package
        {
            DBCall.InitSQL(); //use the database connection from PackageDB

            using (SqlConnection conn = new SqlConnection(DBCall.builder.ConnectionString))
            {
                string insertStatement = "INSERT INTO Products(ProdName)" + "VALUES(@ProdName)";

                SqlCommand cmd = new SqlCommand(insertStatement, conn);

                cmd.Parameters.AddWithValue("@ProdName", newProduct.ProdName);

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
//Update statement for Products
        public static bool UpdateProducts(Product newProd, Product oldProd)
        {
            bool Product = false;
            using (SqlConnection connection = new SqlConnection(DBCall.builder.ConnectionString))
            {
                string updateProducts = "UPDATE Products " +
                                     "SET ProdName = @NewProdName " +
                                     "WHERE ProductId = @OldProductId " +
                                     "AND ProdName = @OldProdName ";
                SqlCommand cmd = new SqlCommand(updateProducts, connection);

                cmd.Parameters.AddWithValue("@NewProdName", newProd.ProdName);
                cmd.Parameters.AddWithValue("@OldProductId", oldProd.ProductId);
                cmd.Parameters.AddWithValue("@OldProdName", oldProd.ProdName);
                try
                {
                    connection.Open();
                    Product = Convert.ToBoolean(cmd.ExecuteNonQuery());
                    if (Product)
                        Product = true;
                    else
                        Product = false;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }
            }
            return Product;
        }
    }
}
