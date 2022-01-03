using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProductMaintenance
{
    public partial class frmNewProduct : Form
    {
        public frmNewProduct()
        {
            InitializeComponent();
        }

		private Product product = null;

		public Product GetNewProduct()
		{
			this.ShowDialog();
			return product;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (IsValidData())
			{
				product = new Product(txtCode.Text,
					txtDescription.Text, Convert.ToDecimal(txtPrice.Text));
				this.Close();
			}
		}

		private bool IsValidData()
		{
			bool success = true;
			string errorMessage = "";

			errorMessage += Validator.IsPresent(txtCode.Text, txtCode.Tag.ToString());
			errorMessage += Validator.IsPresent(txtDescription.Text, txtDescription.Tag.ToString());
			errorMessage += Validator.IsDecimal(txtPrice.Text, txtPrice.Tag.ToString());

			if (errorMessage != "")
			{
				success = false;
				MessageBox.Show(errorMessage, "Entry Error");
			}
			return success;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
