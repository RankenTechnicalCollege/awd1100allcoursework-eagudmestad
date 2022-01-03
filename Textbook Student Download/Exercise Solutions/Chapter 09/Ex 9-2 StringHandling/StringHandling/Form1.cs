#nullable enable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnParseName_Click(object sender, System.EventArgs e)
        {
            string fullName = txtFullName.Text;
            string[] names = fullName.Trim().Split(' ');

            string first = "";
            string? middle = null;
            string last = "";

            if (names.Length == 1)
                first = names[0];
            else if (names.Length == 2)
            {
                first = names[0];
                last = names[1];
            }
            else if (names.Length > 2)
            {
                first = names[0];
                middle = names[1];
                last = names[2];
            }

            string name = "First name:\t" + this.ToInitialCap(first) + "\n\n";
            name += "Middle name:\t";
            if (middle != null)
                name += this.ToInitialCap(middle);
            name += "\n\n";
            name += "Last name:\t" + this.ToInitialCap(last);
            MessageBox.Show(name, "Parse Name");
        }

        private void btnEditPhoneNumber_Click(object sender, System.EventArgs e)
        {
            // get the phone number
            string phoneNumber = txtPhoneNumber.Text.Trim();

            // get the 'digits only' phone number
            string digitsOnly = "";
            foreach (char c in phoneNumber)
            {
                if (!(
                    c == '(' || c == ')' ||
                    c == ' ' || c == '-' || c == '.'
                    ))
                {
                    digitsOnly += c;
                }
            }

            // get the 'standard format' phone number
            string standardFormat = digitsOnly.Insert(3, "-");
            standardFormat = standardFormat.Insert(7, "-");

            // display the phone numbers
            MessageBox.Show(
                "Entered:\t\t"
                + phoneNumber + "\n\n" +
                "Digits only:\t"
                + digitsOnly + "\n\n" +
                "Standard format:\t"
                + standardFormat,
                "Edit Phone Number");
        }

        private string ToInitialCap(string s)
        {
            if (s.Length > 0)
            {
                string initialCap = s.Substring(0, 1).ToUpper();
                string lowerCaseLetters = s.Substring(1).ToLower();
                s = initialCap + lowerCaseLetters;
            }
            return s;
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
}
