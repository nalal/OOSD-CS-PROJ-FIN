using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_CS_PROJ
{
    public static class PackageDB
    {
        //this will allow user to add a new package to list
        public static int AddNewPackage(Package newPackage)
        //returns the auto-generated ID of the new Package
        {
            //PackageId will be auto incremented once created
            int PackageId;

            DBCall.InitSQL();

            using (SqlConnection conn = new SqlConnection(DBCall.builder.ConnectionString))
            {
                string insertStatement = "INSERT INTO Packages(PkgName, PkgStartDate, PkgEndDate, PkgDesc, PkgBasePrice, PkgAgencyCommission, ProdName)" + "VALUES(@PkgName, @PkgStartDate, @PkgEndDate, @PkgDesc, @PkgBasePrice, @PkgAgencyCommission, @ProdName)";

                SqlCommand cmd = new SqlCommand(insertStatement, conn);

                cmd.Parameters.AddWithValue("@PkgName", newPackage.PkgName);

                cmd.Parameters.AddWithValue("@PkgStartDate", newPackage.PkgStartDate);

                cmd.Parameters.AddWithValue("@PkgEndDate", newPackage.PkgEndDate);

                cmd.Parameters.AddWithValue("@PkgDesc", newPackage.PkgDesc);
                cmd.Parameters.AddWithValue("@PkgBasePrice", newPackage.PkgBasePrice);
                cmd.Parameters.AddWithValue("@PkgAgencyCommission", newPackage.PkgAgencyCommission);
                cmd.Parameters.AddWithValue("@ProdName", newPackage.ProdName);


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

        //Maryam
        //Update statement for Packages
        public static bool UpdatePackage(Package newPkg, Package oldPkg)
        {
            bool Pkg = false;

            DBCall.InitSQL();

            using (SqlConnection conn = new SqlConnection(DBCall.builder.ConnectionString))
            {
                string updateStatement = "UPDATE Packages " +
                                     "SET PkgName = @NewPkgName, " +
                                     "    PkgStartDate = @NewPkgStartDate, " +
                                     "    PkgEndDate = @NewPkgEndDate, " +
                                     "    PkgDesc = @NewPkgDesc, " +
                                     "    PkgBasePrice = @NewPkgBasePrice, " +
                                     "    PkgAgencyCommission = @NewPkgAgencyCommission " +
                                     "WHERE PackageId = @OldPackageId " +
                "AND PkgName = @OldPkgName " +
                "AND PkgStartDate = @OldPkgStartDate " +
                "AND PkgEndDate = @OldPkgEndDate " +
                "AND PkgDesc = @OldPkgDesc " +
                "AND PkgBasePrice = @OldPkgBasePrice " +
                "AND PkgAgencyCommission = @OldPkgAgencyCommission";
                SqlCommand cmd = new SqlCommand(updateStatement, conn);
                cmd.Parameters.AddWithValue("@NewPkgName", newPkg.PkgName);
                cmd.Parameters.AddWithValue("@NewPkgStartDate", newPkg.PkgStartDate);
                cmd.Parameters.AddWithValue("@NewPkgEndDate", newPkg.PkgEndDate);
                cmd.Parameters.AddWithValue("@NewPkgDesc", newPkg.PkgDesc);
                cmd.Parameters.AddWithValue("@NewPkgBasePrice", newPkg.PkgBasePrice);
                cmd.Parameters.AddWithValue("@NewPkgAgencyCommission", newPkg.PkgAgencyCommission);
                cmd.Parameters.AddWithValue("@OldPackageId", oldPkg.PackageId);
                cmd.Parameters.AddWithValue("@OldPkgName", oldPkg.PkgName);
                cmd.Parameters.AddWithValue("@OldPkgStartDate", oldPkg.PkgStartDate);
                cmd.Parameters.AddWithValue("@OldPkgEndDate", oldPkg.PkgEndDate);
                cmd.Parameters.AddWithValue("@OldPkgDesc", oldPkg.PkgDesc);
                cmd.Parameters.AddWithValue("@OldPkgBasePrice", oldPkg.PkgBasePrice);
                cmd.Parameters.AddWithValue("@OldPkgAgencyCommission", oldPkg.PkgAgencyCommission);
                try
                {
                    conn.Open();
                    Pkg = Convert.ToBoolean(cmd.ExecuteNonQuery());
                    if (Pkg)
                        Pkg = true;
                    else
                        Pkg = false;
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
            return Pkg;
        }

        public static bool DeletePackage(Package package)
        {
            SqlConnection conn = new SqlConnection(DBCall.builder.ConnectionString);
            string deleteStatement =
                "DELETE FROM Packages "
                + "WHERE PackageId = @PackageId "
                + "AND PkgName = @PkgName "
                + "AND PkgStartDate = @PkgStartDate "
                + "AND PkgEndDate = @PkgEndDate "
                + "AND PkgDesc = @PkgDesc "
                + "AND PkgBasePrice = @PkgBasePrice "
                + "AND PkgAgencyCommission = @PkgAgencyCommission";

            SqlCommand deleteCommand = new SqlCommand(deleteStatement, conn);
            deleteCommand.Parameters.AddWithValue("@PackageId", package.PackageId);
            deleteCommand.Parameters.AddWithValue("@PkgName", package.PkgName);
            deleteCommand.Parameters.AddWithValue("@PkgStartDate", package.PkgStartDate);
            deleteCommand.Parameters.AddWithValue("@PkgEndDate", package.PkgEndDate);
            deleteCommand.Parameters.AddWithValue("@PkgDesc", package.PkgDesc);
            deleteCommand.Parameters.AddWithValue("@PkgBasePrice", package.PkgBasePrice);
            deleteCommand.Parameters.AddWithValue("@PkgAgencyCommission", package.PkgAgencyCommission);
            try
            {
                conn.Open();
                int count = deleteCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
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
