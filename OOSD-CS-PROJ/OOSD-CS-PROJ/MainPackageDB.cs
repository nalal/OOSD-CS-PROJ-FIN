using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_CS_PROJ
{
    // class for SQL commands regarding the Packages class on the main viewing form
    class MainPackageDB
    {
        // connecting to the DB
        public static SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        public static void InitSQL()
        {
            builder.DataSource = "ELF8OOSD197691\\SQLEXPRESS";
            builder.IntegratedSecurity = true;
            builder.InitialCatalog = "TravelExperts";
        }
        // creating list of instances of the Package class
        public static List<Package> GetPackages()
        {
            // create new list of Packages
            List<Package> Packagess = new List<Package>(); // make an empty list
            Package pkg; // reference to new Package object

            //z
           InitSQL();

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                // create select command
                string selectString = "SELECT PackageID, PkgName, PkgStartDate, PkgEndDate, " +
                                      "PkgDesc, PkgBasePrice, PkgAgencyCommission FROM Packages";
                                  
                // selects records from data source based on connection and string
                SqlCommand selectCommand = new SqlCommand(selectString, connection);
                try
                {
                    // open connection
                    connection.Open();
                    // run the select command and process the results adding Packages to the list
                    SqlDataReader reader = selectCommand.ExecuteReader();
                    while (reader.Read())// process next row
                    {
                        // create Package objects to populate list
                        pkg = new Package();
                        pkg.PackageID = Convert.ToInt32(reader["PackageID"]);
                        pkg.PkgName = reader["PkgName"].ToString();
                        pkg.PkgStartDate = reader["PkgStartDate"].ToString();
                        pkg.PkgEndDate = reader["PkgEndDate"].ToString();
                        pkg.PkgDesc = reader["PkgDesc"].ToString();
                        pkg.PkgBasePrice = Convert.ToDecimal(reader["PkgBasePrice"]);
                        pkg.PkgAgencyCommission = Convert.ToDecimal(reader["PkgAgencyCommission"]);
                        Packagess.Add(pkg);
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
                // return list of Packages
                return Packagess;
            }
        }
    }
}
