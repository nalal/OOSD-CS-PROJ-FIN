using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelExpertsASP.Models;

namespace TravelExpertsASP
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = TravelExperts1DB.GetConnection();
            try
            {
                conn.Open();
                


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            
           
        }

        protected void btnCustRegister_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer(txtCustFirstName.Text, txtCustLastName.Text, txtCustAddress.Text,
                                        txtCustCity.Text, txtCustProv.Text, txtCustPostal.Text, txtCustCountry.Text,
                                        txtCustHomePhone.Text, txtCustBusPhone.Text, txtCustEmail.Text, txtCustUserName.Text,
                                        txtCustPassword.Text);
            try
            {
                CustomersDB.CreateCustomer(cust);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

      
    }
}