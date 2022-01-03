using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                DateTime arrivalDate = DateTime.Parse(txtArrivalDate.Text);
                DateTime departureDate = DateTime.Parse(txtDepartureDate.Text);
                if (departureDate > arrivalDate)
                {
                    TimeSpan reservationDays = departureDate - arrivalDate;
                    int days = reservationDays.Days;

                    DateTime chargeDate = arrivalDate;
                    decimal totalPrice = 0m;
                    while (chargeDate < departureDate)
                    {
                        if (chargeDate.DayOfWeek == DayOfWeek.Friday ||
                            chargeDate.DayOfWeek == DayOfWeek.Saturday)
                        {
                            totalPrice += 150.00m;
                        }
                        else
                        {
                            totalPrice += 120.00m;
                        }
                        chargeDate = chargeDate.AddDays(1);
                    }

                    decimal averagePrice = totalPrice / days;
                    txtNights.Text = days.ToString();
                    txtTotalPrice.Text = totalPrice.ToString("c");
                    txtAvgPrice.Text = averagePrice.ToString("c");
                }
                else
                {
                    MessageBox.Show("Departure date must be after arrival date.", "Entry Error");
                }
                txtArrivalDate.Focus();
            }
        }

        public bool IsValidData()
        {
            DateTime startDate = DateTime.Today;
            DateTime endDate = startDate.AddYears(5);

            return
                // Validate the Arrival Date text box
                IsPresent(txtArrivalDate, "Arrival Date") &&
                IsDateTime(txtArrivalDate, "Arrival Date") &&
                IsWithinRange(txtArrivalDate, "Arrival Date", startDate, endDate) &&

                // Validate the Departure Date text box
                IsPresent(txtDepartureDate, "Departure Date") &&
                IsDateTime(txtDepartureDate, "Departure Date") &&
                IsWithinRange(txtDepartureDate, "Departure Date", startDate, endDate);
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

        public bool IsDateTime(TextBox textBox, string name)
        {
            DateTime dateTime = new DateTime();
            if (DateTime.TryParse(textBox.Text, out dateTime))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a valid date.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsWithinRange(TextBox textBox, string name,
            DateTime min, DateTime max)
        {
            DateTime date = Convert.ToDateTime(textBox.Text);
            if (date < min)
            {
                MessageBox.Show(name + " must be after the current date.", "Entry Error");
                textBox.Focus();
                return false;
            }
            if (date > max)
            {
                MessageBox.Show(name + " must be before " + max.ToShortDateString(), "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime arrivalDate = DateTime.Today;
            DateTime departureDate = arrivalDate.AddDays(3);
            txtArrivalDate.Text = arrivalDate.ToShortDateString();
            txtDepartureDate.Text = departureDate.ToShortDateString();
        }
    }
}
