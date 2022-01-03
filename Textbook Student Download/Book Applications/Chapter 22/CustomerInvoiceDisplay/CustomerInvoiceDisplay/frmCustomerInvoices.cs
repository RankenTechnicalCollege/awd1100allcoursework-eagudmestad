using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CustomerInvoiceDisplay.Model.DataLayer;

namespace CustomerInvoiceDisplay
{
    public partial class frmCustomerInvoices : Form
    {
        public frmCustomerInvoices()
        {
            InitializeComponent();
        }
        private MMABooksContext context = new MMABooksContext();
        private const int MaxRows = 10;
        private int totalRows = 0;
        private int pages = 0;

        private void frmCustomerInvoices_Load(object sender, EventArgs e)
        {
            totalRows = context.Customers.Count();
            pages = totalRows / MaxRows;
            if (totalRows % MaxRows != 0)
            {
                pages += 1;
            }
            lblPages.Text = "/ " + pages;

            DisplayCustomers(1);
        }

        private void DisplayCustomers(int pageNumber)
        {
            txtPage.Text = pageNumber.ToString();

            int skip = MaxRows * (pageNumber - 1);

            int take = MaxRows;
            if (pageNumber == pages)
            {
                take = totalRows - skip;
            }
            if (totalRows <= MaxRows)
            {
                take = totalRows;
            }

            var customers = context.Customers
                .OrderBy(c => c.Name)
                .Select(c => new { c.CustomerId, c.Name, c.Address, c.City, c.State, c.ZipCode })
                .Skip(skip)
                .Take(take)
                .ToList();
            dgvCustomers.DataSource = customers;

            DisplayInvoices(0);
            dgvCustomers.Rows[0].Selected = true;

            // format the column headers
            dgvCustomers.EnableHeadersVisualStyles = false;
            dgvCustomers.ColumnHeadersDefaultCellStyle.Font =
                new Font("Arial", 9, FontStyle.Bold);
            dgvCustomers.ColumnHeadersDefaultCellStyle.BackColor = Color.Goldenrod;
            dgvCustomers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // format the odd numbered rows
            dgvCustomers.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            // format the columns
            dgvCustomers.Columns[0].Visible = false;  // hide id column
            dgvCustomers.Columns[1].Width = 160;
            dgvCustomers.Columns[2].Width = 215;
            dgvCustomers.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvCustomers.Columns[4].Width = 55;
            dgvCustomers.Columns[3].Width = 125;
            dgvCustomers.Columns[5].HeaderText = "Zip Code";
            dgvCustomers.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvCustomers.Columns[5].Width = 82;

            EnableDisableButtons(pageNumber);
        }

        private void EnableDisableButtons(int pageNumber)
        {
            if (pageNumber == 1)
            {
                btnFirst.Enabled = false;
                btnPrev.Enabled = false;
            }
            else
            {
                btnFirst.Enabled = true;
                btnPrev.Enabled = true;
            }

            if (pageNumber == pages)
            {
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
                btnLast.Enabled = true;
            }

            // if there's only one page, disable the Go To button            
            if (totalRows <= MaxRows)
            {
                btnGoTo.Enabled = false;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            DisplayCustomers(1);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            int pageNumber = Convert.ToInt32(txtPage.Text);
            pageNumber -= 1;
            DisplayCustomers(pageNumber);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int pageNumber = Convert.ToInt32(txtPage.Text);
            pageNumber += 1;
            DisplayCustomers(pageNumber);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            DisplayCustomers(pages);
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                int pageNumber = Convert.ToInt32(txtPage.Text);
                DisplayCustomers(pageNumber);
            }
        }

        private bool IsValidData()
        {
            bool success = true;
            string errorMessage = "";
            errorMessage += Validator.IsPresent(txtPage.Text, txtPage.Tag.ToString());
            errorMessage += Validator.IsInt32(txtPage.Text, txtPage.Tag.ToString());
            errorMessage += Validator.IsWithinRange(txtPage.Text, txtPage.Tag.ToString(), 1, pages);
            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
                txtPage.Focus();
            }
            return success;
        }

        private void dgvCustomers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DisplayInvoices(e.RowIndex);
        }

        private void DisplayInvoices(int rowIndex)
        {
            DataGridViewRow row = dgvCustomers.Rows[rowIndex];
            int customerID = Convert.ToInt32(row.Cells[0].Value);

            var invoices = context.Invoices
                .Where(i => i.CustomerId == customerID)
                .OrderBy(i => i.InvoiceId)
                .Select(i => new { i.InvoiceId, i.InvoiceDate, i.ProductTotal, i.SalesTax, i.Shipping, i.InvoiceTotal })
                .ToList();

            dgvInvoices.DataSource = invoices;

            // format the column headers
            dgvInvoices.EnableHeadersVisualStyles = false;
            dgvInvoices.ColumnHeadersDefaultCellStyle.Font =
                new Font("Arial", 9, FontStyle.Bold);
            dgvInvoices.ColumnHeadersDefaultCellStyle.BackColor = Color.Goldenrod;
            dgvInvoices.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // format the odd numbered rows
            dgvInvoices.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            // format the columns
            dgvInvoices.Columns[0].HeaderText = "Invoice ID";
            dgvInvoices.Columns[0].Width = 75;
            dgvInvoices.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgvInvoices.Columns[1].HeaderText = "Invoice Date";
            dgvInvoices.Columns[1].Width = 90;
            dgvInvoices.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgvInvoices.Columns[2].HeaderText = "Product Total";
            dgvInvoices.Columns[2].Width = 95;
            dgvInvoices.Columns[2].DefaultCellStyle.Format = "c";
            dgvInvoices.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvInvoices.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvInvoices.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvInvoices.Columns[3].HeaderText = "Sales Tax";
            dgvInvoices.Columns[3].Width = 75;
            dgvInvoices.Columns[3].DefaultCellStyle.Format = "c";
            dgvInvoices.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvInvoices.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvInvoices.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvInvoices.Columns[4].HeaderText = "Shipping";
            dgvInvoices.Columns[4].Width = 75;
            dgvInvoices.Columns[4].DefaultCellStyle.Format = "c";
            dgvInvoices.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvInvoices.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvInvoices.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvInvoices.Columns[5].HeaderText = "Invoice Total";
            dgvInvoices.Columns[5].Width = 90;
            dgvInvoices.Columns[5].DefaultCellStyle.Format = "c";
            dgvInvoices.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvInvoices.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvInvoices.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
