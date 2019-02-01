using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_CS_PROJ
{
    // class for SQL commands regarding the Products class on the main view form
    class ProductsDB
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
        public static List<Product> GetProducts()
        {
            // create new list of Products
            List<Product> Products = new List<Product>(); // make an empty list
            Product prod; // reference to new Product object

            //
            InitSQL();

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
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
        public static void AddNewProduct(Product newProduct)
        //returns the auto-generated ID of the new Package
        {
            PackageDB.InitSQL(); //use the database connection from PackageDB

            using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
            {
                string insertStatement = "INSERT INTO Products(ProductId, ProdName)" + "VALUES(@ProductId, @ProdName)";

                SqlCommand cmd = new SqlCommand(insertStatement, conn);

                cmd.Parameters.AddWithValue("@ProductId", newProduct.ProductId);

                cmd.Parameters.AddWithValue("@ProdName", newProduct.ProdName);

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
