using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


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

            // adding product names to the CBName (combo box)
            var prodLinq = from prod in myProdList
                           select new
                           {
                               prod.ProdName
                           };

            foreach (var item in prodLinq)
            {
                cboProdList.Items.Add(item.ProdName);
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
                if (Validator1.IsProvided(txtPkgName, "Package Name") &&
                    Validator1.IsProvided(txtPkgDesc, "Package Description") &&
                    Validator1.IsNonNegativeDecimal(txtPkgBasePrice, "Package Base Price") &&
                       Validator1.IsNonNegativeDecimal(txtPkgAgencyCommission, "Agency Commission"))
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
                        //Assigning all the given values to the package object
                        package.PkgStartDate =  dtStartDate.Value.ToString("yyyy-MM-dd");
                        package.PkgEndDate =  dtEndDate.Value.ToString("yyyy-MM-dd");

                        package.PkgDesc = txtPkgDesc.Text;
                        package.PkgBasePrice = Convert.ToDecimal(txtPkgBasePrice.Text);
                        package.PkgAgencyCommission = Convert.ToDecimal(txtPkgAgencyCommission.Text);

                        if (cboProdList.SelectedIndex < 00000000)
                        {

                            selectedProduct = " ";
                            package.ProdName = selectedProduct;
                        }
                        else
                        {
                            selectedProduct = cboProdList.SelectedItem.ToString();
                            package.ProdName = selectedProduct;
                        }

                        package.PackageId = PackageDB.AddNewPackage(package);
                        this.DialogResult = DialogResult.OK;
                        txtPackageId.Text = Convert.ToString(package.PackageId);
                        MessageBox.Show("Package has been saved");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
//This modifies Package Base price textbox so that we only allow digits and two digits after decimals
        private void txtPkgBasePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Don't allow other key presses
            if (!char.IsControl(e.KeyChar)
        && !char.IsDigit(e.KeyChar)
        && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point 
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            //Only allow two digits after decimal 
            if (Regex.IsMatch(txtPkgBasePrice.Text, @"\.\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
//This modifies Agency Comission textbox so that we only allow digits and two digits after decimals
        private void txtPkgAgencyCommission_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Don't allow other key presses
            if (!char.IsControl(e.KeyChar)
            && !char.IsDigit(e.KeyChar)
            && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point 
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            //Only allow two digits after decimal 
            if (Regex.IsMatch(txtPkgAgencyCommission.Text, @"\.\d\d") && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}