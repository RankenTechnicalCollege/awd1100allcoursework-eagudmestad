using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

		int numberOfInvoices = 0;
		decimal totalOfInvoices = 0m;
		decimal invoiceAverage = 0m;
		decimal largestInvoice = 0m;
		decimal smallestInvoice = Decimal.MaxValue;

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			decimal subtotal = Convert.ToDecimal(txtEnterSubtotal.Text);
			decimal discountPercent = .25m;
			decimal discountAmount = Math.Round(subtotal * discountPercent, 2);
			decimal invoiceTotal = subtotal - discountAmount;

			txtSubtotal.Text = subtotal.ToString("c");
			txtDiscountPercent.Text = discountPercent.ToString("p1");
			txtDiscountAmount.Text = discountAmount.ToString("c");
			txtTotal.Text = invoiceTotal.ToString("c");

			numberOfInvoices++;
			totalOfInvoices += invoiceTotal;
			invoiceAverage = totalOfInvoices / numberOfInvoices;
			largestInvoice = Math.Max(largestInvoice, invoiceTotal);
			smallestInvoice = Math.Min(smallestInvoice, invoiceTotal);

			txtNumberOfInvoices.Text = numberOfInvoices.ToString();
			txtTotalOfInvoices.Text = totalOfInvoices.ToString("c");
			txtInvoiceAverage.Text = invoiceAverage.ToString("c");
			txtLargestInvoice.Text = largestInvoice.ToString("c");
			txtSmallestInvoice.Text = smallestInvoice.ToString("c");

			txtEnterSubtotal.Text = "";
			txtEnterSubtotal.Focus();
		}

		private void btnClearTotals_Click(object sender, System.EventArgs e)
		{
			numberOfInvoices = 0;
			totalOfInvoices = 0m;
			invoiceAverage = 0m;
			largestInvoice = 0m;
			smallestInvoice = Decimal.MaxValue;

			txtNumberOfInvoices.Text = "";
			txtTotalOfInvoices.Text = "";
			txtInvoiceAverage.Text = "";
			txtLargestInvoice.Text = "";
			txtSmallestInvoice.Text = "";

			txtEnterSubtotal.Focus();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
