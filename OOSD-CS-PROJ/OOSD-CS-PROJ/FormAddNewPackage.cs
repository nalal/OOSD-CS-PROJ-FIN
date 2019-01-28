using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Packages;

namespace OOSD_CS_PROJ
{
    public partial class FormAddNewPackage : Form
    {   /*Author: Helen Lin
        *This form is where the user adds new packages to the database*/
        public FormAddNewPackage()
        {
            InitializeComponent();
        }


        public Package package; //added package
     

        //When user clicks save new package, will submit information to the database
        private void btnSaveNewPackage_Click(object sender, EventArgs e)
        {


            try
            {
                package = new Package();
                this.PutPackageData(package);

                
               
            }
            //sending the completed package to the AddNewPackage method, then retrieving the packageID to be displayed

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        //Upon form loading, label the form as Add New Package
        private void FormAddNewPackage_Load(object sender, EventArgs e)
        {
            this.Text = "Add New Package";
           
        }

        //this will take from the textboxes and put it into the object
        private void PutPackageData(Package package)
        {
            try
            {
                if (Validator.IsProvided(txtPkgName, "Package Name") &&
                    Validator.IsProvided(txtPkgDesc, "Package Description") &&
                    Validator.IsNonNegativeDecimal(txtPkgBasePrice, "Package Base Price") &&
                       Validator.IsNonNegativeDecimal(txtPkgAgencyCommission, "Agency Commission"))
                {
                   
                    package.PkgName = txtPkgName.Text;
                    
                    if (dtStartDate.Value.Date >= dtEndDate.Value.Date)
                    {
                        MessageBox.Show("Package start date cannot be later than end date");
                    }
                    else if(dtStartDate.Value.ToString() == "" || dtEndDate.Value.ToString() == "")
                    {
                        MessageBox.Show("Please enter start and end date");
                    }
                    else if(Convert.ToDecimal(txtPkgBasePrice.Text)<Convert.ToDecimal(txtPkgAgencyCommission.Text))
                    {
                        MessageBox.Show("Agency Comission cannot be more than Package Base price!");
                    }
                    else
                    {
                        package.PkgStartDate =  dtStartDate.Value.ToString("yyyy-MM-dd");
                        package.PkgEndDate =  dtEndDate.Value.ToString("yyyy-MM-dd");

                     

                        package.PkgDesc = txtPkgDesc.Text;
                        package.PkgBasePrice = Convert.ToDecimal(txtPkgBasePrice.Text);
                        package.PkgAgencyCommission = Convert.ToDecimal(txtPkgAgencyCommission.Text);

                        package.PackageID = PackageDB.AddNewPackage(package);
                        this.DialogResult = DialogResult.OK;
                        txtPackageID.Text = Convert.ToString(package.PackageID);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

    }
}