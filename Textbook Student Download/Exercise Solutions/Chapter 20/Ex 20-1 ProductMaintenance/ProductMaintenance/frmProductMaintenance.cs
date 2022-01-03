using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProductMaintenance.Models.DataLayer;
using System;
using System.Linq;
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
        MMABooksContext context = new MMABooksContext();
        Products selectedProduct;

        private void btnGetProduct_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                try
                {
                    string productCode = txtProductCode.Text;

                    // get product from database by product code and display; 
                    // notify user and clear controls if no product is returned 
                    selectedProduct = context.Products.Find(productCode);
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
                    selectedProduct = addModifyForm.Product;
                    context.Products.Add(selectedProduct);
                    context.SaveChanges();
                    this.DisplayProduct();
                }
                catch (DbUpdateException ex)
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
            var addModifyForm = new frmAddModify
            {
                AddProduct = false,
                Product = selectedProduct // assign class variable to Product property
            };
            DialogResult result = addModifyForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    // get modified product, update database, display product
                    selectedProduct = addModifyForm.Product;
                    context.SaveChanges();
                    this.DisplayProduct();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    this.HandleConcurrencyError(ex);
                }
                catch (DbUpdateException ex)
                {
                    this.HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    this.HandleGeneralError(ex);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var desc = selectedProduct.Description; // get description from class variable
            DialogResult result =
                MessageBox.Show($"Delete {desc}?", "Confirm Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // delete product from database, clear controls
                    context.Products.Remove(selectedProduct);
                    context.SaveChanges();
                    this.ClearControls();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    this.HandleConcurrencyError(ex);
                }
                catch (DbUpdateException ex)
                {
                    this.HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    this.HandleGeneralError(ex);
                }
            }
        }

        // private methods that handle DbUpdateException and DbUpdateConcurrencyException
        private void HandleConcurrencyError(DbUpdateConcurrencyException ex)
        {
            ex.Entries.Single().Reload();

            var state = context.Entry(selectedProduct).State;
            if (state == EntityState.Detached)
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

        private void HandleDatabaseError(DbUpdateException ex)
        {
            string errorMessage = "";
            var sqlException = (SqlException)ex.InnerException;
            foreach (SqlError error in sqlException.Errors)
            {
                errorMessage += "ERROR CODE:  " + error.Number + " " +
                                error.Message + "\n";
            }
            MessageBox.Show(errorMessage);
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
