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
        private bool btnPackClicked = true;
        private bool btnUpdateClicked = false;
        private Package SinglePkg;
        private Product SingleProd;
        private Supplier SingleSup;
        private ProdSupplier SingleProdSup;


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
            btnSave.Visible = false;
            cbProdID.Visible = false;
            cbSupID.Visible = false;
            
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

            if(btnUpdateClicked)
            {
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
            else
            {
                // adding product names to the CBName (combo box)
                var productLinq = from prod in productList
                                  select new
                                  {
                                      prod.ProductId
                                  };

                foreach (var item in productLinq)
                {
                    cbProdID.Items.Add(item.ProductId);
                }
            }
        }

        // populate drop down with names of sup objects from the Suppliers list
        private void PopulateSuppliers()
        {
            // return list of suppliers created in GetSuppliers()
            List<Supplier> supplierList = SuppliersDB.GetSuppliers();
            if (btnUpdateClicked)
            {
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
            else
            {
                // adding supplier names to the CBName (combo box)
                var supplierLinq = from sup in supplierList
                                   select new
                                   {
                                       sup.SupplierId
                                   };

                foreach (var item in supplierLinq)
                {
                    cbSupID.Items.Add(item.SupplierId);
                }

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

                    SingleProd = prod;
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

                    txtID.Text = pkg.PackageId.ToString();
                    dTPStartDate.Value = Convert.ToDateTime(pkg.PkgStartDate);
                    dTPEndDate.Value = Convert.ToDateTime(pkg.PkgEndDate);
                    txtDesc.Text = pkg.PkgDesc;
                    txtBasePrice.Text = pkg.PkgBasePrice.ToString();
                    txtAgencyComm.Text = pkg.PkgAgencyCommission.ToString();

                    SinglePkg = pkg;
                }
            }

            SingleSup = new Supplier();
            SingleSup.SupplierId = Convert.ToInt32(txtID.Text);
            SingleSup.SupName = cBName.Text;
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

                SingleProdSup = prodSup;
            }
            
        }

        // all text boxes are cleared
        public void ClearTxtBoxes()
        {
            txtID.Text = "";
            cBName.SelectedIndex = -1;
            cBName.Items.Clear();
            cBID.SelectedIndex = -1;
            cBID.Items.Clear();
            cbProdID.SelectedIndex = -1;
            cbProdID.Items.Clear();
            cbSupID.SelectedIndex = -1;
            cbSupID.Items.Clear();
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
            btnPackClicked = true;
            btnUpdateClicked = false;

            // visibility settings
            lblID.Text = "   ID:";
            txtID.Visible = true;
            cBID.Visible = false;
            txtProdID.Visible = false;
            cBName.Visible = true;
            lblName.Text = "Name";
            cbProdID.Visible = false;
            txtSupID.Visible = false;
            cbSupID.Visible = false;
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
            btnPackClicked = false;
            btnUpdateClicked = false;

            // visibility settings
            lblID.Text = "   ID:";
            txtID.Visible = true;
            cBID.Visible = false;
            txtProdID.Visible = false;
            cBName.Visible = true;
            lblName.Text = "Name";
            cbProdID.Visible = false;
            txtSupID.Visible = false;
            cbSupID.Visible = false;
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
            btnPackClicked = false;
            btnUpdateClicked = false;

            // visibility settings
            lblID.Text = "   ID:";
            txtID.Visible = true;
            cBID.Visible = false;
            txtProdID.Visible = false;
            cBName.Visible = true;
            lblName.Text = "Name";
            cbProdID.Visible = false;
            txtSupID.Visible = false;
            cbSupID.Visible = false;
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
            btnPackClicked = false;
            btnUpdateClicked = false;

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
            if(btnPackClicked) 
            {
                FormAddNewPackage f2 = new FormAddNewPackage();//create a variable for AddPackage form
                f2.ShowDialog();//show the AddPackage form 
            }
            else if (btnProdClicked)
            {
                frmAddNewProduct f3 = new frmAddNewProduct();//create a variable for AddProd form
                f3.ShowDialog();//show the AddProd form 
            }
            else if (btnSupClicked)
            {
                frmAddNewSupplier f4 = new frmAddNewSupplier();//create a variable for AddSupplier form
                f4.ShowDialog();//show the AddSupplier form 
            }
            else
            {
                frmAddNewProdSupplier f5 = new frmAddNewProdSupplier();//create a variable for AddProductSupplier form
                f5.ShowDialog();//show the AddProductSupplier form 
            }
            //FormAddNewPackage f2 = new FormAddNewPackage();//create a variable for AddPackage form
            //f2.ShowDialog();//show the AddPackage form 
        }

        //Add Products button is clicked
        //private void btnAddProd_Click(object sender, EventArgs e)
        //{
        //    frmAddNewProduct f3 = new frmAddNewProduct();//create a variable for AddProd form
        //    f3.ShowDialog();//show the AddProd form 
        //}

        ////Add new Supplier button is clicked
        //private void btnAddSup_Click(object sender, EventArgs e)
        //{
        //    frmAddNewSupplier f4 = new frmAddNewSupplier();//create a variable for AddSupplier form
        //    f4.ShowDialog();//show the AddSupplier form 
        //}
        ////Add new Product Supplier is clicked
        //private void btnAddProdSup_Click(object sender, EventArgs e)
        //{
        //    frmAddNewProduct f5 = new frmAddNewProduct();//create a variable for AddProductSupplier form
        //    f5.ShowDialog();//show the AddProductSupplier form 
        //}



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

        //Maryam
        //Updating the data
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            // updates - Chad
            if (btnProdSupClicked)
            {
                cbProdID.Visible = true;
                cbSupID.Visible = true;

                PopulateProducts();
                PopulateSuppliers();
            }
            
        }

        //Saving the Data in database
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool updated = false;

            //if Supplier button is clicked
            if (btnSupClicked)
            {
                if (Validator1.IsProvidedCombo(cBName, "Supplier Name"))
                {
                    Supplier newSup = new Supplier();
                    newSup.SupName = cBName.Text;

                    updated = SuppliersDB.UpdateSupplier(newSup, SingleSup);
                    if (updated)
                    {
                        MessageBox.Show("Supplier Updated");
                    }
                    else
                    {
                        MessageBox.Show("Supplier not Updated. Please try again.");
                    }
                }
            }
            //If Products button is clicked
            if (btnProdClicked)
            {
                if (Validator1.IsProvidedCombo(cBName, "Product Name"))
                {
                    Product NewProd = new Product();
                    NewProd.ProdName = cBName.Text;

                    updated = ProductsDB.UpdateProducts(NewProd, SingleProd);
                    if (updated)
                    {
                        MessageBox.Show("Products Updated");
                    }
                    else
                    {
                        MessageBox.Show("Products not Updated. Please try again");
                    }
                }
            }
            if (btnProdSupClicked)// this does not work yet
            {
                if (Validator1.IsProvided(txtProdID, "Product Id") &&
                    Validator1.IsProvided(txtSupID, "Supplier Id"))
                {
                    ProdSupplier newProdSupplier = new ProdSupplier();
                    newProdSupplier.ProductId = Convert.ToInt32(txtProdID.Text);
                    newProdSupplier.SupplierId = Convert.ToInt32(txtSupID.Text);

                    updated = ProdSuppliersDB.UpdateProdSupplier(newProdSupplier, SingleProdSup);
                    if (updated)
                    {
                        MessageBox.Show("Product_Supplier is Updated");
                    }
                    else
                    {
                        MessageBox.Show("Product_Supplier is not Updated. Please try again");
                    }
                }

            }
            if (btnPackClicked)  // Otherwise just load Packages
            {
                if (Validator1.IsProvidedCombo(cBName, "Package Name") &&
                    Validator1.IsProvided(txtDesc, "Describtion") &&
                    Validator1.IsProvided(txtBasePrice, "Base Price") &&
                    Validator1.IsProvided(txtAgencyComm, "Agency Commission") &&
                    Validator1.IsNonNegativeDecimal(txtAgencyComm, "Agency Commission") &&
                    Validator1.IsNonNegativeDecimal(txtBasePrice, "Base Price"))
                {

                    Package NewPackage = new Package();
                    NewPackage.PkgName = cBName.Text;
                    if (dTPStartDate.Value.Date >= dTPEndDate.Value.Date)
                    {
                        MessageBox.Show("Package start date cannot be later than end date");
                    }

                    else if (Convert.ToDecimal(txtBasePrice.Text) < Convert.ToDecimal(txtAgencyComm.Text))
                    {
                        MessageBox.Show("Agency Comission cannot be more than Package Base price!");
                    }
                    else
                    {
                        NewPackage.PkgStartDate = dTPStartDate.Value.ToString("yyyy-MM-dd");
                        NewPackage.PkgEndDate = dTPEndDate.Value.ToString("yyyy-MM-dd");
                        NewPackage.PkgDesc = txtDesc.Text;
                        NewPackage.PkgBasePrice = Convert.ToDecimal(txtBasePrice.Text);
                        NewPackage.PkgAgencyCommission = Convert.ToDecimal(txtAgencyComm.Text);

                        updated = PackageDB.UpdatePackage(NewPackage, SinglePkg);
                    }

                    if (updated)
                    {
                        MessageBox.Show("Package is Updated");
                    }
                    else
                    {
                        MessageBox.Show("Package is not Updated, Please try again.");
                    }
                }
            }
        }
    } 
}
