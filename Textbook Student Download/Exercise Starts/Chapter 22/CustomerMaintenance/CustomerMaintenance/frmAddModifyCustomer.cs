using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CustomerMaintenance.Model.DataLayer;

namespace CustomerMaintenance
{
    public partial class frmAddModifyCustomer : Form
    {
        public frmAddModifyCustomer()
        {
            InitializeComponent();            
        }

        public Customers Customer { get; set; }
        public bool AddCustomer { get; set; }
        public List<States> States { get; set; }

        private void frmAddModifyCustomer_Load(object sender, EventArgs e)
        {
            this.LoadComboBox();
            if (AddCustomer)
            {
                this.Text = "Add Customer";
                cboStates.SelectedIndex = -1;
            }
            else
            {
                this.Text = "Modify Customer";
                this.DisplayCustomer();
            }
        }

        private void LoadComboBox()
        {
            cboStates.DataSource = States;
            cboStates.DisplayMember = "StateName";
            cboStates.ValueMember = "StateCode";
        }

        private void DisplayCustomer()
        {
            txtName.Text = Customer.Name;
            txtAddress.Text = Customer.Address;
            txtCity.Text = Customer.City;
            cboStates.SelectedValue = Customer.State;
            txtZipCode.Text = Customer.ZipCode;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (AddCustomer)
                {
                    Customer = new Customers();
                }
                this.LoadCustomer();
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";
            errorMessage += Validator.IsPresent(txtName.Text, txtName.Tag.ToString());
            errorMessage += Validator.IsPresent(txtAddress.Text, txtAddress.Tag.ToString());
            errorMessage += Validator.IsPresent(txtCity.Text, txtCity.Tag.ToString());
            errorMessage += Validator.IsPresent(txtZipCode.Text, txtZipCode.Tag.ToString());
            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
                txtName.Focus();
            }
            return success;
        }

        private void LoadCustomer()
        {
            Customer.Name = txtName.Text;
            Customer.Address = txtAddress.Text;
            Customer.City = txtCity.Text;
            Customer.State = cboStates.SelectedValue.ToString();
            Customer.ZipCode = txtZipCode.Text;
        }
    }
}