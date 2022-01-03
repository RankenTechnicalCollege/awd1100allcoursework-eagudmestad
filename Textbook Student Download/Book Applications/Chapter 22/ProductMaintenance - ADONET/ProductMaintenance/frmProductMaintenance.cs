using System;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ProductMaintenance.Models;
using ProductMaintenance.Models.DataLayer;

namespace ProductMaintenance
{
    public partial class frmProductMaintenance : Form
    {
        public frmProductMaintenance()
        {
            InitializeComponent();
        }

        private Product selectedProduct;

        private void frmProductMaintenance_Load(object sender, EventArgs e)
        {
            DisplayProducts();
        }

        private void DisplayProducts ()
        {
            dgvProducts.Columns.Clear();
            dgvProducts.DataSource = ProductDB.GetProducts();

            // add column for modify button
            var modifyColumn = new DataGridViewButtonColumn() { 
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Modify"
            };
            dgvProducts.Columns.Add(modifyColumn);

            // add column for delete button
            var deleteColumn = new DataGridViewButtonColumn() {
                UseColumnTextForButtonValue = true, 
                HeaderText = "",
                Text = "Delete"
            };
            dgvProducts.Columns.Add(deleteColumn);

            // format the column header
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.Goldenrod;
            dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // format the odd numbered rows
            dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGoldenrod;

            // format the first column
            dgvProducts.Columns[0].HeaderText = "Product Code";
            dgvProducts.Columns[0].Width = 110;

            // format the second column
            dgvProducts.Columns[1].Width = 310;

            // format the third column
            dgvProducts.Columns[2].HeaderText = "Unit Price";
            dgvProducts.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvProducts.Columns[2].Width = 90;
            dgvProducts.Columns[2].DefaultCellStyle.Format = "c";
            dgvProducts.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // store index values for Modify and Delete button columns
            const int ModifyIndex = 3;
            const int DeleteIndex = 4; 

            if (e.ColumnIndex == ModifyIndex || e.ColumnIndex == DeleteIndex)
            {
                string productCode = dgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                selectedProduct = ProductDB.GetProduct(productCode);
            }

            if (e.ColumnIndex == ModifyIndex)
            {
                ModifyProduct();
            }
            else if (e.ColumnIndex == DeleteIndex)
            {
                DeleteProduct();
            }
        }

        private void ModifyProduct()
        {
            var oldProduct = new Product
            {
                ProductCode = selectedProduct.ProductCode,
                Description = selectedProduct.Description,
                UnitPrice = selectedProduct.UnitPrice
            };
            var addModifyProductForm = new frmAddModifyProduct() { 
                AddProduct = false, 
                Product = selectedProduct
            };
            DialogResult result = addModifyProductForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    //ProductDB.SimulateConcurrentUpdate(selectedProduct.ProductCode);
                    if (ProductDB.UpdateProduct(oldProduct, selectedProduct))
                    {
                        DisplayProducts();
                    }
                    else
                    {
                        HandleConcurrencyConflict();
                    }
                }
                catch (SqlException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        private void DeleteProduct()
        {
            DialogResult result =
                MessageBox.Show($"Delete {selectedProduct.ProductCode.Trim()}?",
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    //ProductDB.SimulateConcurrentUpdate(selectedProduct.ProductCode);
                    if (ProductDB.DeleteProduct(selectedProduct))
                    {
                        DisplayProducts();
                    }
                    else
                    {
                        this.HandleConcurrencyConflict();
                    }
                }
                catch (SqlException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addModifyProductForm = new frmAddModifyProduct() { 
                AddProduct = true 
            };
            DialogResult result = addModifyProductForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedProduct = addModifyProductForm.Product;
                    ProductDB.AddProduct(selectedProduct);
                    DisplayProducts();
                }
                catch (SqlException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        private void HandleConcurrencyConflict()
        {
            selectedProduct = ProductDB.GetProduct(selectedProduct.ProductCode); // reload product
            if (selectedProduct == null)
            {
                MessageBox.Show("Another user has deleted that product.",
                    "Concurrency Error");
            }
            else
            {
                string message = "Another user has updated that product.\n" +
                    "The current database values will be displayed.";
                MessageBox.Show(message, "Concurrency Error");
            }
            DisplayProducts();
        }

        private void HandleDatabaseError(SqlException ex)
        {
            string errorMessage = "";
            foreach (SqlError error in ex.Errors)
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
