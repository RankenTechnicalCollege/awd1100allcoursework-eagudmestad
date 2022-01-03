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

        private List<Customer> customers = null;

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            customers = CustomerDB.GetCustomers();
            FillCustomerListBox();
        }

        private void FillCustomerListBox()
        {
            lstCustomers.Items.Clear();
            foreach (Customer c in customers)
            {
                lstCustomers.Items.Add(c.GetDisplayText());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddCustomer addCustomerForm = new frmAddCustomer();
            Customer customer = addCustomerForm.GetNewCustomer();
            if (customer != null)
            {
                customers.Add(customer);
                CustomerDB.SaveCustomers(customers);
                FillCustomerListBox();
            }
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
                    customers.Remove(customer);
                    CustomerDB.SaveCustomers(customers);
                    FillCustomerListBox();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
