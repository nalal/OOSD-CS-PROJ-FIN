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
    public partial class frmAddNewProdSupplier : Form
    {
        public frmAddNewProdSupplier()
        {
            InitializeComponent();
        }

        //Author: Helen Lin 
        private ProdSupplier prodSupplier; //new added product supplier

        private void frmAddNewProdSupplier_Load(object sender, EventArgs e)
        {
            this.Text = "Add New Product Supplier"; //on load, name the window this
        }

        private void btnSaveProdSup_Click(object sender, EventArgs e)
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
                if (Validator.IsProvided(txtProdId, "Product Id") &&
                    Validator.IsProvided(txtProdSupId, "Product Supplier Id") &&
                    Validator.IsProvided(txtSupId, "Supplier Id") &&
                    Validator.IsNonNegativeDecimal(txtProdId, "Product Id") &&
                       Validator.IsNonNegativeDecimal(txtProdSupId, "Product Supplier Id") &&
                       Validator.IsNonNegativeDecimal(txtSupId, "Supplier Id"))
                {



                   
                    prodSupplier.ProductSupplierId = Convert.ToInt32(txtProdSupId.Text);
                    prodSupplier.ProductId = Convert.ToInt32(txtProdId.Text);
                    prodSupplier.SupplierId = Convert.ToInt32(txtSupId.Text);
                    ProdSuppliersDB.AddNewProdSupplier(prodSupplier);

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
