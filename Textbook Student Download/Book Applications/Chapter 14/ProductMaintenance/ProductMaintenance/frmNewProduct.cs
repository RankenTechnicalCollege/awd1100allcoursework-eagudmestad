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

		private void rbBook_CheckedChanged(object sender, EventArgs e)
		{
			if (rbBook.Checked)
			{
				lblAuthorOrVersion.Text = "Author: ";
				txtAuthorOrVersion.Tag = "Author";
			}
			else
			{
				lblAuthorOrVersion.Text = "Version: ";
				txtAuthorOrVersion.Tag = "Version";
			}
			txtCode.Focus();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (IsValidData())
			{
				if (rbBook.Checked)
					product = new Book(txtCode.Text, txtDescription.Text,
						txtAuthorOrVersion.Text, Convert.ToDecimal(txtPrice.Text));
				else
					product = new Software(txtCode.Text, txtDescription.Text,
						txtAuthorOrVersion.Text, Convert.ToDecimal(txtPrice.Text));
				this.Close();
			}
		}

		private bool IsValidData()
		{
			bool success = true;
			string errorMessage = "";

			errorMessage += Validator.IsPresent(txtCode.Text, txtCode.Tag.ToString());
			errorMessage += Validator.IsPresent(txtDescription.Text, txtDescription.Tag.ToString());
			errorMessage += Validator.IsPresent(txtAuthorOrVersion.Text, txtAuthorOrVersion.Tag.ToString());
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
