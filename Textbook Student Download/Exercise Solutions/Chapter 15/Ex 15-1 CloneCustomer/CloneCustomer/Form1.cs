using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloneCustomer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Customer customer;
        private List<Customer> customers;

        private void Form1_Load(object sender, System.EventArgs e)
        {
            customer = new Customer("John", "Mendez", "jmendez@msysco.com");
            lblCustomer.Text = customer.GetDisplayText();
        }

        private void btnClone_Click(object sender, System.EventArgs e)
        {
            if (IsValidData())
            {
                int count = Convert.ToInt16(txtCopies.Text);
                customers = MakeCustomerList(customer, count);
                lstCustomers.Items.Clear();
                foreach (Customer c in customers)
                {
                    lstCustomers.Items.Add(c.GetDisplayText());
                }
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += Validator.IsInt32(txtCopies.Text, txtCopies.Tag.ToString());

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        private List<Customer> MakeCustomerList(Customer c, int count)
        {
            List<Customer> customerList = new List<Customer>();
            for (int i = 0; i < count; i++)
            {
                Customer cust = (Customer)c.Clone();
                customerList.Add(cust);
            }
            return customerList;
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
}
