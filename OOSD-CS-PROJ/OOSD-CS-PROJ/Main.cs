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
            DBCall.SQL();//connecting to the database
            DGVTest.DataSource = DBCall.TB; //DBCall creates the new data table, populates it to DGVTEST
        }

        //When user Clicks "Add new package"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            FormAddNewPackage f2= new FormAddNewPackage();//create a variable for AddPackage form
            f2.ShowDialog();//show the AddPackage form 
        }
    }
}
