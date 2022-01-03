using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerMaintenance
{
    public static class Validator
    {
        public static string LineEnd { get; set; } = "\n";

        public static string IsPresent(string value, string name)
        {
            string msg = "";
            if (value.Equals(String.Empty))
            {
                msg += name + " is a required field." + LineEnd;
            }
            return msg;
        }

        public static string IsDecimal(string value, string name)
        {
            string msg = "";
            if (!Decimal.TryParse(value, out decimal number))
            {
                msg += name + " must be a decimal value." + LineEnd;
            }
            return msg;
        }

        public static string IsInt32(string value, string name)
        {
            string msg = "";
            if (!Int32.TryParse(value, out int number))
            {
                msg += name + " must be an integer value." + LineEnd;
            }
            return msg;
        }

        public static string IsWithinRange(string value, string name, decimal min, decimal max)
        {
            string msg = "";
            decimal number = Convert.ToDecimal(value);
            if (number < min || number > max)
            {
                msg += name + " must be between " + min + " and " + max + "." + LineEnd;
            }
            return msg;
        }
    }
}
