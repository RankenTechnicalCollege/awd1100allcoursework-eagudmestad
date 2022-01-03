using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace FutureValue
{
    public partial class frmFutureValue : Form
    {
        public frmFutureValue()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    decimal monthlyInvestment =
                        Decimal.Parse(txtMonthlyInvestment.Text, NumberStyles.Currency);
                    decimal yearlyInterestRate =
                        Decimal.Parse(txtInterestRate.Text, NumberStyles.Number);
                    int years = Int32.Parse(txtYears.Text, NumberStyles.None);

                    int months = years * 12;
                    decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;
                    decimal futureValue = CalculateFutureValue(
                        monthlyInvestment, monthlyInterestRate, months);

                    decimal interestRatePercent = yearlyInterestRate / 100;
                    txtMonthlyInvestment.Text = monthlyInvestment.ToString("c");
                    txtInterestRate.Text = interestRatePercent.ToString("p");
                    txtYears.Text = years.ToString();
                    txtFutureValue.Text = futureValue.ToString("c");

                    txtMonthlyInvestment.Focus();
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show(
                    "An overflow exception has occurred. Please enter smaller values.",
                    "Entry Error");
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
            errorMessage += IsCurrency(txtMonthlyInvestment.Text, txtMonthlyInvestment.Tag.ToString());
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

        // the new IsDecimal method
        public static string IsDecimal(string value, string name)
        {
            string msg = "";
            if (!Decimal.TryParse(value, out _))
            {
                msg += name + " must be a valid decimal value.\n";
            }
            return msg;
        }

        // the new IsCurrency method
        public static string IsCurrency(string value, string name)
        {
            string msg = "";
            if (!Decimal.TryParse(value, NumberStyles.Currency, CultureInfo.CurrentCulture, out decimal number))
            {
                msg += name + " must be in currency format.\n";
            }
            return msg;
        }

        // the new IsInt32 method
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
            decimal interestRateMonthly, int months)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment)
                    * (1 + interestRateMonthly);
            }
            return futureValue;
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
