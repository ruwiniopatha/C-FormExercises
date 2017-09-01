using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Form1
{
    public class Validation
    {
        public Validation()
        {

        }
        /// <summary>
        /// Use to check whether the sent string is a 
        /// null value or not.
        /// 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Boolean check_values_are_null(string value) 
        {

            if (value == "")
                return false;
            else
                return true;
        }

        /// <summary>
        /// This method use to provide a validation method
        /// to check whether the string is a numberic value or not.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Boolean validate_as_numbers(string value)
        {
            try
            {
                int temp = Convert.ToInt32(value);
                return true;
            }
            catch (Exception h)
            {
                MessageBox.Show("Please provide number only");
            }
            return false;
        }

        /// <summary>
        /// This method use to validate the string which is passed to the
        /// method consists alphatical charachters only.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Boolean validate_as_letters(string value)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(value, "^[a-zA-Z]"))
            {
                return false;
            }
            return true;
        }
    }
}
