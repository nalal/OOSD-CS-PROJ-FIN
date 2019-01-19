using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSD_CS_PROJ
{
    class Err
    {
        //check if string is null
        public static bool IsNonNullString(string s)
        {
            bool res = true;
            if(s == null || s == "")
            {
                res = false;
            }
            return res;
        }
        //check if list is null
        public static bool IsNonNullList(List<string> l)
        {
            bool res = true;
            if (l.Count == 0)
            {
                res = false;
            }
            return res;
        }
        //check if string array is null
        public static bool IsNonNullStringArray(string[] l)
        {
            bool res = true;
            if (l.Count() == 0)
            {
                res = false;
            }
            return res;
        }
    }
}
