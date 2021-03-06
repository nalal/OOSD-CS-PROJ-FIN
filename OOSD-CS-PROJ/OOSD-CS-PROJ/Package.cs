﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_CS_PROJ
{
    public class Package
    {
        public Package() { }

        public int PackageId { get; set; }

        public string PkgName { get; set; }

        public string PkgStartDate { get; set; }

        public string PkgEndDate { get; set; }

        public string PkgDesc { get; set; }

        public decimal PkgBasePrice { get; set; }

        public decimal PkgAgencyCommission { get; set; }

        public string ProdName { get; set; }
    }
}
