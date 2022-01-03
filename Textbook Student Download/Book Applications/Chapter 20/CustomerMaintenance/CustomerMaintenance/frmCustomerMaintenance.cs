using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using CustomerMaintenance.Models.DataLayer;

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

        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                int customerID = Convert.ToInt32(txtCustomerID.Text);
                try
                {
                    selectedCustomer = context.Customers.Find(customerID);
                    if (selectedCustomer == null)
                    {
                        MessageBox.Show("No customer found with this ID. " +
                        "Please try again.", "Customer Not Found");
                        this.ClearControls();
                    }
                    else
                    {
                        if (!context.Entry(selectedCustomer)
                        .Reference("StateNavigation").IsLoaded)
                        {
                            context.Entry(selectedCustomer)
                            .Reference("StateNavigation").Load();
                        }
                        this.DisplayCustomer();
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
            errorMessage = Validator.IsInt32(txtCustomerID.Text,
            txtCustomerID.Tag.ToString());
            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
                txtCustomerID.Focus();
            }
            return success;
        }

        private void DisplayCustomer()
        {
            txtCustomerID.Text = selectedCustomer.CustomerId.ToString();
            txtName.Text = selectedCustomer.Name;
            txtAddress.Text = selectedCustomer.Address;
            txtCity.Text = selectedCustomer.City;
            txtState.Text = selectedCustomer.StateNavigation.StateName;
            txtZipCode.Text = selectedCustomer.ZipCode;
            btnModify.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void ClearControls()
        {
            txtCustomerID.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtZipCode.Text = "";
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            txtCustomerID.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addModifyForm = new frmAddModifyCustomer
            {
                AddCustomer = true,
                States = context.States.OrderBy(s => s.StateName).ToList()
            };
            DialogResult result = addModifyForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedCustomer = addModifyForm.Customer;
                try
                {
                    context.Customers.Add(selectedCustomer);
                    context.SaveChanges();
                    this.DisplayCustomer();
                }
                catch (DbUpdateException ex)
                {
                    this.HandleDataError(ex);
                }
                catch (Exception ex)
                {
                    this.HandleGeneralError(ex);
                }
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            var addModifyForm = new frmAddModifyCustomer
            {
                AddCustomer = false,
                Customer = selectedCustomer,
                States = context.States.OrderBy(s => s.StateName).ToList()
            };
            DialogResult result = addModifyForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedCustomer = addModifyForm.Customer;
                try
                {
                    context.SaveChanges();
                    DisplayCustomer();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    this.HandleConcurrencyError(ex);
                }
                catch (DbUpdateException ex)
                {
                    this.HandleDataError(ex);
                }
                catch (Exception ex)
                {
                    this.HandleGeneralError(ex);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                $"Delete {selectedCustomer.Name}?",
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    context.Customers.Remove(selectedCustomer);
                    context.SaveChanges();
                    this.ClearControls();
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    this.HandleConcurrencyError(ex);
                }
                catch (DbUpdateException ex)
                {
                    this.HandleDataError(ex);
                }
                catch (Exception ex)
                {
                    this.HandleGeneralError(ex);
                }
            }
        }

        private void HandleConcurrencyError(DbUpdateConcurrencyException ex)
        {
            ex.Entries.Single().Reload();
            var state = context.Entry(selectedCustomer).State;
            if (state == EntityState.Detached)
            {
                MessageBox.Show("Another user has deleted that customer.",
                "Concurrency Error");
                this.ClearControls();
            }
            else
            {
                string message = "Another user has updated that customer.\n" +
                "The current database values will be displayed.";
                MessageBox.Show(message, "Concurrency Error");
                this.DisplayCustomer();
            }
        }

        private void HandleDataError(DbUpdateException ex)
        {
            string errorMessage = "";
            var sqlException = (SqlException)ex.InnerException;
            foreach (SqlError error in sqlException.Errors)
            {
                errorMessage += "ERROR CODE: " + error.Number + " " +
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