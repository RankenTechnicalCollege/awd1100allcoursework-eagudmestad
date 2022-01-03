using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using ProductMaintenance.Models.DataLayer;

namespace ProductMaintenance
{
    public partial class frmProductMaintenance : Form
    {
        public frmProductMaintenance()
        {
            InitializeComponent();
        }

        Product selectedProduct;

        private void btnGetProduct_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                try
                {
                    string productCode = txtProductCode.Text;
                    selectedProduct = ProductDB.GetProduct(productCode);
                    if (selectedProduct == null)
                    {
                        MessageBox.Show("No product found with this code. " +
                            "Please try again.", "Product Not Found");
                        this.ClearControls();
                    }
                    else
                    {
                        this.DisplayProduct();
                    }
                }
                catch (SqlException ex)
                {
                    this.HandleDatabaseError(ex);
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
            txtProductCode.Text = selectedProduct.ProductCode;
            txtDescription.Text = selectedProduct.Description;
            txtUnitPrice.Text = selectedProduct.UnitPrice.ToString("c");
            txtOnHand.Text = selectedProduct.OnHandQuantity.ToString();

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
            frmAddModify addModifyForm = new frmAddModify
            {
                AddProduct = true
            };
            DialogResult result = addModifyForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    selectedProduct = addModifyForm.Product;
                    ProductDB.AddProduct(selectedProduct);
                    this.DisplayProduct();
                }
                catch (SqlException ex)
                {
                    this.HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    this.HandleGeneralError(ex);
                }  
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            Product oldProduct = this.CloneProduct();
            frmAddModify addModifyForm = new frmAddModify
            {
                AddProduct = false,
                Product = selectedProduct 
            };
            DialogResult result = addModifyForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    selectedProduct = addModifyForm.Product;
                    if(ProductDB.UpdateProduct(oldProduct, selectedProduct))
                    {
                        this.DisplayProduct();
                    }
                    else
                    {
                        this.HandleConcurrencyConflict();
                    }
                }
                catch (SqlException ex)
                {
                    this.HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    this.HandleGeneralError(ex);
                }
            }
        }

        private Product CloneProduct()
        {
            return new Product() { 
                ProductCode = selectedProduct.ProductCode,
                Description = selectedProduct.Description,
                UnitPrice = selectedProduct.UnitPrice,
                OnHandQuantity = selectedProduct.OnHandQuantity
            };
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var desc = selectedProduct.Description; 
            DialogResult result =
                MessageBox.Show($"Delete {desc}?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (ProductDB.DeleteProduct(selectedProduct))
                    {
                        this.ClearControls();
                    }
                    else
                    {
                        this.HandleConcurrencyConflict();
                    }
                }
                catch (SqlException ex)
                {
                    this.HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    this.HandleGeneralError(ex);
                }
            }
        }

        private void HandleConcurrencyConflict()
        {
            selectedProduct = ProductDB.GetProduct(selectedProduct.ProductCode); // reload
            if (selectedProduct == null)
            {
                MessageBox.Show("Another user has deleted that product.",
                    "Concurrency Error");
                this.ClearControls();
            }
            else
            {
                string message = "Another user has updated that product.\n" +
                    "The current database values will be displayed.";
                MessageBox.Show(message, "Concurrency Error");
                this.DisplayProduct();
            }
        }


        private void HandleDatabaseError(SqlException ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString());
        }

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
