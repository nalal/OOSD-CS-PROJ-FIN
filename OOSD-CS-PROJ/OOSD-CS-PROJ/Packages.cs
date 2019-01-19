using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace OOSD_CS_PROJ
{
    class Packages
    {
        public static List<string> PackageID = new List<string>();
        public static void GetPID()
        {
            DataTable TB = DBCall.GetPackages();
            foreach(DataRow row in TB.Rows)
            {
                PackageID.Add(row.Field<string>("PackageID").ToString());
            }
        }
    }
}
