using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private CustomerList customers = new CustomerList();

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            customers.Changed += new CustomerList.ChangeHandler(HandleChange);
            customers.Fill();
            FillCustomerListBox();
        }

        private void FillCustomerListBox()
        {
            lstCustomers.Items.Clear();
            for (int i = 0; i < customers.Count; i++)
            {
                Customer c = customers[i];
                lstCustomers.Items.Add(c.GetDisplayText());
            }
        }

        private void btnAddWholesale_Click(object sender, EventArgs e)
        {
            Customer customer;
            // TODO: Add code that lets the user enter a new wholesale customer
            // and adds that customer to the customer list
        }

        private void btnAddRetail_Click(object sender, EventArgs e)
        {
            Customer customer;
            // TODO: Add code that lets the user enter a new retail customer
            // and adds that customer to the customer list
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstCustomers.SelectedIndex;
            if (i != -1)
            {
                Customer customer = customers[i];
                string message = "Are you sure you want to delete "
                    + customer.FirstName + " " + customer.LastName + "?";
                DialogResult button = MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    customers -= customer;
                }
            }
        }

        private void HandleChange(CustomerList list)
        {
            customers.Save();
            FillCustomerListBox();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
