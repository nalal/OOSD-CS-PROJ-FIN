using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TravelExpertsASP;

namespace TravelExpertsASP.Models
{
    [DataObject(true)]
    public class CustomersDB
    {

        [DataObjectMethod(DataObjectMethodType.Insert)]
        //insert customer record into Travel ExpertsDB

        public static Customer CreateCustomer(Customer cust)
        {
            // initialize connection 
            SqlConnection conn = TravelExperts1DB.GetConnection();

            // creation of database INSERT method string
            string insertString = "INSERT INTO Customers " +
                                    "(CustFirstName, CustLastName, CustAddress, CustCity, " +
                                    "CustProv, CustPostal, CustCountry, CustHomePhone, " +
                                    "CustBusPhone, CustEmail, CustUserName, CustPassword) " +
                                    "VALUES(@CustFirstName, @CustLastName, @CustAddress, @CustCity, " +
                                    "@CustProv, @CustPostal, @CustCountry, @CustHomePhone, " +
                                    "@CustBusPhone, @CustEmail, @CustUserName, @CustPassword)";

            SqlCommand insertCommand = new SqlCommand(insertString, conn);
            insertCommand.Parameters.AddWithValue("@CustFirstName", cust.CustFirstName);
            insertCommand.Parameters.AddWithValue("@CustLastName", cust.CustLastName);
            insertCommand.Parameters.AddWithValue("@CustAddress", cust.CustAddress);
            insertCommand.Parameters.AddWithValue("@CustCity", cust.CustCity);
            insertCommand.Parameters.AddWithValue("@CustProv", cust.CustProv);
            insertCommand.Parameters.AddWithValue("@CustPostal", cust.CustPostal);
            insertCommand.Parameters.AddWithValue("@CustCountry", cust.CustCountry);
            insertCommand.Parameters.AddWithValue("@CustHomePhone", cust.CustHomePhone);
            insertCommand.Parameters.AddWithValue("@CustBusPhone", cust.CustBusPhone);
            insertCommand.Parameters.AddWithValue("@CustEmail", cust.CustEmail);
            insertCommand.Parameters.AddWithValue("@CustUserName", cust.CustUserName);
            insertCommand.Parameters.AddWithValue("@CustPassword", cust.CustPassword);

            try
            {
                // open connection 
                conn.Open();

                //integer returned by the INSERT SQL command
                int insertSuccess = insertCommand.ExecuteNonQuery();
                if (insertSuccess == 1) // insert successful {
                {

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return cust;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]

        public static Customer GetCustomerByUserName(string custUserName)
        {
            Customer cust = null;

            // initialize connection 
            SqlConnection conn = TravelExperts1DB.GetConnection();

            string selectString = "SELECT CustomerId, CustFirstName, CustLastName, CustAddress, CustCity, " +
                                  "CustProv, CustPostal, CustCountry, CustHomePhone, CustBusPhone, CustEmail, " +
                                  "CustUserName, CustPassword FROM Customers WHERE CustUserName = @CustUserName";

            SqlCommand getCustomer = new SqlCommand(selectString, conn);
            getCustomer.Parameters.AddWithValue("@CustUserName", custUserName);

            try
            {
                conn.Open(); // create connection
                SqlDataReader myReader = getCustomer.ExecuteReader();

                while (myReader.Read()) // if the user name matches a customer in the database 
                {
                    // create customer object based on database information of the matching user name
                    cust = new Customer();
                    cust.CustomerId = Convert.ToInt32(myReader["CustomerId"]);
                    cust.CustFirstName = myReader["CustFirstName"].ToString();
                    cust.CustLastName = myReader["CustLastName"].ToString();
                    cust.CustAddress = myReader["CustAddress"].ToString();
                    cust.CustCity = myReader["CustCity"].ToString();
                    cust.CustProv = myReader["CustProv"].ToString();
                    cust.CustPostal = myReader["CustPostal"].ToString();
                    cust.CustCountry = myReader["CustCountry"].ToString();
                    cust.CustHomePhone = myReader["CustHomePhone"].ToString();
                    cust.CustBusPhone = myReader["CustBusPhone"].ToString();
                    cust.CustEmail = myReader["CustEmail"].ToString();
                    cust.CustUserName = myReader["CustUserName"].ToString();
                    cust.CustPassword = myReader["CustPassword"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close(); // close connection
            }
            return cust; // return instance of customer
        }


        //[DataObjectMethod(DataObjectMethodType.Update)]

        //public static Customer UpdateCustomer(Customer old_cust, Customer cust)
        //{
        //    // initialize connection 
        //    SqlConnection conn = TravelExperts1DB.GetConnection();

        //    // creation of database INSERT method string
        //    string updateString = "INSERT INTO Customers " +
        //                            "(CustFirstName, CustLastName, CustAddress, CustCity, " +
        //                            "CustProv, CustPostal, CustCountry, CustHomePhone, " +
        //                            "CustBusPhone, CustEmail, CustUserName, CustPassword) " +
        //                            "VALUES(@CustFirstName, @CustLastName, @CustAddress, @CustCity, " +
        //                            "@CustProv, @CustPostal, @CustCountry, @CustHomePhone, " +
        //                            "@CustBusPhone, @CustEmail, @CustUserName, @CustPassword)";

        //    SqlCommand insertCommand = new SqlCommand(insertString, conn);
        //    insertCommand.Parameters.AddWithValue("@CustFirstName", cust.CustFirstName);
        //    insertCommand.Parameters.AddWithValue("@CustLastName", cust.CustLastName);
        //    insertCommand.Parameters.AddWithValue("@CustAddress", cust.CustAddress);
        //    insertCommand.Parameters.AddWithValue("@CustCity", cust.CustCity);
        //    insertCommand.Parameters.AddWithValue("@CustProv", cust.CustProv);
        //    insertCommand.Parameters.AddWithValue("@CustPostal", cust.CustPostal);
        //    insertCommand.Parameters.AddWithValue("@CustCountry", cust.CustCountry);
        //    insertCommand.Parameters.AddWithValue("@CustHomePhone", cust.CustHomePhone);
        //    insertCommand.Parameters.AddWithValue("@CustBusPhone", cust.CustBusPhone);
        //    insertCommand.Parameters.AddWithValue("@CustEmail", cust.CustEmail);
        //    insertCommand.Parameters.AddWithValue("@CustUserName", cust.CustUserName);
        //    insertCommand.Parameters.AddWithValue("@CustPassword", cust.CustPassword);

        //    try
        //    {
        //        // open connection 
        //        conn.Open();

        //        //integer returned by the INSERT SQL command
        //        int insertSuccess = insertCommand.ExecuteNonQuery();
        //        if (insertSuccess == 1) // insert successful {
        //        {

        //        }


        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return cust;
        //}
    }
}