using System;
using System.Windows.Forms;

namespace ProductMaintenance
{
    public partial class frmAddModify : Form
    {
        public frmAddModify()
        {
            InitializeComponent();
        }

        // add public property for a Products entity 

        public bool AddProduct { get; set; }

        private void frmAddModify_Load(object sender, EventArgs e)
        {
            if (this.AddProduct)
            {
                this.Text = "Add Product";
                txtProductCode.ReadOnly = false;  // allow entry of new product code
                
            } 
            else
            {
                this.Text = "Modify Product";
                txtProductCode.ReadOnly = true;   // can't change existing product code
                this.DisplayProduct();
            }
        }

        private void DisplayProduct()
        {
            // display the product information
            

            txtDescription.Focus();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (this.IsValidData())
            {
                if (this.AddProduct)
                {
                    // initialize form level Products property with new object

                }
                    
                this.LoadProductData();
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += Validator.IsPresent(txtProductCode.Text, txtProductCode.Tag.ToString());
            errorMessage += Validator.IsPresent(txtDescription.Text, txtDescription.Tag.ToString());
            errorMessage += Validator.IsPresent(txtUnitPrice.Text, txtUnitPrice.Tag.ToString());
            errorMessage += Validator.IsDecimal(txtUnitPrice.Text, txtUnitPrice.Tag.ToString());
            errorMessage += Validator.IsPresent(txtOnHand.Text, txtOnHand.Tag.ToString());
            errorMessage += Validator.IsInt32(txtOnHand.Text, txtOnHand.Tag.ToString());

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        private void LoadProductData()
        {
            // load user entries in Products property 
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
