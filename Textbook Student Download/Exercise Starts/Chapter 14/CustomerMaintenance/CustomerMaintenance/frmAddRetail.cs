using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    public partial class frmAddRetail : Form
    {
        public frmAddRetail()
        {
            InitializeComponent();
        }

        private Customer customer = null;

        public Customer GetNewCustomer()
        {
            this.ShowDialog();
            return customer;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (IsValidData())
            {
                // TODO: Add code that creates a new retail customer
                this.Close();
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += Validator.IsPresent(txtFirstName.Text, txtFirstName.Tag.ToString());
            errorMessage += Validator.IsPresent(txtLastName.Text, txtLastName.Tag.ToString());
            errorMessage += Validator.IsValidEmail(txtEmail.Text, txtEmail.Tag.ToString());
            errorMessage += Validator.IsPresent(txtHomePhone.Text, txtHomePhone.Tag.ToString());

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
