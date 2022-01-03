using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal income = Convert.ToDecimal(txtIncome.Text);

            decimal tax = 0m;

            if (income <= 9875)
                tax = (int)(income * .10m);
            else if (income > 9875 && income <= 40125)
                tax = 987.5m + (int)((income - 9875) * .12m);
            else if (income > 40125 && income <= 85525)
                tax = 4617.5m + (int)((income - 40125) * .22m);
            else if (income > 85525 && income <= 163300)
                tax = 14605.5m + (int)((income - 85525) * .24m);
            else if (income > 163300 && income <= 207350)
                tax = 33271.5m + (int)((income - 163300) * .32m);
            else if (income > 207351 && income <= 518400)
                tax = 47367.5m + (int)((income - 518400) * .35m);
            else if (income > 518401)
                tax = 156235m + (int)((income - 518400) * .37m);

            txtTax.Text = tax.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
