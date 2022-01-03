using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using OrderOptionsMaintenance.Models;

namespace OrderOptionsMaintenance
{
    public partial class frmOptionsMaint : Form
    {
        public frmOptionsMaint()
        {
            InitializeComponent();
        }

        MMABooksContext context = new MMABooksContext();
        OrderOption options;

        private void frmOptionsMaint_Load(object sender, EventArgs e)
        {
            options = context.OrderOptions.FirstOrDefault();
            DisplayOptions();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                try
                {
                    LoadOptions();
                    context.SaveChanges();
                    ShowSuccessMessage();
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }                
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtSalesTax) &&
                   Validator.IsDecimal(txtSalesTax) &&
                   Validator.IsPresent(txtShipFirstBook) &&
                   Validator.IsDecimal(txtShipFirstBook) &&
                   Validator.IsPresent(txtShipAddlBook) &&
                   Validator.IsDecimal(txtShipAddlBook);
        }

        private void DisplayOptions()
        {
            txtSalesTax.Text = options.SalesTaxRate.ToString();
            txtShipFirstBook.Text = options.FirstBookShipCharge.ToString("n2");
            txtShipAddlBook.Text = options.AdditionalBookShipCharge.ToString("n2");
        }

        private void LoadOptions()
        {
            options.SalesTaxRate = Convert.ToDecimal(txtSalesTax.Text);
            options.FirstBookShipCharge = Convert.ToDecimal(txtShipFirstBook.Text);
            options.AdditionalBookShipCharge = Convert.ToDecimal(txtShipAddlBook.Text);
        }

        private void ClearControls()
        {
            txtSalesTax.Text = "";
            txtShipFirstBook.Text = "";
            txtShipAddlBook.Text = "";
        }

        private void ShowSuccessMessage()
        {
            MessageBox.Show("Options saved.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void HandleDatabaseError (DbUpdateException ex)
        {
            string errorMessage = "";
            var sqlException = (SqlException)ex.InnerException;
            foreach (SqlError error in sqlException.Errors)
            {
                errorMessage += "ERROR CODE: " + error.Number + " " +
                error.Message + "\n";
            }
            MessageBox.Show(errorMessage, ex.GetType().ToString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
