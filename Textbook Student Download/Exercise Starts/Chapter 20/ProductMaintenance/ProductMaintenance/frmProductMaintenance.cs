using System;
using System.Windows.Forms;

namespace ProductMaintenance
{
    public partial class frmProductMaintenance : Form
    {
        public frmProductMaintenance()
        {
            InitializeComponent();
        }

        // add class variables for the DB context and Products entity classes


        private void btnGetProduct_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                try
                {
                    string productCode = txtProductCode.Text;

                    // get product from database by product code and display; 
                    // notify user and clear controls if no product is returned 

                }
                catch (Exception ex)
                {
                    this.HandleGeneralError(ex);
                } 
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";
            errorMessage = Validator.IsPresent(txtProductCode.Text, txtProductCode.Tag.ToString());
            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
				txtProductCode.Focus();
            }
            return success;
        }

        private void DisplayProduct()
        {
            // display the product information
            

            txtProductCode.Focus();
        }

        private void ClearControls()
        {
            txtProductCode.Text = "";
            txtDescription.Text = "";
            txtUnitPrice.Text = "";
            txtOnHand.Text = "";
            txtProductCode.Focus();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addModifyForm = new frmAddModify
            {
                AddProduct = true
            };
            DialogResult result = addModifyForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    // get new product, add to database, display product

                }
                catch (Exception ex)
                {
                    this.HandleGeneralError(ex);
                }  
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            var addModifyForm = new frmAddModify
            {
                AddProduct = false
                // assign class variable to Product property
            };
            DialogResult result = addModifyForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    // get modified product, update database, display product
					
                }
                catch (Exception ex)
                {
                    this.HandleGeneralError(ex);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var desc = ""; // get description from class variable
            DialogResult result =
                MessageBox.Show($"Delete {desc}?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // delete product from database, clear controls

                }
                catch (Exception ex)
                {
                    this.HandleGeneralError(ex);
                }
            }
        }

        // private methods that handle DbUpdateException and DbUpdateConcurrencyException


        private void HandleGeneralError(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
