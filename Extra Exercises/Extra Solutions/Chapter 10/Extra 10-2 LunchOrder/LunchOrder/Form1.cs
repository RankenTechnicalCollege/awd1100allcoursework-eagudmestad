using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const decimal SalesTaxPct = 0.0775m;

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            int addOns = 0;
            decimal subtotal = 0;

            if (chkAddOn1.Checked)
                addOns += 1;
            if (chkAddOn2.Checked)
                addOns += 1;
            if (chkAddOn3.Checked)
                addOns += 1;

            if (rdoHamburger.Checked)
                subtotal = 6.95m + (addOns * 0.75m);
            else if (rdoPizza.Checked)
                subtotal = 5.95m + (addOns * 0.5m);
            else if (rdoSalad.Checked)
                subtotal = 4.95m + (addOns * 0.25m);

            decimal salesTax = subtotal * SalesTaxPct;
            decimal total = subtotal + salesTax;

            txtSubtotal.Text = subtotal.ToString("c");
            txtSalesTax.Text = salesTax.ToString("c");
            txtOrderTotal.Text = total.ToString("c");
        }

        private void MainCourse_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHamburger.Checked)
            {
                gbxAddOnItems.Text = "Add-on items ($.75/each)";
                chkAddOn1.Text = "Lettuce, tomato, and onions";
                chkAddOn2.Text = "Ketchup, mustard, and mayo";
                chkAddOn3.Text = "French fries";
            }
            else if (rdoPizza.Checked)
            {
                gbxAddOnItems.Text = "Add-on items ($.50/each)";
                chkAddOn1.Text = "Pepperoni";
                chkAddOn2.Text = "Sausage";
                chkAddOn3.Text = "Olives";
            }
            else if (rdoSalad.Checked)
            {
                gbxAddOnItems.Text = "Add-on items ($.25/each)";
                chkAddOn1.Text = "Croutons";
                chkAddOn2.Text = "Bacon bits";
                chkAddOn3.Text = "Bread sticks";
            }
            ClearAddOns();
            ClearTotals();
        }

        private void AddOn_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
        }

        private void ClearTotals()
        {
            txtSubtotal.Text = "";
            txtSalesTax.Text = "";
            txtOrderTotal.Text = "";
        }

        private void ClearAddOns()
        {
            chkAddOn1.Checked = false;
            chkAddOn2.Checked = false;
            chkAddOn3.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
