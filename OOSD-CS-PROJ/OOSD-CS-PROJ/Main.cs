using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace OOSD_CS_PROJ
{
    public partial class Main : Form
    {
        static List<string> ddl = new List<string>();
        public Main()
        {
            InitializeComponent();
            SQLCon();
            DBCall.InitSQL();
            dGView.DataSource = DBCall.GetPackages();
            PopulateList();
            dDLSelected = ddl[0].ToString();
        }
        private void SQLCon()
        {
            Form lp = new ConnectionPage();
            lp.ShowDialog();
            if(ConnectionPage.Term)
            {
                Application.Exit();
            }
            if(!DBCall.CSucces)
            {
                SQLCon();
            }
        }
        private void bindRefresh()
        {
            object db = dGView.DataSource;
            dGView.DataSource = null;
            dGView.DataSource = db;
        }

        public void PopulateList()
        {
            ddl.Clear();

            foreach (DataGridViewColumn col in dGView.Columns)
            {
                ddl.Add(col.Name.ToString());
            }
            dDLSearch.DataSource = null;
            dDLSearch.DataSource = ddl;
        }
        private void packagesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.packagesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.travelExpertsDataSet);

        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelExpertsDataSet.Packages' table. You can move, or remove it, as needed.
            this.packagesTableAdapter.Fill(this.travelExpertsDataSet.Packages);


            ClearTxtBoxes();

        }

        private void DGVTest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVTest_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dGView.SelectedRows)
            {
                //populate text box with column data
                TextBox[] textboxes = { txtID, txtName, txtStartDate, txtEndDate,
                txtDesc, txtBasePrice, txtAgencyComm};
                foreach (DataGridViewCell i in row.Cells)
                {
                    if (i.Value != null)
                    {
                        string info = i.Value.ToString();
                        int tbid = i.ColumnIndex;
                        textboxes[tbid].Text = info;
                    }
                }


            }
        }

        string dDLSelected = "";
        private void dDLSearchPkg_SelectedIndexChanged(object sender, EventArgs e)
        {
            // create string variable for what is selected from the dropdown list
            if (dDLSearch.SelectedValue != null)
            {
                dDLSelected = dDLSearch.SelectedValue.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtSearch.Text);
            bindRefresh();

            Cull();
        }

        private void Cull()
        {
            int CID = dDLSearch.SelectedIndex;
            List<DataGridViewRow> RowsToDelete = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dGView.Rows)
                if (row.Cells[CID].Value != null &&
                     row.Cells[CID].Value.ToString().Contains(txtSearch.Text) != true) RowsToDelete.Add(row);
            foreach (DataGridViewRow row in RowsToDelete)
            {
                //Currency manager hackery because I cannot hide irrelivant column without doing so
                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dGView.DataSource];
                currencyManager1.SuspendBinding();
                dGView.Rows[row.Index].Visible = false;
                currencyManager1.ResumeBinding();
            }
            RowsToDelete.Clear();
        }

        // all text boxes are cleared
        public void ClearTxtBoxes()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtStartDate.Text = "";
            txtEndDate.Text = "";
            txtDesc.Text = "";
            txtBasePrice.Text = "";
            txtAgencyComm.Text = "";

        }

        private void dGView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Err.SQLErrorParser(sender, e);
        }

        private void btnPkgs_Click_1(object sender, EventArgs e)
        {
            dGView.DataSource = null;
            dGView.DataSource = DBCall.GetPackages();
            txtStartDate.Visible = true;
            txtEndDate.Visible = true;
            txtDesc.Visible = true;
            txtBasePrice.Visible = true;
            txtAgencyComm.Visible = true;
            ClearTxtBoxes();
            lblDetails.Text = "Package Details";
            lblSearch.Text = "Search Packages:";
            PopulateList();
        }

        private void btnPrdts_Click_1(object sender, EventArgs e)
        {
            dGView.DataSource = null;
            dGView.DataSource = DBCall.GetProducts();
            txtStartDate.Visible = false;
            txtEndDate.Visible = false;
            txtDesc.Visible = false;
            txtBasePrice.Visible = false;
            txtAgencyComm.Visible = false;
            ClearTxtBoxes();
            lblDetails.Text = "Product Details";
            lblSearch.Text = "Search Products:";
            PopulateList();
        }

        private void btnSupps_Click_1(object sender, EventArgs e)
        {
            dGView.DataSource = null;
            dGView.DataSource = DBCall.GetSuppliers();
            txtStartDate.Visible = false;
            txtEndDate.Visible = false;
            txtDesc.Visible = false;
            txtBasePrice.Visible = false;
            txtAgencyComm.Visible = false;
            ClearTxtBoxes();
            lblDetails.Text = "Supplier Details";
            lblSearch.Text = "Search Suppliers:";
            PopulateList();
        }

        private void btnPrdctSupps_Click_1(object sender, EventArgs e)
        {
            dGView.DataSource = null;
            dGView.DataSource = DBCall.GetPSuppliers();
            txtStartDate.Visible = true;
            txtEndDate.Visible = false;
            txtDesc.Visible = false;
            txtBasePrice.Visible = false;
            txtAgencyComm.Visible = false;
            ClearTxtBoxes();
            lblDetails.Text = "Product Supplier Details";
            lblSearch.Text = "Search Product Suppliers:";
            PopulateList();
        }
    }
}
