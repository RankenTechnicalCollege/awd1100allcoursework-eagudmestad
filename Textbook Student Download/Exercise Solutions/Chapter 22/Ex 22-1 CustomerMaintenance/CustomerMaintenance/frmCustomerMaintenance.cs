using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using CustomerMaintenance.Model.DataLayer;

namespace CustomerMaintenance
{
    public partial class frmCustomerMaintenance : Form
    {
        public frmCustomerMaintenance()
        {
            InitializeComponent();
        }

        private MMABooksContext context = new MMABooksContext();
        private Customers selectedCustomer;
		
        // private constants for the index values of the Modify and Delete button columns
        private const int ModifyIndex = 6;
        private const int DeleteIndex = 7;

        private void frmCustomerMaintenance_Load(object sender, EventArgs e)
        {
            DisplayCustomers();
        }

        private void DisplayCustomers()
        {
            // get customers and bind grid
            dgCustomers.Columns.Clear();

            //count how many customers we have in total
            var query = context.Customers
                .OrderBy(c => c.Name)
                .Select(c => new { c.CustomerId, c.Name, c.Address, c.City, c.State, c.ZipCode })
                .ToList();
            
            //bind the results of our LINQ query to the DataGridView
            dgCustomers.DataSource = query;

            // format grid
            //set the visible property so this column isn't displayed
            dgCustomers.Columns[0].Visible = false;
            
            //resize the columns for the data fits nicely in each column 
            dgCustomers.AutoResizeColumns();
            //set the column header style
            dgCustomers.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            //set the background color on alternating rows to beige so it's easier to read
            dgCustomers.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            //add two button columns to the grid
            //add column for modify button
            var modifyColumn = new DataGridViewButtonColumn() { 
                UseColumnTextForButtonValue = true, // make sure the text shows up in the button
                HeaderText = "Modify Customer", 
                Text = "Modify", 
                Name = "colModify"
            };
            dgCustomers.Columns.Insert(ModifyIndex, modifyColumn);

            //add column for delete button
            var deleteColumn = new DataGridViewButtonColumn() { 
                UseColumnTextForButtonValue = true, // make sure the text shows up in the button
                HeaderText = "Delete Customer", 
                Text = "Delete", 
                Name = "colDelete"
            };
            dgCustomers.Columns.Insert(DeleteIndex, deleteColumn);
        }

        private void dgCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
            if (e.RowIndex >= 0) // make sure the header row wasn't clicked
            {
                // figure out which customer was clicked
                int customerId = Convert.ToInt32(dgCustomers.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                selectedCustomer = context.Customers.Find(customerId);

                // modify or delete customer
                if (e.ColumnIndex == ModifyIndex)
                {                  
                    ModifyCustomer();
                }
                if (e.ColumnIndex == DeleteIndex)
                {   
                    DeleteCustomer();
                }
            }
        }

        private void ModifyCustomer()
        {
            var addModifyCustomerForm = new frmAddModifyCustomer() {
                AddCustomer = false, 
                Customer = selectedCustomer, 
                States = context.States.OrderBy(s => s.StateName).ToList()
            };

            DialogResult result = addModifyCustomerForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedCustomer = addModifyCustomerForm.Customer;
                    context.SaveChanges();
                    DisplayCustomers();
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

        private void DeleteCustomer()
        {
            DialogResult result =
                MessageBox.Show($"Delete {selectedCustomer.Name}?",
                "Confirm Delete", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    context.Customers.Remove(selectedCustomer);
                    context.SaveChanges();
                    DisplayCustomers();
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
            var addModifyCustomerForm = new frmAddModifyCustomer()
            {
                AddCustomer = true,
                States = context.States.OrderBy(s => s.StateName).ToList()
            };
            DialogResult result = addModifyCustomerForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedCustomer = addModifyCustomerForm.Customer;
                    context.Customers.Add(selectedCustomer);
                    context.SaveChanges();
                    DisplayCustomers();
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

            var state = context.Entry(selectedCustomer).State;
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
            this.DisplayCustomers();
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
