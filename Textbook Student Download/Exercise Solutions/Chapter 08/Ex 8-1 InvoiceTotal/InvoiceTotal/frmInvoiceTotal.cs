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

        // initialize the variables for the array
        int totalIndex = 0;
        decimal[] invoiceTotalsArray = new decimal[5];

        // initialize the variable for the list
        List<decimal> invoiceTotalsList = new List<decimal>();

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtSubtotal.Text == "")
                {
                    MessageBox.Show(
                        "Subtotal is a required field.", "Entry Error");
                }
                else
                {
                    decimal subtotal = Decimal.Parse(txtSubtotal.Text);
                    if (subtotal > 0 && subtotal < 10000)
                    {
                        decimal discountPercent = 0m;
                        if (subtotal >= 500)
                            discountPercent = .2m;
                        else if (subtotal >= 250 & subtotal < 500)
                            discountPercent = .15m;
                        else if (subtotal >= 100 & subtotal < 250)
                            discountPercent = .1m;
                        decimal discountAmount = subtotal * discountPercent;
                        decimal invoiceTotal = subtotal - discountAmount;

                        discountAmount = Math.Round(discountAmount, 2);
                        invoiceTotal = Math.Round(invoiceTotal, 2);

                        txtDiscountPercent.Text = discountPercent.ToString("p1");
                        txtDiscountAmount.Text = discountAmount.ToString();
                        txtTotal.Text = invoiceTotal.ToString();

                        // add total to array (and update index)
                        invoiceTotalsArray[totalIndex] = invoiceTotal;
                        totalIndex++;

                        // add total to list
                        invoiceTotalsList.Add(invoiceTotal);
                    }
                    else
                    {
                        MessageBox.Show(
                            "Subtotal must be greater than 0 and less than 10,000.",
                            "Entry Error");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Please enter a valid number for the Subtotal field.",
                    "Entry Error");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show(
                    "The index is out of range. Please exit the application",
                    "Entry Error");
            }
            txtSubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //display the message box for the array
            Array.Sort(invoiceTotalsArray);
            string message = "";
            foreach (decimal total in invoiceTotalsArray)
            {
                if (total != 0)
                {
                    message += total.ToString("c") + "\n";
                }
            }
            MessageBox.Show(message, "Order Totals - Array");

            //display the message box for the list
            invoiceTotalsList.Sort();
            message = "";
            foreach (decimal total in invoiceTotalsList)
            {
                message += total.ToString("c") + "\n";
            }
            MessageBox.Show(message, "Order Totals - List");

            this.Close();
        }

    }
}
