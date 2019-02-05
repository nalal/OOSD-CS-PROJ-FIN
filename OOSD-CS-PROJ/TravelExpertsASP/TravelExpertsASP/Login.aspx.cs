using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using TravelExpertsASP.Models;

namespace TravelExpertsASP
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = TravelExperts1DB.GetConnection();

            try
            {
                conn.Open();
                string checkUser = "SELECT COUNT(*) FROM Customers where CustUserName ='"
                                   + txtCustUserName.Text + "'";
                SqlCommand userCmd = new SqlCommand(checkUser, conn);
                int temp = Convert.ToInt32(userCmd.ExecuteScalar().ToString());

                if (temp == 1)
                {

                    string cryptPassword = EncryptDB.Encrypt(txtCustPassword.Text);

                    

                    string checkPassword = "SELECT CustPassword FROM Customers WHERE CustPassword='" + cryptPassword + "'";
                    SqlCommand passCmd = new SqlCommand(checkPassword, conn);
                    string password = passCmd.ExecuteScalar().ToString().Replace(" ", "");
                    if (password == cryptPassword)
                    {
                        Session["Login"] = txtCustUserName.Text;
                        Response.Write("Password is correct");
                        Response.Redirect("User.aspx");
                    }
                    else
                    {
                        Response.Write("Password is not correct");
                    }

                }
                else
                {
                    Response.Write("Username is not correct");
                }
            }
            catch//(Exception ex)
            {
                Response.Write("Password is not correct"); //NEED TO FIGURE OUT HOW TO FIX IF PASSWORD IS NOT IN DATABASE
                //throw ex;
            }
            finally
            {
                conn.Close();
            }

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {

        }
    }
}