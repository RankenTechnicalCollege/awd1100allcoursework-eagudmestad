using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProductMaintenance.Model;

namespace ProductMaintenance
{
    public partial class frmProductMaintenance : Form
    {
        public frmProductMaintenance()
        {
            InitializeComponent();
        }

        private MMABooksContext context = new MMABooksContext();
        private Products selectedProduct;

        private void frmProductMaintenance_Load(object sender, EventArgs e)
        {
            DisplayProducts();
        }

        private void DisplayProducts ()
        {
            dgvProducts.Columns.Clear();
            var products = context.Products
                .OrderBy(p => p.Description)
                .Select(p => new { p.ProductCode, p.Description, p.UnitPrice })
                .ToList();

            dgvProducts.DataSource = products;

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
                selectedProduct = context.Products.Find(productCode);
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
            var addModifyProductForm = new frmAddModifyProduct() { 
                AddProduct = false, 
                Product = selectedProduct
            };
            DialogResult result = addModifyProductForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedProduct = addModifyProductForm.Product;
                    context.SaveChanges();
                    DisplayProducts();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    HandleConcurrencyError(ex);
                }
                catch (DbUpdateException ex)
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
                    context.Products.Remove(selectedProduct);
                    context.SaveChanges(true);
                    DisplayProducts();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    HandleConcurrencyError(ex);
                }
                catch (DbUpdateException ex)
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
                    context.Products.Add(selectedProduct);
                    context.SaveChanges();
                    DisplayProducts();
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        private void HandleConcurrencyError(DbUpdateConcurrencyException ex)
        {
            ex.Entries.Single().Reload();

            var state = context.Entry(selectedProduct).State;
            if (state == EntityState.Detached)
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
            this.DisplayProducts();
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
