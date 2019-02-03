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
    public partial class UserAccountDetails : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AccountDetailsVisibility();
                ReadOnly();
                LoadSessionData();

                //if (Session["Login"] != null)
                //{
                //    string custUserName = Session["Login"].ToString();
                //    lblLoginUserName.Text = custUserName;
                //    Customer cust = CustomersDB.GetCustomerByUserName(custUserName);
                //    PopulateAccountDetails(cust);

                //    Session["UserName"] = cust.CustUserName;
                //    Session["Password"] = cust.CustPassword;
                //}

                //else
                //{
                //    Response.Redirect("Login.aspx");
                //}
                
            }
            else
            {

            }
            
        }

        private void LoadSessionData()
        {
            if (Session["Login"] != null)
            {
                string custUserName = Session["Login"].ToString();
                lblLoginUserName.Text = custUserName;
                Customer cust = CustomersDB.GetCustomerByUserName(custUserName);
                PopulateAccountDetails(cust);

                Session["UserName"] = cust.CustUserName;
                Session["Password"] = cust.CustPassword;
            }

            else
            {
                Response.Redirect("Login.aspx");
            }
            
        }

        public void AccountDetailsVisibility()
        {
            btnSaveUpd.Visible = false;
        }
        private void PopulateAccountDetails(Customer cust)
        {
            txtCustFirstName.Text = cust.CustFirstName.ToString();
            txtCustLastName.Text = cust.CustLastName.ToString();
            txtCustAddress.Text = cust.CustAddress.ToString();
            txtCustCity.Text = cust.CustCity.ToString();
            ddlCustProv.SelectedValue = cust.CustProv;
            txtCustPostal.Text = cust.CustPostal.ToString();
            ddlCustCountry.SelectedValue = cust.CustCountry;
            txtCustHomePhone.Text = cust.CustHomePhone.ToString();
            txtCustBusPhone.Text = cust.CustBusPhone.ToString();
            txtCustEmail.Text = cust.CustEmail.ToString();
            

            
        }

        public void ReadOnly()
        {
            txtCustFirstName.ReadOnly = true;
            txtCustLastName.ReadOnly = true;
            txtCustAddress.ReadOnly = true;
            txtCustCity.ReadOnly = true;
            ddlCustProv.Enabled = false;
            txtCustPostal.ReadOnly = true;
            ddlCustCountry.Enabled = false;
            txtCustHomePhone.ReadOnly = true;
            txtCustBusPhone.ReadOnly = true;
            txtCustEmail.ReadOnly = true;

        }

        public void EnableForUpdates()
        {
            txtCustFirstName.ReadOnly = false;
            txtCustLastName.ReadOnly = false;
            txtCustAddress.ReadOnly = false;
            txtCustCity.ReadOnly = false;
            ddlCustProv.Enabled = true;
            txtCustPostal.ReadOnly = false;
            ddlCustCountry.Enabled = true;
            txtCustHomePhone.ReadOnly = false;
            txtCustBusPhone.ReadOnly = false;
            txtCustEmail.ReadOnly = false;
            btnSaveUpd.Visible = true;
        }

        protected void btnUpdate_Click1(object sender, EventArgs e)
        {
           
            EnableForUpdates();
            

        }

        protected void btnSaveUpd_Click(object sender, EventArgs e)
        {
            

            //SqlConnection conn = TravelExperts1DB.GetConnection();

            Customer currCust = CustomersDB.GetCustomerByUserName(Session["UserName"].ToString());

                //if (Page.IsValid)
                //{
                //Customer updCust = new Customer(
                //txtCustFirstName.Text.ToString().ToString(), txtCustLastName.Text.ToString(), txtCustAddress.Text.ToString(),
                //txtCustCity.Text.ToString(), ddlCustProv.Text.ToString(), txtCustPostal.Text.ToString(), ddlCustCountry.Text.ToString(),
                //txtCustHomePhone.Text.ToString(), txtCustBusPhone.Text.ToString(), txtCustEmail.Text.ToString(),
                //txtCustUserName.Text.ToString(), txtCustPassword.Text.ToString());

                Customer updCust = new Customer();

                updCust.CustFirstName = txtCustFirstName.Text.ToString();
                updCust.CustLastName = txtCustLastName.Text.ToString();
                updCust.CustAddress = txtCustAddress.Text.ToString();
                updCust.CustCity = txtCustCity.Text.ToString();
                updCust.CustProv = ddlCustProv.Text.ToString();
                updCust.CustPostal = txtCustPostal.Text.ToString();
                updCust.CustCountry = ddlCustCountry.Text.ToString();
                updCust.CustHomePhone = txtCustHomePhone.Text.ToString();
                updCust.CustBusPhone = txtCustBusPhone.Text.ToString();
                updCust.CustEmail = txtCustEmail.Text.ToString();
                updCust.CustUserName = Session["UserName"].ToString();
                updCust.CustPassword = Session["Password"].ToString();



                try
                {
                    bool updSuccessful = CustomersDB.UpdateCustomer(currCust, updCust);
                    if (updSuccessful)
                    {
                        Response.Write("Account Details update successful");
                    }
                    else
                    {
                        Response.Write("Account Details update failed, please try again");
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                //}
                //else
                //{
                //    Response.Write("Update FAILED");
                //}
            

        }
    }
}