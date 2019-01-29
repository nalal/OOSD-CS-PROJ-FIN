using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_CS_PROJ
{
    // ProdSupplier class - used to store DB values upon instantiation 
    class ProdSupplier
    {
        public ProdSupplier() { }

        // create properties
        public int ProductSupplierID { get; set; }

        public int ProductID{ get; set; }

        public int SupplierID{ get; set; }

    }
}
