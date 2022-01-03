using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CalculateLetterGrade
{
    public partial class frmCalculateGrade : Form
    {
        public frmCalculateGrade()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // get the number grade from the Number grade text box
            decimal numberGrade = Convert.ToDecimal(txtNumberGrade.Text);

            // set the letter grade based on the number grade
            string letterGrade = "";
            if (numberGrade >= 88)
            {
                letterGrade = "A";
            }
            else if (numberGrade >= 80 && numberGrade <= 87)
            {
                letterGrade = "B";
            }
            else if (numberGrade >= 68 && numberGrade <= 79)
            {
                letterGrade = "C";
            }
            else if (numberGrade >= 60 && numberGrade <= 67)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }

            // display the letter grade
            txtLetterGrade.Text = letterGrade;

            // move the focus to the Number grade text box
            txtNumberGrade.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
