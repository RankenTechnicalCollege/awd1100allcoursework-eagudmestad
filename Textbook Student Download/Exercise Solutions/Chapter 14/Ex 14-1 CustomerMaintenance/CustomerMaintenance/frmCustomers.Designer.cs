namespace CustomerMaintenance
{
    partial class frmCustomers
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddRetail = new System.Windows.Forms.Button();
            this.btnAddWholesale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(298, 90);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstCustomers
            // 
            this.lstCustomers.Location = new System.Drawing.Point(12, 30);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(280, 147);
            this.lstCustomers.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(298, 119);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "&Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customers:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnAddRetail
            // 
            this.btnAddRetail.Location = new System.Drawing.Point(298, 60);
            this.btnAddRetail.Name = "btnAddRetail";
            this.btnAddRetail.Size = new System.Drawing.Size(96, 24);
            this.btnAddRetail.TabIndex = 11;
            this.btnAddRetail.Text = "Add &Retail";
            this.btnAddRetail.Click += new System.EventHandler(this.btnAddRetail_Click);
            // 
            // btnAddWholesale
            // 
            this.btnAddWholesale.Location = new System.Drawing.Point(298, 30);
            this.btnAddWholesale.Name = "btnAddWholesale";
            this.btnAddWholesale.Size = new System.Drawing.Size(96, 24);
            this.btnAddWholesale.TabIndex = 10;
            this.btnAddWholesale.Text = "Add &Wholesale";
            this.btnAddWholesale.Click += new System.EventHandler(this.btnAddWholesale_Click);
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(410, 191);
            this.Controls.Add(this.btnAddRetail);
            this.Controls.Add(this.btnAddWholesale);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Name = "frmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Maintenance";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddRetail;
        private System.Windows.Forms.Button btnAddWholesale;
    }
}

