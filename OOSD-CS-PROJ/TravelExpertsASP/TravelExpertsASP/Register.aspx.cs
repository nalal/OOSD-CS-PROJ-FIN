using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelExpertsASP.Models;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace TravelExpertsASP
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //SqlConnection conn = TravelExperts1DB.GetConnection();
            //try
            //{
            //    conn.Open();



            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
            //finally
            //{
            //    conn.Close();
            //}
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnCustRegister_Click(object sender, EventArgs e)
        {
            bool UserNameChecked = false;
            bool insert = false;
            List<string> userNames = CustomersDB.GetUserNames(); // replace with user name list

            foreach (string username in userNames)
            {
                if (txtCustUserName.Text == username)
                {
                    Response.Write("User name is already taken. Please choose another user name");
                    UserNameChecked = false;
                    break;
                }
                else
                    UserNameChecked = true;
            }

            if (Page.IsValid && UserNameChecked)
            {
                string cryptPassword = EncryptDB.Encrypt(txtCustPassword.Text);

             

                Customer cust = new Customer(txtCustFirstName.Text, txtCustLastName.Text, txtCustAddress.Text,
                                        txtCustCity.Text, ddlCustProv.SelectedValue.ToString(), txtCustPostal.Text,
                                        ddlCustCountry.SelectedValue.ToString(), txtCustHomePhone.Text, txtCustBusPhone.Text,
                                        txtCustEmail.Text, txtCustUserName.Text, cryptPassword.ToString().Trim());

                SqlConnection conn = TravelExperts1DB.GetConnection();
                try
                {
                    conn.Open();

                    insert = CustomersDB.CreateCustomer(cust);

                    if (insert)
                    {
                        Response.Redirect("http://localhost:61652/Login.aspx");
                        //Response.Write("Registration successful");
                    }
                    //else
                    //    Response.Write("Registration unsuccessful");
                }
                catch (Exception)
                {
                    //Response.Write("User name is already taken. Please choose another user name");
                    //throw ex;
                    Response.Write("Registration unsuccessful");
                }
                finally
                {
                    conn.Close();
                }
            }
            //else
            //{
            //    Response.Write("Registration unsuccessful");
            //}
        }

            // ===============         YOUR ORIGINAL CODE!!!!!!          ===================== //

            //bool insert = false;

            //Customer cust = new Customer(txtCustFirstName.Text, txtCustLastName.Text, txtCustAddress.Text,
            //                            txtCustCity.Text, ddlCustProv.SelectedValue.ToString() , txtCustPostal.Text, 
            //                            ddlCustCountry.SelectedValue.ToString(),txtCustHomePhone.Text, txtCustBusPhone.Text, 
            //                            txtCustEmail.Text, txtCustUserName.Text, txtCustPassword.Text);

            
            //if (Page.IsValid)
            //{
            //    SqlConnection conn = TravelExperts1DB.GetConnection();
            //    try
            //    {
            //        conn.Open();

            //        insert = CustomersDB.CreateCustomer(cust);

            //        if (insert)
            //        {
            //            Response.Write("Registration successful");
            //        }
            //        else
            //            Response.Write("GET ME COOKIES");
            //    }
            //    catch (Exception ex)
            //    {
            //        Response.Write("User name is already taken. Please choose another user name");
            //        throw ex;
            //    }
            //    finally
            //    {
            //        conn.Close();
            //    }
            //}
            //else
            //{
            //    Response.Write("Registration unsuccessful");
            //}
    }
}