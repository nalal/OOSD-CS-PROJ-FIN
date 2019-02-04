using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TravelExpertsASP;

namespace TravelExpertsASP.Models
{
    [DataObject(true)]
    public class PurchasedItemsDB
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static List<PurchasedItem> PurchasedItemsByCustomer(string custUserName)
        {
            // initialize connection 
            SqlConnection conn = TravelExperts1DB.GetConnection();

            List<PurchasedItem> purchasedItems = new List<PurchasedItem>();

            string selectString = "SELECT BookingDetails.Destination, BookingDetails.[Description], " +
                                  "Products.ProdName, BookingDetails.TripStart, BookingDetails.TripEnd, Bookings.TravelerCount, " +
                                  "Bookings.BookingId, Bookings.BookingDate, TripTypes.TTName, Classes.ClassName, " +
                                   "BookingDetails.BasePrice, Fees.FeeAmt " +
                                   "FROM Customers " +
                                   "JOIN Bookings " +
                                       "ON Customers.CustomerId = Bookings.CustomerId " +
                                   "JOIN BookingDetails " +
                                       "ON Bookings.BookingId = BookingDetails.BookingId " +
                                   "JOIN TripTypes " +
                                        "ON Bookings.TripTypeId = TripTypes.TripTypeId " +
                                   "JOIN Classes " +
                                       "ON BookingDetails.ClassId = Classes.ClassId " +
                                   "JOIN Fees " +
                                       "ON BookingDetails.FeeId = Fees.FeeId " +
                                   "JOIN Products_Suppliers " +
                                       "ON BookingDetails.ProductSupplierId = Products_Suppliers.ProductSupplierId " +
                                   "JOIN Products " +
                                       "ON Products_Suppliers.ProductId = Products.ProductId " +
                                   "WHERE CustUserName = @CustUserName";

            SqlCommand getPurchasedItems = new SqlCommand(selectString, conn);
            getPurchasedItems.Parameters.AddWithValue("@CustUserName", custUserName);

            try
            {
                conn.Open(); // create connection
                SqlDataReader myReader = getPurchasedItems.ExecuteReader();

                while (myReader.Read()) // if the user name matches a customer in the database 
                {
                    // create purchItem object based on database information of the matching user name
                    PurchasedItem purchItem = new PurchasedItem();
                    purchItem.Destination = myReader["Destination"].ToString();
                    purchItem.Description = myReader["Description"].ToString();
                    purchItem.ProdName  = myReader["ProdName"].ToString();
                    purchItem.TripStart = Convert.ToDateTime(myReader["TripStart"]);
                    purchItem.TripEnd = Convert.ToDateTime(myReader["TripEnd"]);
                    purchItem.TravelerCount = Convert.ToInt32(myReader["TravelerCount"]);
                    purchItem.BookingId = Convert.ToInt32(myReader["BookingId"]);
                    purchItem.BookingDate = Convert.ToDateTime(myReader["BookingDate"]);
                    purchItem.TTName = myReader["TTName"].ToString();
                    purchItem.ClassName = myReader["ClassName"].ToString();
                    purchItem.BasePrice = Convert.ToDecimal(myReader["BasePrice"]);
                    purchItem.FeeAmt = Convert.ToDecimal(myReader["FeeAmt"]);
                    purchasedItems.Add(purchItem);
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
            return purchasedItems; // return instance of customer
        }
    }
    
}