using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TravelExpertsASP.Models;

namespace TravelExpertsASP
{
    public partial class PurchasedProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Login"] != null)
                {
                    string custUserName = Session["Login"].ToString();

                    List<PurchasedItem> piList = PurchasedItemsDB.PurchasedItemsByCustomer(custUserName);

                    //PurchasedItemsDB.PurchasedItemsByCustomer(custUserName);

                    //Response.Write()

                    //PopulateAccountDetails(cust);

                    dlAcctDetails.DataSource = piList;
                    dlAcctDetails.DataBind();

                    //Response.Write(fuck);

                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }  
        }

    }
}