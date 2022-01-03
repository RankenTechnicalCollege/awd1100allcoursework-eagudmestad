using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValue
{
    public partial class frmFutureValue : Form
    {
        public frmFutureValue()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    decimal monthlyInvestment =
                        Convert.ToDecimal(txtMonthlyInvestment.Text);
                    decimal yearlyInterestRate =
                        Convert.ToDecimal(txtInterestRate.Text);
                    int years = Convert.ToInt32(txtYears.Text);

                    int months = years * 12;
                    decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;

                    decimal futureValue = CalculateFutureValue(
                        monthlyInvestment, monthlyInterestRate, months);
                    //throw new Exception("An unknown exception occurred.");

                    txtFutureValue.Text = futureValue.ToString("c");
                    txtMonthlyInvestment.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }
        }

        public bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            // Validate the Monthly Investment text box
            errorMessage += IsDecimal(txtMonthlyInvestment.Text, txtMonthlyInvestment.Tag.ToString());
            errorMessage += IsWithinRange(txtMonthlyInvestment.Text, txtMonthlyInvestment.Tag.ToString(), 1, 1000);

            // Validate the Yearly Interest Rate text box
            errorMessage += IsDecimal(txtInterestRate.Text, txtInterestRate.Tag.ToString());
            errorMessage += IsWithinRange(txtInterestRate.Text, txtInterestRate.Tag.ToString(), 1, 20);

            // Validate the Number of Years text box
            errorMessage += IsInt32(txtYears.Text, txtYears.Tag.ToString());
            errorMessage += IsWithinRange(txtYears.Text, txtYears.Tag.ToString(), 1, 40);

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        public static string IsPresent(string value, string name)
        {
            string msg = "";
            if (value == "")
            {
                msg += name + " is a required field.\n";
            }
            return msg;
        }

        public static string IsDecimal(string value, string name)
        {
            string msg = "";
            if (!Decimal.TryParse(value, out _))
            {
                msg += name + " must be a valid decimal value.\n";
            }
            return msg;
        }

        public static string IsInt32(string value, string name)
        {
            string msg = "";
            if (!Int32.TryParse(value, out _))
            {
                msg += name + " must be a valid integer value.\n";
            }
            return msg;
        }

        public static string IsWithinRange(string value, string name, decimal min, decimal max)
        {
            string msg = "";
            if (Decimal.TryParse(value, out decimal number))
            {
                if (number < min || number > max)
                {
                    msg += name + " must be between " + min + " and " + max + ".\n";
                }
            }
            return msg;
        }

        private decimal CalculateFutureValue(decimal monthlyInvestment,
           decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment)
                    * (1 + monthlyInterestRate);
            }

            return futureValue;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
