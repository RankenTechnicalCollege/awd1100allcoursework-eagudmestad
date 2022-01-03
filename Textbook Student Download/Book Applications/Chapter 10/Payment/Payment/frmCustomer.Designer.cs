namespace Payment
{
    partial class frmCustomer
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPayment = new System.Windows.Forms.Label();
            this.btnSelectPayment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboNames = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(252, 177);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(164, 177);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPayment
            // 
            this.lblPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPayment.Location = new System.Drawing.Point(12, 73);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(200, 80);
            this.lblPayment.TabIndex = 3;
            this.lblPayment.TextChanged += new System.EventHandler(this.lblPayment_TextChanged);
            // 
            // btnSelectPayment
            // 
            this.btnSelectPayment.Location = new System.Drawing.Point(228, 73);
            this.btnSelectPayment.Name = "btnSelectPayment";
            this.btnSelectPayment.Size = new System.Drawing.Size(104, 23);
            this.btnSelectPayment.TabIndex = 4;
            this.btnSelectPayment.Text = "Select Payment";
            this.btnSelectPayment.Click += new System.EventHandler(this.btnSelectPayment_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Payment method:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer name:";
            // 
            // cboNames
            // 
            this.cboNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNames.FormattingEnabled = true;
            this.cboNames.Location = new System.Drawing.Point(132, 9);
            this.cboNames.Name = "cboNames";
            this.cboNames.Size = new System.Drawing.Size(200, 21);
            this.cboNames.TabIndex = 1;
            this.cboNames.SelectedIndexChanged += new System.EventHandler(this.cboNames_SelectedIndexChanged);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(350, 213);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.btnSelectPayment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboNames);
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomer_FormClosing);
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Button btnSelectPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNames;
    }
}

