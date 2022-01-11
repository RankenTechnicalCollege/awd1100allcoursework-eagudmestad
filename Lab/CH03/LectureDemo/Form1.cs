using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LectureDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            //Comments are commonly used for documentation
            //and troubleshooting!

            
          
            double numberOne = Convert.ToDouble(txtNumberOne.Text);
            double numberTwo = Convert.ToDouble(txtNumberTwo.Text);

            double multiplied = numberOne * numberTwo;

            lblResult.Text = String.Format("{0} * {1} = {2}", numberOne, numberTwo, multiplied);
           
            

    }



        //Block of executable Code is a method
        //Methods have ()'s
        //Methods that respond to events are called
        //Event Handlers
        //The code the links events to their handlers
        //is called "Event wiring"

    }
}
