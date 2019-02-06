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
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Login"] != null)
            {
                string custUserName = Session["Login"].ToString();
                SqlConnection conn = TravelExperts1DB.GetConnection();
                string getCustFirstName = "SELECT CustFirstName from Customers where CustUserName = @CustUserName";
                SqlCommand cmd = new SqlCommand(getCustFirstName, conn);
                SqlParameter input = new SqlParameter();
                input.ParameterName = "@CustUserName";
                input.Value = custUserName;
                cmd.Parameters.Add(input);

                try
                {
                    conn.Open();
                    SqlDataReader myReader;
                    myReader = cmd.ExecuteReader();
                    string name = "";
                    while (myReader.Read())
                    {
                        name = (myReader["CustFirstName"].ToString());
                        lblWelcome.Text += name;
                    }

                }
                catch(Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["Login"] = null;
            Response.Redirect("Login.aspx");
        }

        protected void btnAccountDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserAccountDetails.aspx");
        }

        protected void btnPurchasedProducts_Click(object sender, EventArgs e)
        {
            Response.Redirect("PurchasedItems.aspx");
        }
    }
}