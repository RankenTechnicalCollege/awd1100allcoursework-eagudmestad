using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateDueDays_Click(object sender, System.EventArgs e)
        {
            DateTime currentDate = DateTime.Today;
            DateTime futureDate = DateTime.Parse(txtFutureDate.Text);
            TimeSpan ts = futureDate.Subtract(currentDate);
            int daysUntilDue = ts.Days;
            MessageBox.Show(
                "Current date:\t"
                    + currentDate.ToShortDateString() + "\n\n" +
                "Future date:\t"
                    + futureDate.ToShortDateString() + "\n\n" +
                "Days until due:\t"
                    + daysUntilDue,
                "Due Days Calculation");
        }

        private void btnCalculateAge_Click(object sender, System.EventArgs e)
        {
            DateTime currentDate = DateTime.Today;
            DateTime birthDate = DateTime.Parse(txtBirthDate.Text);
            int age = currentDate.Year - birthDate.Year;
            if (currentDate.DayOfYear < birthDate.DayOfYear)
                age--;
            MessageBox.Show(
                "Current date:\t"
                + currentDate.ToLongDateString() + "\n\n" +
                "Birth date:\t"
                + birthDate.ToLongDateString() + "\n\n" +
                "Age:\t\t"
                + age,
                "Age Calculation");
        }

        private void btnExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

    }
}
