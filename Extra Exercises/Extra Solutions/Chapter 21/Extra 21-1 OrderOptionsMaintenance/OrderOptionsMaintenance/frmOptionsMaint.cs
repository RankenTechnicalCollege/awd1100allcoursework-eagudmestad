using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;
using OrderOptionsMaintenance.Models;

namespace OrderOptionsMaintenance
{
    public partial class frmOptionsMaint : Form
    {
        public frmOptionsMaint()
        {
            InitializeComponent();
        }

        OrderOption options;

        private void frmOptionsMaint_Load(object sender, EventArgs e)
        {
            options = OrderOptionDB.GetOrderOptions();
            DisplayOptions();
        }

        private void DisplayOptions()
        {
            txtSalesTax.Text = options.SalesTaxRate.ToString();
            txtShipFirstBook.Text = options.FirstBookShipCharge.ToString("n2");
            txtShipAddlBook.Text = options.AdditionalBookShipCharge.ToString("n2");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                try
                {
                    OrderOption oldOptions = CloneOptions();
                    LoadOptions();
                    if (OrderOptionDB.UpdateOrderOption(oldOptions, options))
                    {
                        DisplayOptions();
                        ShowSuccessMessage();
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
            }
        }

        private void ClearControls()
        {
            txtSalesTax.Text = "";
            txtShipFirstBook.Text = "";
            txtShipAddlBook.Text = "";
        }

        private OrderOption CloneOptions()
        {
            return new OrderOption
            {
                OptionId = options.OptionId,
                SalesTaxRate = options.SalesTaxRate,
                FirstBookShipCharge = options.FirstBookShipCharge,
                AdditionalBookShipCharge = options.AdditionalBookShipCharge
            };
        }

        private void LoadOptions()
        {
            options.SalesTaxRate = Convert.ToDecimal(txtSalesTax.Text);
            options.FirstBookShipCharge = Convert.ToDecimal(txtShipFirstBook.Text);
            options.AdditionalBookShipCharge = Convert.ToDecimal(txtShipAddlBook.Text);
        }

        private void ShowSuccessMessage()
        {
            MessageBox.Show("Options saved.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void HandleConcurrencyConflict()
        {
            options = OrderOptionDB.GetOrderOptions(); // reload
            if (options == null)
            {
                MessageBox.Show("Another user has deleted that product.",
                    "Concurrency Error");
                ClearControls();
            }
            else
            {
                string message = "Another user has updated that product.\n" +
                    "The current database values will be displayed.";
                MessageBox.Show(message, "Concurrency Error");
                DisplayOptions();
            }
        }

        private void HandleDatabaseError(SqlException ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
