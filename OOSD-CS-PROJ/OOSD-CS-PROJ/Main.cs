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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            DBCall.SQL();
            DGVTest.DataSource = DBCall.TB;
        }
    }
}
