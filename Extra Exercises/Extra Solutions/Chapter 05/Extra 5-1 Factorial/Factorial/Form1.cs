using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtNumber.Text);
            ulong factorial = 1;

            for (int i = 1; i < number; i++)
                factorial += factorial * (ulong)i;

            txtFactorial.Text = factorial.ToString("n0");
            txtNumber.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
