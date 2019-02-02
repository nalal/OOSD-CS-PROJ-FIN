using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        private Package package; //added package
        string selectedProduct; //to be used with comboBox1, stores the selectedProduct

        //Populate the Product list with products from the database
        private void Fillcombo()
        {

            // return list of product created in GetProductName()
            List<Product> myProdList = ProductsDB.GetProducts();

            // adding package names to the CBName (combo box)
            var prodLinq = from prod in myProdList
                           select new
                           {
                               prod.ProdName
                           };

            foreach (var item in prodLinq)
            {
                comboBox1.Items.Add(item.ProdName);
            }
        }

        //When user clicks save new package, will submit information to the database
        private void btnSaveNewPackage_Click(object sender, EventArgs e)
        {


            try
            {
                package = new Package();
                this.PutPackageData(package);
                
            }
            //sending the completed package to the AddNewPackage method, then retrieving the PackageId to be displayed

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        
        //Upon form loading, label the form as Add New Package
        private void FormAddNewPackage_Load(object sender, EventArgs e)
        {
           
            this.Text = "Add New Package";
            Fillcombo();
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

                        selectedProduct = comboBox1.SelectedItem.ToString();
                        package.ProdName = selectedProduct;

                        package.PackageId = PackageDB.AddNewPackage(package);
                        this.DialogResult = DialogResult.OK;
                        txtPackageId.Text = Convert.ToString(package.PackageId);
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