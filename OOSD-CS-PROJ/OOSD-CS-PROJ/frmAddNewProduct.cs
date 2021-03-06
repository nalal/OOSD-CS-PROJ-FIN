﻿using System;
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
        //Author: Helen Lin 

        //initializing product
        private Product product; //new added supplier

        public frmAddNewProduct()
        {
            InitializeComponent();
        }
        private void frmAddNewProduct_Load(object sender, EventArgs e)
        {
            this.Text = "Add New Product";//on load, name the window this
        }
        private void frmAddNewProdSupplier_Load(object sender, EventArgs e)
        {
            this.Text = "Add New Product Supplier"; //on load, name the window this
        }
        private void PutProductData(Product newProduct)
        {
            try
            {
                if (Validator1.IsProvided(txtProdName, "Product Name"))

                {
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
        //This will Add new product
        private void btnAddNewProd_Click(object sender, EventArgs e)
        {
            
            try
            {
                product = new Product();
                this.PutProductData(product);
                MessageBox.Show("Product has been saved");
            }
            //sending the completed package to the AddNewPackage method, then retrieving the PackageId to be displayed
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
