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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            int domainIndex = email.IndexOf("@") + 1;
            if (domainIndex > 0)
            {
                string userName = email.Substring(0, domainIndex - 1);
                string domainName = email.Substring(domainIndex);

                MessageBox.Show("User name: " + userName + "\n" +
                    "Domain name: " + domainName, "Parsed String");
            }
            else
            {
                MessageBox.Show("The email address must contain an @ sign.", "Entry Error");
            }
            txtEmail.Focus();
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text.Trim();
            string state = txtState.Text.Trim();
            state = state.ToUpper();
            string zipCode = txtZipCode.Text.Trim();

            int cityLength = city.Length;
            string cityStateZip = city + state + zipCode;
            cityStateZip = cityStateZip.Insert(cityLength, ", ");
            cityStateZip = cityStateZip.Insert(cityLength + 4, " ");

            MessageBox.Show("City, State, Zip: " + cityStateZip, "Formatted String");
            txtCity.Focus();
        }
    }
}
