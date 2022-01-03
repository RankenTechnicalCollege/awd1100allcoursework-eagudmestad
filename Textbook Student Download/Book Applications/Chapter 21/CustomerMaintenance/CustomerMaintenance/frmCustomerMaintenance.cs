using System;
using System.Windows.Forms;
using CustomerMaintenance.Models.DataLayer;
using Microsoft.Data.SqlClient;

namespace CustomerMaintenance
{
    public partial class frmCustomerMaintenance : Form
    {
        public frmCustomerMaintenance()
        {
            InitializeComponent();
        }

        private Customer customer;

        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                int customerID = Convert.ToInt32(txtCustomerID.Text);
                try
                {
                    this.GetCustomer(customerID);
                    if (customer == null)
                    {
                        MessageBox.Show("No customer found with this ID. " +
                            "Please try again.", "Customer Not Found");
                        this.ClearControls();
                    }
                    else
                    {
                        this.DisplayCustomer();
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
            errorMessage = Validator.IsInt32(txtCustomerID.Text, txtCustomerID.Tag.ToString());
            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
                txtCustomerID.Focus();
            }
            return success;
        }

        private void GetCustomer(int customerId)
        {
            customer = CustomerDB.GetCustomer(customerId);
            this.GetState();
        }
        private void GetState()
        {
            if (customer != null)
            {
                customer.State = StateDB.GetState(customer.StateCode);
            }
        }

        private void DisplayCustomer()
        {
            txtCustomerID.Text = customer.CustomerId.ToString();
            txtName.Text = customer.Name;
            txtAddress.Text = customer.Address;
            txtCity.Text = customer.City;
            txtState.Text = customer.State.StateName;
            txtZipCode.Text = customer.ZipCode;
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
            frmAddModifyCustomer addModifyForm = new frmAddModifyCustomer
            {
                AddCustomer = true,
                States = StateDB.GetStates()
            };
            DialogResult result = addModifyForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                customer = addModifyForm.Customer;
                try
                {
                    CustomerDB.AddCustomer(customer);
                    this.GetState();
                    this.DisplayCustomer();
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
            Customer oldCustomer = this.CloneCustomer();  // save old values
            var addModifyForm = new frmAddModifyCustomer
            {
                AddCustomer = false,
                Customer = customer,
                States = StateDB.GetStates()
            };
            DialogResult result = addModifyForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                customer = addModifyForm.Customer; // get new values
                try
                {
                    //CustomerDB.SimulateConcurrentDelete(customer.CustomerId);
                    if (CustomerDB.UpdateCustomer(oldCustomer, customer))
                    {
                        this.GetState();
                        this.DisplayCustomer();
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

        private Customer CloneCustomer()
        {
            return new Customer()
            {
                CustomerId = customer.CustomerId,
                Name = customer.Name,
                Address = customer.Address,
                City = customer.City,
                StateCode = customer.StateCode,
                ZipCode = customer.ZipCode,
                State = customer.State
            };
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show($"Delete {customer.Name}?",
                "Confirm Delete", 
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    //CustomerDB.SimulateConcurrentUpdate(customer.CustomerId);
                    if (CustomerDB.DeleteCustomer(customer))
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
            this.GetCustomer(customer.CustomerId); // reload customer
            if (customer == null)
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

        private void HandleDatabaseError(SqlException ex)
        {
            // in real life, would do something with error like log it
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