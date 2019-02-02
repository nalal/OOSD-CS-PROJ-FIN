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
                    while (myReader.Read())
                    {
                        lblWelcome.Text += (myReader["CustFirstName"].ToString());
                    }

                    Session["Name"] = (myReader["CustFirstName"].ToString());
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
    }
}