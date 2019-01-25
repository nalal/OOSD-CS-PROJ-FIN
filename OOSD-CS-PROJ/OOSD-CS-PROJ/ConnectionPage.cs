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
    public partial class ConnectionPage : Form
    {
        public static bool Local = false;
        public static string Name = "";
        public static string User = "";
        public static string Pass = "";
        public static bool Term = false;
        public ConnectionPage()
        {
            InitializeComponent();
            TBUser.Enabled = false;
            TBPass.Enabled = false;
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            if(RBLocal.Checked && Err.IsNonNullString(TBName.Text))
            {
                DBCall.InitSQL();
                Name = TBName.Text;
                Local = true;
            }
            if(RBRemote.Checked && Err.IsNonNullString(TBName.Text))
            {
                DBCall.InitSQL();
                Local = false;
                Name = TBName.Text;
                User = TBUser.Text;
                Pass = TBPass.Text;
            }
        }

        private void RBRemote_Click(object sender, EventArgs e)
        {
            TBName.Text = "";
            TBUser.Enabled = true;
            TBPass.Enabled = true;
        }

        private void RBLocal_Click(object sender, EventArgs e)
        {
            TBName.Text = "";
            TBUser.Enabled = false;
            TBPass.Enabled = false;
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            Term = true;
            Close();
        }
    }
}
