using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOSD_CS_PROJ
{
    class Err
    {
        //Input errors
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
            //Error message multiline relay for the lazy
        public static void EMA(string[] i, string t)
        {
            string c = "";
            foreach (string s in i)
            {
                c = c + s + "\n";
            }
            MessageBox.Show(c,t);
        }
        //MSSQL Error Handling
            //Catch timmy
        public static bool SQLIsNonDestructive(string inp)
        {
            bool res = true;
            if(inp.Contains("DROP"))
            {
                res = false;
            }
            return res;
        }
            //Generic error parser
        public static void SQLErrorParser(object sender, DataGridViewDataErrorEventArgs anError)
        {             
            //Checks for error type and displays in message box
            MessageBox.Show("An error occured while you were attempting the following opperation(s): \n" +
                anError.Context.ToString() + "\n" +
                "\nYou received the following error \n" +
                anError.Exception.ToString() +
                "\n" +
                "\nMake certain your table input was valid for that column type and remember to click on the cell for 'Discontinued' to initialize it");
            if ((anError.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";

                anError.ThrowException = false;
            }

}
