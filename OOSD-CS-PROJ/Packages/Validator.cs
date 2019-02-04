using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Packages
{
    public static class Validator
    {
        // tests if  a text box is not empty (required fields)
        public static bool IsProvided(TextBox tb, string name)
        {
            bool result = true; // "innocent until proven guilty"
            if (tb.Text == "")// empty text box
            {
                result = false;
                MessageBox.Show(name + " is required", "Data entry error");
                tb.Focus();
            }
            return result;
        }
        // tests if input is a non-negative decimal
        public static bool IsNonNegativeDecimal(TextBox tb, string name)
        {
            bool result = true;

            decimal num; // parsed number
            if (!Decimal.TryParse(tb.Text, out num)) // if not integer
            {
                result = false;
                MessageBox.Show(name + " has to a decimal number", "Data entry error");
                tb.SelectAll(); // select all text to facilitate change
                tb.Focus();
            }
            else // an int value; check if non-negative
            {
                if (num < 0)
                {
                    result = false;
                    MessageBox.Show(name + " needs to be positive or zero", "Data entry error");
                    tb.SelectAll(); // select all text to facilitate change
                    tb.Focus();
                }
            }
            return result;
        }
    }
}
