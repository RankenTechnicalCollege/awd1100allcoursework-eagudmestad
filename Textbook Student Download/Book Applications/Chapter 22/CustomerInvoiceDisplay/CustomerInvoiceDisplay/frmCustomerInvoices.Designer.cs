namespace CustomerInvoiceDisplay
{
    partial class frmCustomerInvoices
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.lblPages = new System.Windows.Forms.Label();
            this.btnGoTo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(22, 25);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 62;
            this.dgvCustomers.Size = new System.Drawing.Size(1002, 454);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.TabStop = false;
            this.dgvCustomers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCustomers_RowHeaderMouseClick);
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Location = new System.Drawing.Point(217, 572);
            this.dgvInvoices.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.RowHeadersWidth = 62;
            this.dgvInvoices.Size = new System.Drawing.Size(807, 285);
            this.dgvInvoices.TabIndex = 1;
            this.dgvInvoices.TabStop = false;
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(22, 490);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(83, 44);
            this.btnFirst.TabIndex = 2;
            this.btnFirst.Text = "<<";
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(113, 490);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(83, 44);
            this.btnPrev.TabIndex = 3;
            this.btnPrev.Text = "<";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(205, 490);
            this.btnNext.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(83, 44);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = ">";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(297, 490);
            this.btnLast.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(83, 44);
            this.btnLast.TabIndex = 5;
            this.btnLast.Text = ">>";
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(740, 490);
            this.txtPage.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(64, 31);
            this.txtPage.TabIndex = 4;
            this.txtPage.Tag = "Page number";
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(810, 500);
            this.lblPages.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(68, 25);
            this.lblPages.TabIndex = 6;
            this.lblPages.Text = "/ XXXX";
            // 
            // btnGoTo
            // 
            this.btnGoTo.Location = new System.Drawing.Point(868, 490);
            this.btnGoTo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnGoTo.Name = "btnGoTo";
            this.btnGoTo.Size = new System.Drawing.Size(125, 44);
            this.btnGoTo.TabIndex = 5;
            this.btnGoTo.Text = "Go To Page";
            this.btnGoTo.Click += new System.EventHandler(this.btnGoTo_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(868, 869);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 44);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCustomerInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1053, 944);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.dgvInvoices);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.txtPage);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.btnGoTo);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmCustomerInvoices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Invoice Display";
            this.Load += new System.EventHandler(this.frmCustomerInvoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Button btnGoTo;
        private System.Windows.Forms.Button btnExit;
    }
}