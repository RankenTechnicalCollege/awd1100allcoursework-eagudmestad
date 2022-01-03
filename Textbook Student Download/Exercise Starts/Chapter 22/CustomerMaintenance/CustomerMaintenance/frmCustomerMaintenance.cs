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

        private void frmCustomerMaintenance_Load(object sender, EventArgs e)
        {
            DisplayCustomers();
        }

        private void DisplayCustomers()
        {
            // get customers and bind grid

            // format grid
        }

        private void ModifyCustomer()
        {
            var addModifyCustomerForm = new frmAddModifyCustomer()
            {
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
