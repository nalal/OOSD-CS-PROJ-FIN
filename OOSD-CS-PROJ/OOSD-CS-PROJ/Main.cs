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
        List<string> ddl = new List<string>();
        public Main()
        {
            InitializeComponent();
            DBCall.InitSQL();
            dGView.DataSource = DBCall.GetPackages();
            PopulateList();
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
            dDLSearch.DataSource = ddl;


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
                    string info = i.Value.ToString();
                    int tbid = i.ColumnIndex;
                    textboxes[tbid].Text = info;

                }


            }
        }

        private void dDLSearchPkg_SelectedIndexChanged(object sender, EventArgs e)
        {
            // create string variable for what is selected from the dropdown list
            string dDLSelected = dDLSearch.SelectedValue.ToString();

            foreach (DataGridView col in dGView.SelectedRows)
            {
                if (dDLSelected == col.ToString())
                {

                }
            }

        }
    }
}
