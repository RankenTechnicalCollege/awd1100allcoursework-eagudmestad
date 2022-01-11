using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FahrenheitToCelcius
{
    public partial class frmTempConverter : Form
    {
        public frmTempConverter()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //Read the input from the textbox
            double fahrenheit = Convert.ToDouble(txtFahrenheit.Text);


            //Calc the celcius
            double celcius = (fahrenheit - 32) * 5 / 9;



            //Output the Celcius
            lblCelcius.Text = String.Format("{0} degrees fahrenheit is {1:N4} celcius", fahrenheit, celcius);
        }
    }
}
