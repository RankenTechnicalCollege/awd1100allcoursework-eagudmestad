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

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
}
