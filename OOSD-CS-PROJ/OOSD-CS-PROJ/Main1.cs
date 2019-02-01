using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOSD_CS_PROJ
{
    //Chad Dundas Smith
    public partial class Main1 : Form
    {
        // bools set - later to be used to indicate if a 
        // specific button has been clicked
        private bool btnProdClicked = false;
        private bool btnSupClicked = false;
        private bool btnProdSupClicked = false;

        public Main1()
        {// Noah
            InitializeComponent();
            SQLCon();
            if (!ConnectionPage.Term && DBCall.CSucces)
            {
                
            }
            else if (ConnectionPage.Term || !DBCall.CSucces)
            {
                Environment.Exit(1);
            }
        }

        //Noah
        private void SQLCon()
        {
            Form lp = new ConnectionPage();
            lp.ShowDialog();
        }

        private void Main1_Load(object sender, EventArgs e)
        {
            // populate drop down with names of pkg objects from the Packages list
            PopulatePackages();

            // setting visibility 
            cBID.Visible = false;
            txtProdID.Visible = false;
            txtSupID.Visible = false;
        }

        // populate drop down with names of pkg objects from the Packages list
        private void PopulatePackages()
        {
            // return list of packages created in GetPackages()
            List<Package> packageList = MainPackageDB.GetPackages();

            // adding package names to the CBName (combo box)
            var packageLinq = from pkg in packageList
                              select new
                              {
                                  pkg.PkgName
                              };

            foreach (var item in packageLinq)
            {
                cBName.Items.Add(item.PkgName);
            }
        }

        
        // populate drop down with names of prod objects from the Products list
        private void PopulateProducts()
        {
            // return list of packages created in GetProducts()
            List<Product> productList = ProductsDB.GetProducts();

            // adding product names to the CBName (combo box)
            var productLinq = from prod in productList
                              select new
                              {
                                  prod.ProdName
                              };

            foreach (var item in productLinq)
            {
                cBName.Items.Add(item.ProdName);
            }
        }

        // populate drop down with names of sup objects from the Suppliers list
        private void PopulateSuppliers()
        {
            // return list of suppliers created in GetSuppliers()
            List<Supplier> supplierList = SuppliersDB.GetSuppliers();

            // adding supplier names to the CBName (combo box)
            var supplierLinq = from sup in supplierList
                              select new
                              {
                                  sup.SupName
                              };

            foreach (var item in supplierLinq)
            {
                cBName.Items.Add(item.SupName);
            }
        }

        // populate drop down with names of sup objects from the Suppliers list
        private void PopulateProdSuppliers()
        {
            // return list of suppliers created in GetProdSuppliers()
            List<ProdSupplier> prodSupplierList = ProdSuppliersDB.GetProdSuppliers();

            // adding product supplier names to the CBName (combo box)
            var prodSupplierLinq = from prodSup in prodSupplierList
                               select new
                               {
                                   prodSup.ProductSupplierId
                               };

            foreach (var item in prodSupplierLinq)
            {
                cBID.Items.Add(item.ProductSupplierId);
            }
        }

        // when name combo box (ddl) is used to select an object from the list
        private void cBPkgName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if the Products button was most recently clicked
            if (btnProdClicked)
            {
                // return list of packages created in GetProducts()
                List<Product> productList = ProductsDB.GetProducts();

                // display information about the selected product
                if (cBName.SelectedIndex != -1)
                {
                    var prod = (from selectedprod in productList where
                                selectedprod.ProdName == cBName.Text
                                select selectedprod).First();

                    txtID.Text = prod.ProductId.ToString();
                }
            }

            // if the Suppliers button was most recently clicked
            else if (btnSupClicked)
            {
                // return list of packages created in GetSuppliers()
                List<Supplier> supplierList = SuppliersDB.GetSuppliers();

                // if a selection is made from the combobox
                if (cBName.SelectedIndex != -1)
                {
                    // display information about the selected supplier
                    var sup = (from selectedsup in supplierList
                                where selectedsup.SupName == cBName.Text
                                select selectedsup).First();

                    txtID.Text = sup.SupplierId.ToString();
                }
            }

            // if the Packages button was most recently clicked
            // or on form load
            else
            {
                // return list of packages created in GetPackages()
                List<Package> packageList = MainPackageDB.GetPackages();

                // if a selection is made from the combo box
                if (cBName.SelectedIndex != -1)
                {
                    // display information about the selected package
                    var pkg = (from selectedpkg in packageList where 
                               selectedpkg.PkgName == cBName.Text
                               select selectedpkg).First();

                    txtID.Text = pkg.PackageID.ToString();
                    dTPStartDate.Value = Convert.ToDateTime(pkg.PkgStartDate);
                    dTPEndDate.Value = Convert.ToDateTime(pkg.PkgEndDate);
                    txtDesc.Text = pkg.PkgDesc;
                    txtBasePrice.Text = pkg.PkgBasePrice.ToString();
                    txtAgencyComm.Text = pkg.PkgAgencyCommission.ToString();

                }
            }

        }

        // when name combo box (ddl) is used to select an object from the list
        private void cBID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // return list of packages created in GetProdSuppliers()
            List<ProdSupplier> prodSupplierList = ProdSuppliersDB.GetProdSuppliers();

            // if a selection is made from the combo box
            if (cBID.SelectedIndex != -1)
            {
                // display information about the selected product supplier
                var prodSup = (from selectedprodSup in prodSupplierList where
                                selectedprodSup.ProductSupplierId == Convert.ToInt32(cBID.Text)
                                select selectedprodSup).First();

                txtProdID.Text = prodSup.ProductId.ToString();
                txtSupID.Text = prodSup.SupplierId.ToString();
            }
            
        }

        // all text boxes are cleared
        public void ClearTxtBoxes()
        {
            txtID.Text = "";
            cBName.SelectedIndex = -1;
            cBName.Items.Clear();
            dTPStartDate.Text = "";
            dTPEndDate.Text = "";
            txtDesc.Text = "";
            txtBasePrice.Text = "";
            txtAgencyComm.Text = "";

        }

        // packages button is clicked
        private void btnPkgs_Click(object sender, EventArgs e)
        {
            // setting which button was clicked
            btnProdClicked = false;
            btnSupClicked = false;
            btnProdSupClicked = false;

            // visibility settings
            lblID.Text = "   ID:";
            txtID.Visible = true;
            cBID.Visible = false;
            txtProdID.Visible = false;
            cBName.Visible = true;
            lblName.Text = "Name";
            txtSupID.Visible = false;
            lblStartDate.Visible = true;
            lblStartDate.Text = "Start Date:";
            dTPStartDate.Visible = true;
            lblEndDate.Visible = true;
            dTPEndDate.Visible = true;
            lblDesc.Visible = true;
            txtDesc.Visible = true;
            lblBasePrice.Visible = true;
            txtBasePrice.Visible = true;
            lblAgencyComm.Visible = true;
            txtAgencyComm.Visible = true;
            ClearTxtBoxes();
            lblDetails.Text = "Package Details";
            lblSearch.Text = "Search Packages:";
            lblSearchFor.Text = "Names";
            btnAddNew.Text = "Add New Package(s)";

            // create list of packages from DB class
            PopulatePackages();
        }

        // products button is clicked
        private void btnPrdts_Click(object sender, EventArgs e)
        {
            // setting which button was clicked
            btnProdClicked = true;
            btnSupClicked = false;
            btnProdSupClicked = false;

            // visibility settings
            lblID.Text = "   ID:";
            txtID.Visible = true;
            cBID.Visible = false;
            txtProdID.Visible = false;
            cBName.Visible = true;
            lblName.Text = "Name";
            txtSupID.Visible = false;
            lblStartDate.Visible = false;
            dTPStartDate.Visible = false;
            lblEndDate.Visible = false;
            dTPEndDate.Visible = false;
            lblDesc.Visible = false;
            txtDesc.Visible = false;
            lblBasePrice.Visible = false;
            txtBasePrice.Visible = false;
            lblAgencyComm.Visible = false;
            txtAgencyComm.Visible = false;
            ClearTxtBoxes();
            lblDetails.Text = "Product Details";
            lblSearch.Text = "Search Products:";
            lblSearchFor.Text = "Names";
            btnAddNew.Text = "Add New Product(s)";

            // create list of products from DB class
            PopulateProducts();
        }

        // suppliers button is clicked
        private void btnSupps_Click(object sender, EventArgs e)
        {
            // setting which button was clicked
            btnProdClicked = false;
            btnSupClicked = true;
            btnProdSupClicked = false;

            // visibility settings
            lblID.Text = "   ID:";
            txtID.Visible = true;
            cBID.Visible = false;
            txtProdID.Visible = false;
            cBName.Visible = true;
            lblName.Text = "Name";
            txtSupID.Visible = false;
            lblStartDate.Visible = false;
            dTPStartDate.Visible = false;
            lblEndDate.Visible = false;
            dTPEndDate.Visible = false;
            lblDesc.Visible = false;
            txtDesc.Visible = false;
            lblBasePrice.Visible = false;
            txtBasePrice.Visible = false;
            lblAgencyComm.Visible = false;
            txtAgencyComm.Visible = false;
            ClearTxtBoxes();
            lblDetails.Text = "Supplier Details";
            lblSearch.Text = "Search Suppliers:";
            lblSearchFor.Text = "Names";
            btnAddNew.Text = "Add New Supplier(s)";

            // create list of suppliers from DB class
            PopulateSuppliers();
        }

        // product suppliers button is clicked
        private void btnPrdctSupps_Click(object sender, EventArgs e)
        {
            // setting which button was clicked
            btnProdClicked = false;
            btnSupClicked = false;
            btnProdSupClicked = true;
           
            // visibility settings
            lblID.Text = "Product\nSupplier ID:";
            txtID.Visible = false;
            cBID.Visible = true;
            txtProdID.Visible = true;
            cBName.Visible = false;
            lblName.Text = "Product ID:";
            txtSupID.Visible = true;
            lblStartDate.Visible = true;
            lblStartDate.Text = "Supplier ID:";
            dTPStartDate.Visible = false;
            lblEndDate.Visible = false;
            dTPEndDate.Visible = false;
            lblDesc.Visible = false;
            txtDesc.Visible = false;
            lblBasePrice.Visible = false;
            txtBasePrice.Visible = false;
            lblAgencyComm.Visible = false;
            txtAgencyComm.Visible = false;
            ClearTxtBoxes();
            lblDetails.Text = "Product Supplier Details";
            lblSearch.Text = "Search Product Suppliers:";
            lblSearchFor.Text = "     IDs";
            btnAddNew.Text = "Add New\nProduct Supplier(s)";

            // create list of product suppliers from DB class
            PopulateProdSuppliers();
        }
