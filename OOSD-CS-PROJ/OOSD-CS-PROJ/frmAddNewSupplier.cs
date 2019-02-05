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

        //Save the new supplier
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
                if (Validator1.IsProvided(txtSupId, "Supplier Id") &&
                    Validator1.IsProvided(txtSupName, "Supplier Name") &&
                    Validator1.IsNonNegativeDecimal(txtSupId, "Supplier Id"))
                {




                    supplier.SupplierId = Convert.ToInt32(txtSupId.Text);
                    supplier.SupName = txtSupName.Text.ToString();

                    SuppliersDB.AddNewSupplier(supplier);

                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Supplier has been saved");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        //This will add new supplier
        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {
                supplier = new Supplier();
                this.PutSupplierData(supplier);
                

            }
            //sending the completed supplier to the save supplier method

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }
    }
}
