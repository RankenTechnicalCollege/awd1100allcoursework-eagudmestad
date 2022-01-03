using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LengthConversions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[,] conversionTable = {
            {"Miles to kilometers", "Miles:", "Kilometers:", "1.6093"},
            {"Kilometers to miles", "Kilometers:", "Miles:", "0.6214"},
            {"Feet to meters", "Feet:", "Meters:", "0.3048"},
            {"Meters to feet", "Meters:", "Feet:", "3.2808"},
            {"Inches to centimeters", "Inches:", "Centimeters:", "2.54"},
            {"Centimeters to inches", "Centimeters:", "Inches:", "0.3937"}
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < conversionTable.GetLength(0); i++)
                cboConversions.Items.Add(conversionTable[i, 0]);
            cboConversions.SelectedIndex = 0;
        }

        private void cboConversions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cboConversions.SelectedIndex;
            lblFromLength.Text = conversionTable[selectedIndex, 1];
            lblToLength.Text = conversionTable[selectedIndex, 2];

            txtCalculatedLength.Text = "";
            txtLength.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                decimal length = Convert.ToDecimal(txtLength.Text);

                int selectedIndex = cboConversions.SelectedIndex;
                decimal multiplier = Convert.ToDecimal(conversionTable[selectedIndex, 3]);
                decimal calculatedLength = length * multiplier;
                txtCalculatedLength.Text = calculatedLength.ToString("n");
            }
        }

        public bool IsValidData()
        {
            return
                // Validate the Length text box
                IsPresent(this.txtLength, lblFromLength.Text) &&
                IsDecimal(this.txtLength, lblFromLength.Text);
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
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(name + " must be a decimal number.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
