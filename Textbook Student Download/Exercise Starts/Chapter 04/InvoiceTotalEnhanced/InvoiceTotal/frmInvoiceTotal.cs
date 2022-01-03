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

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			decimal subtotal = Decimal.Parse(txtSubtotal.Text);
			decimal discountPercent = .25m;
			decimal discountAmount = subtotal * discountPercent;
			decimal invoiceTotal = subtotal - discountAmount;

			discountAmount = Math.Round(discountAmount, 2);
			invoiceTotal = Math.Round(invoiceTotal, 2);

			txtDiscountPercent.Text = discountPercent.ToString("p1");
			txtDiscountAmount.Text = discountAmount.ToString();
			txtTotal.Text = invoiceTotal.ToString();

			txtSubtotal.Focus();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}