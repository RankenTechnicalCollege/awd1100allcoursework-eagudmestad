namespace InvoiceLineItemDisplay
{
    partial class frmInvoiceLineItems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.dgvLineItems = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Location = new System.Drawing.Point(22, 25);
            this.dgvInvoices.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.RowHeadersWidth = 62;
            this.dgvInvoices.Size = new System.Drawing.Size(724, 330);
            this.dgvInvoices.TabIndex = 0;
            this.dgvInvoices.TabStop = false;
            this.dgvInvoices.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvInvoices_RowHeaderMouseClick);
            // 
            // dgvLineItems
            // 
            this.dgvLineItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLineItems.Location = new System.Drawing.Point(196, 386);
            this.dgvLineItems.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvLineItems.Name = "dgvLineItems";
            this.dgvLineItems.RowHeadersWidth = 62;
            this.dgvLineItems.Size = new System.Drawing.Size(550, 200);
            this.dgvLineItems.TabIndex = 1;
            this.dgvLineItems.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(621, 612);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 44);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmInvoiceLineItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(772, 684);
            this.Controls.Add(this.dgvInvoices);
            this.Controls.Add(this.dgvLineItems);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmInvoiceLineItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Line Item Display";
            this.Load += new System.EventHandler(this.frmInvoiceLineItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLineItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.DataGridView dgvLineItems;
        private System.Windows.Forms.Button btnExit;
    }
}

