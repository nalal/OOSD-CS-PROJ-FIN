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
        public int ProductSupplierId { get; set; }

        public int ProductId{ get; set; }

        public int SupplierId{ get; set; }

        public string ProdName { get; set; }

        public string SupName { get; set; }

    }
}
