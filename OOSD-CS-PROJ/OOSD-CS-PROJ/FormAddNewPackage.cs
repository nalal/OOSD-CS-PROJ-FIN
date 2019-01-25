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
            

                package = new Package();
                this.PutPackageData(package);
            
                try
                {
                package.PackageID = PackageDB.AddNewPackage(package);
                this.DialogResult = DialogResult.OK;
                txtPackageID.Text = Convert.ToString(package.PackageID);
                //sending the completed package to the AddNewPackage method, then retrieving the packageID to be displayed
                }
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

            if (Validator.IsProvided(txtPkgName, "Package Name") &&
                Validator.IsProvided(txtPkgDesc, "Package Description") &&
                Validator.IsNonNegativeDecimal(txtPkgBasePrice, "Base Price") &&
                   Validator.IsNonNegativeDecimal(txtPkgAgencyComission, "Agency Commission"))
            {
                package.PkgName = txtPkgName.Text;

                //putting in variables so that we can error check Pkg start and end date 
                if (dtStartDate.Value.Date > dtEndDate.Value.Date)
                {
                    MessageBox.Show("Package start date cannot be later than end date");
                }
                else
                {
                    package.PkgStartDate = dtStartDate.Value.Date;
                    package.PkgEndDate = dtEndDate.Value.Date;
                    package.PkgDesc = txtPkgDesc.Text;
                    package.PkgBasePrice = Convert.ToDecimal(txtPkgBasePrice.Text);
                    package.PkgAgencyCommission = Convert.ToDecimal(txtPkgAgencyComission.Text);
                }
            }
            
        }

    }
}
