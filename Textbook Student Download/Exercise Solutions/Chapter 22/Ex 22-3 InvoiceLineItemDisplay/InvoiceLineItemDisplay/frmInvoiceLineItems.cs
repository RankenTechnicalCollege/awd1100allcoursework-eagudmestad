using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using InvoiceLineItemDisplay.Model.DataLayer;

namespace InvoiceLineItemDisplay
{
    public partial class frmInvoiceLineItems : Form
    {
        public frmInvoiceLineItems()
        {
            InitializeComponent();
        }

        private MMABooksContext context = new MMABooksContext();

        private void frmInvoiceLineItems_Load(object sender, EventArgs e)
        {
            DisplayInvoices();
            DisplayLineItems(0);
            dgvInvoices.Rows[0].Selected = true;
        }

        private void DisplayInvoices()
        {
            var invoices = context.Invoices
                .OrderBy(i => i.InvoiceDate)
                .Select(i => new { i.InvoiceId, i.InvoiceDate, i.ProductTotal, 
                                   i.SalesTax, i.Shipping, i.InvoiceTotal })
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
            dgvInvoices.Columns[0].Visible = false;

            dgvInvoices.Columns[1].HeaderText = "Invoice Date";
            dgvInvoices.Columns[1].Width = 90;
            dgvInvoices.Columns[1].DefaultCellStyle.Format = "d";
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

        private void dgvInvoices_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DisplayLineItems(e.RowIndex);
        }

        private void DisplayLineItems(int rowIndex)
        {
            DataGridViewRow row = dgvInvoices.Rows[rowIndex];
            int invoiceID = Convert.ToInt32(row.Cells[0].Value);
			
            var invoiceLineItems = context.InvoiceLineItems
                .Where(l => l.InvoiceId == invoiceID)
                .OrderBy(l => l.ProductCode)
                .Select(l => new { l.ProductCode, l.Quantity, l.UnitPrice, l.ItemTotal })
                .ToList();

            dgvLineItems.DataSource = invoiceLineItems;

            // format the column headers
            dgvLineItems.EnableHeadersVisualStyles = false;
            dgvLineItems.ColumnHeadersDefaultCellStyle.Font =
                new Font("Arial", 9, FontStyle.Bold);
            dgvLineItems.ColumnHeadersDefaultCellStyle.BackColor = Color.Goldenrod;
            dgvLineItems.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // format the odd numbered rows
            dgvLineItems.AlternatingRowsDefaultCellStyle.BackColor = Color.Beige;

            // format the columns
            dgvLineItems.Columns[0].HeaderText = "Product Code";
            dgvLineItems.Columns[0].Width = 95;
            dgvLineItems.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            dgvLineItems.Columns[1].Width = 70;
            dgvLineItems.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvLineItems.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvLineItems.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvLineItems.Columns[2].HeaderText = "Unit Price";
            dgvLineItems.Columns[2].Width = 78;
            dgvLineItems.Columns[2].DefaultCellStyle.Format = "c";
            dgvLineItems.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvLineItems.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvLineItems.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgvLineItems.Columns[3].HeaderText = "Item Total";
            dgvLineItems.Columns[3].Width = 78;
            dgvLineItems.Columns[3].DefaultCellStyle.Format = "c";
            dgvLineItems.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvLineItems.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgvLineItems.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
