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
            DBCall.InitSQL();
            bindRefresh();
            PopulateList();
            dDLSelected = ddl[0].ToString();
        }
        private void bindRefresh()
        {
            dGView.DataSource = null;
            dGView.DataSource = DBCall.GetPackages();
        }

        public void PopulateList()
        {
            ddl.Clear();

            foreach (DataGridViewColumn col in dGView.Columns)
            {
                ddl.Add(col.Name.ToString());
            }

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

            //  * * set the data source for the drop down list
            dDLSearch.DataSource = ddl;

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
                TextBox[] textboxes = { txtPkgID, txtPkgName, txtPkgStartDate, txtPkgEndDate,
                txtPkgDesc, txtPkgBasePrice, txtPkgAgencyComm};
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
            
             dDLSelected = dDLSearch.SelectedValue.ToString();
             
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
            txtPkgID.Text = "";
            txtPkgName.Text = "";
            txtPkgStartDate.Text = "";
            txtPkgEndDate.Text = "";
            txtPkgDesc.Text = "";
            txtPkgBasePrice.Text = "";
            txtPkgAgencyComm.Text = "";

        }

        private void dGView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Err.SQLErrorParser(sender, e);
        }
    }
}
