using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class frmHelloWorld : Form
    {
        public frmHelloWorld()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           lblDisplay.Text = String.Format("Hello {0}", txtUsername.Text);
           // lblDisplay.Text = "Hello " + txtUsername.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            






        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
