using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_CS_PROJ
{//Author: Helen Lin
    public class PackageDB
    {
        public static SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        public static void InitSQL()
        {
            builder.DataSource = "localhost";
            builder.UserID = "sa";
            builder.Password = "PASSWORD";
            builder.InitialCatalog = "TravelExperts";
        }
        //this will allow user to add a new package to list
        public static int AddNewPackage(Package newPackage)
            //returns the auto-generated ID of the new Package
        {
            //PackageID will be auto incremented once created
            int PackageId;
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "ELF8OOSD197691\\SQLEXPRESS";   // update me
            //builder.UserID = "sa";              // update me
            //builder.Password = "OOSD1234"; // update me
            builder.IntegratedSecurity = true;
            builder.InitialCatalog = "TravelExperts";
            using (SqlConnection conn = new SqlConnection(builder.ConnectionString))
            {
                string insertStatement = "INSERT INTO Packages(PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission)" + "VALUES(@PkgName, @PkgStartDate, @PkgEndDate, @PkgDesc, @PkgBasePrice, @PkgAgencyCommission)";

                SqlCommand cmd = new SqlCommand(insertStatement, conn);

                cmd.Parameters.AddWithValue("@PkgName", newPackage.PkgName);
                cmd.Parameters.AddWithValue("@PkgStartDate", newPackage.PkgStartDate);
                cmd.Parameters.AddWithValue("@PkgEndDate", newPackage.PkgEndDate);
                cmd.Parameters.AddWithValue("@PkgDesc", newPackage.PkgDesc);
                cmd.Parameters.AddWithValue("@PkgBasePrice", newPackage.PkgBasePrice);
                cmd.Parameters.AddWithValue("@PkgAgencyCommission", newPackage.PkgAgencyCommission);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery(); //run DML statements
                    //retrieve generated ID
                    string selectQuery = "SELECT IDENT_CURRENT('Packages') FROM Packages"; //gets current ID
                    SqlCommand selectCommand = new SqlCommand(selectQuery, conn);
                    selectCommand.ExecuteScalar(); //selects one value
                    PackageId = Convert.ToInt32(selectCommand.ExecuteScalar()); //selects one value   Note that typecasting Int does not work!
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
                return PackageId;
            }

        }
    }
}
