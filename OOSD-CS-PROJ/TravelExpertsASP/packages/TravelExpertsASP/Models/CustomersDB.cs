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
        [DataObjectMethod(DataObjectMethodType.Select)]

        public static List<string> GetUserNames()
        {
            List<string> list = new List<string>();
            string username;

            // initialize connection 
            SqlConnection conn = TravelExperts1DB.GetConnection();

            string selectString = "SELECT CustUserName FROM Customers";

            SqlCommand getCustomer = new SqlCommand(selectString, conn);

            try
            {
                conn.Open(); // create connection
                SqlDataReader myReader = getCustomer.ExecuteReader();

                while (myReader.Read()) // if the user name matches a customer in the database 
                {
                    // create customer object based on database information of the matching user name
                    username = null;
                    username = myReader["CustUserName"].ToString();
                    list.Add(username);
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
            return list; // return instance of customer
        }


        [DataObjectMethod(DataObjectMethodType.Insert)]
        //insert customer record into Travel ExpertsDB

        public static bool CreateCustomer(Customer cust)
        {
            bool inserted = false;
            // initialize connection 
            SqlConnection conn = TravelExperts1DB.GetConnection();

            // creation of database INSERT method string
            string insertString =   "IF NOT EXISTS (SELECT * FROM Customers WHERE CustUserName = @CustUserName) " +
                                    "INSERT INTO Customers " +
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

                inserted = Convert.ToBoolean(insertCommand.ExecuteNonQuery());

                ////integer returned by the INSERT SQL command
                //int insertSuccess = insertCommand.ExecuteNonQuery();
                //if (insertSuccess == 1) // insert successful {
                //{

                //}
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return inserted;
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


        [DataObjectMethod(DataObjectMethodType.Update)]

        public static bool  UpdateCustomer(Customer Ocust, Customer cust)
        {
            bool updsuccessful = true; // flag for successful update
            // initialize connection 
            SqlConnection conn = TravelExperts1DB.GetConnection();

            // creation of database INSERT method string
            string updString = "UPDATE Customers SET CustFirstName = @NCustFirstName, CustLastName = @NCustLastName, " +
                                    "CustAddress = @NCustAddress, CustCity = @NCustCity, CustProv = @NCustProv, " +
                                    "CustPostal = @NCustPostal, CustCountry = @NCustCountry, CustHomePhone = @NCustHomePhone, " +
                                    "CustBusPhone = @NCustBusPhone, CustEmail = @NCustEmail, CustUserName = @NCustUserName, " +
                                    "CustPassword = @NCustPassword WHERE CustFirstName = @OCustFirstName AND " +
                                    "CustLastName = @OCustLastName AND CustPostal = @OCustPostal AND CustCountry = @OCustCountry " +
                                    "AND CustHomePhone = @OCustHomePhone AND CustBusPhone = @OCustBusPhone AND " +
                                    "CustEmail = @OCustEmail AND CustUserName = @OCustUserName AND CustPassword = @OCustPassword";
            

            SqlCommand updCommand = new SqlCommand(updString, conn);

            updCommand.Parameters.AddWithValue("@OCustFirstName", Ocust.CustFirstName);
            updCommand.Parameters.AddWithValue("@OCustLastName", Ocust.CustLastName);
            updCommand.Parameters.AddWithValue("@OCustAddress", Ocust.CustAddress);
            updCommand.Parameters.AddWithValue("@OCustCity", Ocust.CustCity);
            updCommand.Parameters.AddWithValue("@OCustProv", Ocust.CustProv);
            updCommand.Parameters.AddWithValue("@OCustPostal", Ocust.CustPostal);
            updCommand.Parameters.AddWithValue("@OCustCountry", Ocust.CustCountry);
            updCommand.Parameters.AddWithValue("@OCustHomePhone", Ocust.CustHomePhone);
            updCommand.Parameters.AddWithValue("@OCustBusPhone", Ocust.CustBusPhone);
            updCommand.Parameters.AddWithValue("@OCustEmail", Ocust.CustEmail);
            updCommand.Parameters.AddWithValue("@OCustUserName", Ocust.CustUserName);
            updCommand.Parameters.AddWithValue("@OCustPassword", Ocust.CustPassword);



            updCommand.Parameters.AddWithValue("@NCustFirstName", cust.CustFirstName);
            updCommand.Parameters.AddWithValue("@NCustLastName", cust.CustLastName);
            updCommand.Parameters.AddWithValue("@NCustAddress", cust.CustAddress);
            updCommand.Parameters.AddWithValue("@NCustCity", cust.CustCity);
            updCommand.Parameters.AddWithValue("@NCustProv", cust.CustProv);
            updCommand.Parameters.AddWithValue("@NCustPostal", cust.CustPostal);
            updCommand.Parameters.AddWithValue("@NCustCountry", cust.CustCountry);
            updCommand.Parameters.AddWithValue("@NCustHomePhone", cust.CustHomePhone);
            updCommand.Parameters.AddWithValue("@NCustBusPhone", cust.CustBusPhone);
            updCommand.Parameters.AddWithValue("@NCustEmail", cust.CustEmail);
            updCommand.Parameters.AddWithValue("@NCustUserName", cust.CustUserName);
            updCommand.Parameters.AddWithValue("@NCustPassword", cust.CustPassword);

            try
            {
                // open connection 
                conn.Open();

                //integer returned by the UPDATE SQL command
                int updSuccess = updCommand.ExecuteNonQuery();
                if (updSuccess == 1) // update successful {
                {
                    updsuccessful = true;
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
            return updsuccessful;
        }
    }
}