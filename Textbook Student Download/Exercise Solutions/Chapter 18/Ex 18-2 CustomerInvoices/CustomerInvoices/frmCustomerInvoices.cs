using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerInvoices
{
    public partial class frmCustomerInvoices : Form
    {
        public frmCustomerInvoices()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Invoice> invoiceList = InvoiceDB.GetInvoices();
            List<Customer> customerList = CustomerDB.GetCustomers();

            //var invoices = from invoice in invoiceList
            //               join customer in customerList
            //               on invoice.CustomerID equals customer.CustomerID
            //               orderby customer.Name, invoice.InvoiceTotal descending
            //               select new { customer.Name, invoice.InvoiceID,
            //                   invoice.InvoiceDate, invoice.InvoiceTotal };

            var invoices =
                invoiceList.Join(customerList,
                    i => i.CustomerID,
                    c => c.CustomerID,
                    (i, c) => new
                    {
                        c.Name,
                        i.InvoiceID,
                        i.InvoiceDate,
                        i.InvoiceTotal
                    })
                .OrderBy(ci => ci.Name)
                .ThenByDescending(ci => ci.InvoiceTotal);

            int j = 0;
            foreach (var invoice in invoices)
            {
                lvInvoices.Items.Add(invoice.Name);
                lvInvoices.Items[j].SubItems.Add(invoice.InvoiceID.ToString());
                lvInvoices.Items[j].SubItems.Add(
                    Convert.ToDateTime(invoice.InvoiceDate).ToShortDateString());
                lvInvoices.Items[j].SubItems.Add(invoice.InvoiceTotal.ToString("c"));
                j += 1;
            }
        }

    }
}
