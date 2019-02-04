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
    public partial class frmAddNewProdSupplier : Form
    {
        public frmAddNewProdSupplier()
        {
            InitializeComponent();
        }

        //Author: Helen Lin

        //variables
        int selectedProduct;
        int selectedSupplier;

        private ProdSupplier prodSupplier; //new added product supplier

        //On form load, do these things
        private void frmAddNewProdSupplier_Load(object sender, EventArgs e)
        {
            this.Text = "Add New Product Supplier"; //on load, name the window this
            FillComboBoxes(); //fills the combo boxes
        }

        //populate combo boxes so there is a supplierID and product ID to choose from 
        //Populate the Product list with products from the database
        private void FillComboBoxes()
        {

            // return list of productID created in GetProductName()
            List<Product> myProdList = ProductsDB.GetProducts();

            // adding product names to the CBName (combo box)
            var prodLinq = from prod in myProdList
                           select new
                           {
                               prod.ProductId
                           };

            foreach (var item in prodLinq)
            {
                cboProdID.Items.Add(item.ProductId);
            }

            // return list of supplierID names created in GetProductName()
            List<Supplier> mySupList = SuppliersDB.GetSuppliers();

            // adding package names to the CBName (combo box)
            var supLinq = from sup in mySupList
                          select new
                          {
                              sup.SupplierId
                          };

            foreach (var item in supLinq)
            {
                cboSupID.Items.Add(item.SupplierId);
            }
        }
        //This will add new product supplier
        private void btnSaveProdSup_Click_1(object sender, EventArgs e)
        {
           
            try
            {
                prodSupplier = new ProdSupplier();
                this.PutProdSupplierData(prodSupplier);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        private void PutProdSupplierData(ProdSupplier newProductSupplier)
        {
            try
            {
                    selectedProduct = Convert.ToInt32(cboProdID.SelectedItem);
                    prodSupplier.ProductId = selectedProduct;

                    selectedSupplier = Convert.ToInt32(cboSupID.SelectedItem);
                    prodSupplier.SupplierId = selectedSupplier;

                    ProdSuppliersDB.AddNewProdSupplier(prodSupplier);
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Product Supplier has been saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }


    }
}
