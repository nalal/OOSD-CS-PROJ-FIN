using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelExpertsASP.Models;

namespace TravelExpertsASP
{
    public partial class UserAccountDetails : System.Web.UI.Page
    {
        //string custUserName = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Login"] != null)
            {
                string custUserName = Session["Login"].ToString();
                lblLoginUserName.Text = custUserName;
                Customer cust = CustomersDB.GetCustomerByUserName(custUserName);
                PopulateAccountDetails(cust);
            }
            
            else
            {
                Response.Redirect("Login.aspx");
            }
            
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
            txtCustUserName.Text = cust.CustUserName.ToString();
            txtCustPassword.Text = cust.CustPassword.ToString();



            //txtID.Text = pkg.PackageId.ToString();
            //dTPStartDate.Value = Convert.ToDateTime(pkg.PkgStartDate);
            //dTPEndDate.Value = Convert.ToDateTime(pkg.PkgEndDate);
            //txtDesc.Text = pkg.PkgDesc;
            //txtBasePrice.Text = pkg.PkgBasePrice.ToString();
            //txtAgencyComm.Text = pkg.PkgAgencyCommission.ToString();

        }
    }
}