/*Buttons that lead to new forms 
Author:Helen Lin */

        // add new Package button is clicked
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FormAddNewPackage f2 = new FormAddNewPackage();//create a variable for AddPackage form
            f2.ShowDialog();//show the AddPackage form 
        }

        //Add Products button is clicked
        private void btnAddProd_Click(object sender, EventArgs e)
        {
            frmAddNewProduct f3 = new frmAddNewProduct();//create a variable for AddProd form
            f3.ShowDialog();//show the AddProd form 
        }

        //Add new Supplier button is clicked
        private void btnAddSup_Click(object sender, EventArgs e)
        {
            frmAddNewSupplier f4 = new frmAddNewSupplier();//create a variable for AddSupplier form
            f4.ShowDialog();//show the AddSupplier form 
        }
        //Add new Product Supplier is clicked
        private void btnAddProdSup_Click(object sender, EventArgs e)
        {
            frmAddNewProduct f5 = new frmAddNewProduct();//create a variable for AddProductSupplier form
            f5.ShowDialog();//show the AddProductSupplier form 
        }



        // search button is clicked
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Product Suppliers button was most recently clicked
            if (btnProdSupClicked)
            {
                // searching the ID combo box
                int index = cBID.FindString(txtSearch.Text);
                if (index < 0)
                {
                    MessageBox.Show("Item not found.");
                    txtSearch.Text = string.Empty;
                }
                else
                {
                    cBID.SelectedIndex = index;
                }
            }

            // if any of the other options were clicked
            // or form load
            else
            {
                // searching the Name combo box
                int index = cBName.FindString(txtSearch.Text);
                if (index < 0)
                {
                    MessageBox.Show("Item not found.");
                    txtSearch.Text = string.Empty;
                }
                else
                {
                    cBName.SelectedIndex = index;
                }
            }
        }

        
    } 
}
