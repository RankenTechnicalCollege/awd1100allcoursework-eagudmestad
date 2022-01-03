using ProductMaintenance.Models.DataLayer;
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

        // add a public Product property of type Products
        public Product Product { get; set; }
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
            txtProductCode.Text = this.Product.ProductCode;
            txtDescription.Text = this.Product.Description;
            txtUnitPrice.Text = this.Product.UnitPrice.ToString();
            txtOnHand.Text = this.Product.OnHandQuantity.ToString();

            txtDescription.Focus();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (this.IsValidData())
            {
                if (this.AddProduct)
                {
                    // initialize the Product property with new Products object
                    this.Product = new Product();
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
            // load user entries in the Products property 
            this.Product.ProductCode = txtProductCode.Text;
            this.Product.Description = txtDescription.Text;
            this.Product.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
            this.Product.OnHandQuantity = Convert.ToInt32(txtOnHand.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
