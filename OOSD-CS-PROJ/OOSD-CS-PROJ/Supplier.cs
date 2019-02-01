using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_CS_PROJ
{
    // Supplier class - used to store DB values upon instantiation 
    class Supplier
    {
        public Supplier() { }

        // create properties
        public int SupplierId { get; set; }

        public string SupName { get; set; }
    }
}
