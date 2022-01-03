using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    decimal operand1 = Convert.ToDecimal(txtOperand1.Text);
                    string operator1 = txtOperator.Text;
                    decimal operand2 = Convert.ToDecimal(txtOperand2.Text);
                    decimal result = Calculate(operand1, operator1, operand2);

                    result = Math.Round(result, 4);
                    this.txtResult.Text = result.ToString();
                    txtOperand1.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                ex.GetType().ToString() + "\n" +
                ex.StackTrace, "Exception");
            }

        }

        private decimal Calculate(decimal operand1, string operator1,
            decimal operand2)
        {
            decimal result = 0;
            if (operator1 == "+")
                result = operand1 + operand2;
            else if (operator1 == "-")
                result = operand1 - operand2;
            else if (operator1 == "*")
                result = operand1 * operand2;
            else if (operator1 == "/")
                result = operand1 / operand2;
            return result;
        }

        public bool IsValidData()
        {
            return
                // Validate the Operand1 text box
                IsPresent(txtOperand1, "Operand 1") &&
                IsDecimal(txtOperand1, "Operand 1") &&
                IsWithinRange(txtOperand1, "Operand 1", 0, 1000000) &&

                // Validate the Operator text box
                IsPresent(txtOperator, "Operator") &&
                IsOperator(txtOperator, "Operator") &&

                // Validate the Operand2 text box
                IsPresent(txtOperand2, "Operand 2") &&
                IsDecimal(txtOperand2, "Operand 2") &&
                IsWithinRange(txtOperand2, "Operand 2", 0, 1000000) && 
                IsValidOperation(txtOperand2, txtOperator.Text);
        }

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsDecimal(TextBox textBox, string name)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a decimal number.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsWithinRange(TextBox textBox, string name,
            decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min +
                    " and " + max + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsOperator(TextBox textBox, string name)
        {
            if (textBox.Text == "+" ||
                textBox.Text == "-" ||
                textBox.Text == "*" ||
                textBox.Text == "/")
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " is not valid.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsValidOperation(TextBox divisor, string operation)
        {
            decimal value = Decimal.Parse(divisor.Text);
            if (value == 0 && operation == "/")
            {
                MessageBox.Show("You may not divide by zero.", "Entry Error");
                divisor.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearResult(object sender, EventArgs e)
        {
            this.txtResult.Text = "";
        }
    }
}
