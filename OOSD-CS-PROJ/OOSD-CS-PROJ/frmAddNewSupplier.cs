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
    public partial class frmAddNewSupplier : Form
    {
        public frmAddNewSupplier()
        {
            InitializeComponent();
        }
//Author: Helen Lin 
        private void frmAddNewSupplier_Load(object sender, EventArgs e)
        {
            this.Text = "Add New Supplier"; //on load, name the window this
        }

        //Author: Helen Lin 
        private Supplier supplier; //new added supplier

        private void frmAddNewProdSupplier_Load(object sender, EventArgs e)
        {
            this.Text = "Add New Product Supplier"; //on load, name the window this
        }

        private void btnSaveProdSup_Click(object sender, EventArgs e)
        {

            try
            {
                supplier = new Supplier();
                this.PutSupplierData(supplier);

            }
            //sending the completed package to the AddNewPackage method, then retrieving the PackageId to be displayed

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }



        private void PutSupplierData(Supplier newsupplier)
        {
            try
            {
                if (Validator.IsProvided(txtSupId, "Supplier Id") &&
                    Validator.IsProvided(txtSupName, "Supplier Name") &&
                    Validator.IsNonNegativeDecimal(txtSupId, "Supplier Id") &&
                       Validator.IsNonNegativeDecimal(txtSupName, "Supplier Name"))
                {




                    supplier.SupplierId = Convert.ToInt32(txtSupId.Text);
                    supplier.SupName = txtSupName.Text.ToString();

                    SuppliersDB.AddNewSupplier(supplier);

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
