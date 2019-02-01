using Packages;
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
    public partial class frmAddNewProduct : Form
    {
        public frmAddNewProduct()
        {
            InitializeComponent();
        }

        private void frmAddNewProduct_Load(object sender, EventArgs e)
        {
            this.Text = "Add New Product";//on load, name the window this
        }

        //Author: Helen Lin 
        private Product product; //new added supplier

        private void frmAddNewProdSupplier_Load(object sender, EventArgs e)
        {
            this.Text = "Add New Product Supplier"; //on load, name the window this
        }

        private void btnSaveProdSup_Click(object sender, EventArgs e)
        {

            try
            {
                product = new Product();
                this.PutProductData(product);

            }
            //sending the completed package to the AddNewPackage method, then retrieving the PackageId to be displayed

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }



        private void PutProductData(Product newProduct)
        {
            try
            {
                if (Validator.IsProvided(txtProdId, "Product Id") &&
                    Validator.IsProvided(txtProdName, "Product Name") &&

                    Validator.IsNonNegativeDecimal(txtProdId, "Product Id") &&
                       Validator.IsNonNegativeDecimal(txtProdName, "Product Name"))

                {
                    product.ProductId = Convert.ToInt32(txtProdId.Text);
                    product.ProdName = txtProdName.Text.ToString();
                    ProductsDB.AddNewProduct(product);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

    }
}
