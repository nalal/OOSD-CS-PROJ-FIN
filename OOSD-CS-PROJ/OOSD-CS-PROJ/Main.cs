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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            DBCall.InitSQL();
            dGVPkg.DataSource = DBCall.GetPackages();
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

        }

        private void DGVTest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVTest_SelectionChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dGVPkg.SelectedRows)
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

        }
    }
}
