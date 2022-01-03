using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int cents = Convert.ToInt32(txtChange.Text);

            int quarters = (int)(cents / 25);
            cents = cents % 25;

            int dimes = (int)(cents / 10);
            cents = cents % 10;

            int nickels = (int)(cents / 5);

            int pennies = cents % 5;

            txtQuarters.Text = quarters.ToString();
            txtDimes.Text = dimes.ToString();
            txtNickels.Text = nickels.ToString();
            txtPennies.Text = pennies.ToString();

            txtChange.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
