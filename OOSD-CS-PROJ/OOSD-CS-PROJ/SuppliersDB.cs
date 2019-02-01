using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_CS_PROJ
{
    // class for SQL commands regarding the Suppliers class on the main view form
    class SuppliersDB
    {
        // connecting to the DB
        public static SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        public static void InitSQL()
        {
            builder.DataSource = "ELF8OOSD197691\\SQLEXPRESS";
            builder.IntegratedSecurity = true;
            builder.InitialCatalog = "TravelExperts";
        }
        // creating list of instances of the Suppliers class
        public static List<Supplier> GetSuppliers()
        {
            // create new list of Suppliers
            List<Supplier> Suppliers = new List<Supplier>(); // make an empty list
            Supplier sup; // reference to new Supplier object

            //
            InitSQL();

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                // create select command
                string selectString = "SELECT SupplierId, SupName FROM Suppliers";

                // selects records from data source based on connection and string
                SqlCommand selectCommand = new SqlCommand(selectString, connection);
                try
                {
                    // open connection
                    connection.Open();
                    // run the select command and process the results adding Suppliers to the list
                    SqlDataReader reader = selectCommand.ExecuteReader();
                    while (reader.Read())// process next row
                    {
                        // create Supplier objects to populate list
                        sup = new Supplier();
                        sup.SupplierId = Convert.ToInt32(reader["SupplierId"]);
                        sup.SupName = reader["SupName"].ToString();
                        Suppliers.Add(sup);
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
                // return list of Suppliers
                return Suppliers;
            }
        }

//this will allow user to add a new Supplier to list
        public static void AddNewSupplier(Supplier newSupplier)
        //returns the auto-generated ID of the new Package
        {
            //using package db to initialize connection
            PackageDB.InitSQL();

            using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
            {
                string insertStatement = "INSERT INTO Packages(SupplierId, SupName) VALUES(@SupplierId, @SupName)";

                SqlCommand cmd = new SqlCommand(insertStatement, conn);

                cmd.Parameters.AddWithValue("@SupplierId", newSupplier.SupplierId);

                cmd.Parameters.AddWithValue("@SupName", newSupplier.SupName);


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
