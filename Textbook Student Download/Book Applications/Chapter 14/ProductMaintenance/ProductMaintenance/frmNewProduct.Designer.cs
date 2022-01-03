namespace ProductMaintenance
{
    partial class frmNewProduct
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
            this.rbSoftware = new System.Windows.Forms.RadioButton();
            this.rbBook = new System.Windows.Forms.RadioButton();
            this.txtAuthorOrVersion = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblAuthorOrVersion = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbSoftware
            // 
            this.rbSoftware.Location = new System.Drawing.Point(180, 14);
            this.rbSoftware.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbSoftware.Name = "rbSoftware";
            this.rbSoftware.Size = new System.Drawing.Size(121, 28);
            this.rbSoftware.TabIndex = 23;
            this.rbSoftware.Text = "Software";
            // 
            // rbBook
            // 
            this.rbBook.Checked = true;
            this.rbBook.Location = new System.Drawing.Point(105, 14);
            this.rbBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbBook.Name = "rbBook";
            this.rbBook.Size = new System.Drawing.Size(75, 28);
            this.rbBook.TabIndex = 22;
            this.rbBook.TabStop = true;
            this.rbBook.Text = "Book";
            this.rbBook.CheckedChanged += new System.EventHandler(this.rbBook_CheckedChanged);
            // 
            // txtAuthorOrVersion
            // 
            this.txtAuthorOrVersion.Location = new System.Drawing.Point(105, 125);
            this.txtAuthorOrVersion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAuthorOrVersion.Name = "txtAuthorOrVersion";
            this.txtAuthorOrVersion.Size = new System.Drawing.Size(223, 23);
            this.txtAuthorOrVersion.TabIndex = 2;
            this.txtAuthorOrVersion.Tag = "Author";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(105, 162);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(65, 23);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.Tag = "Price";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(105, 88);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(223, 23);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.Tag = "Description";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(105, 51);
            this.txtCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCode.MaxLength = 4;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(65, 23);
            this.txtCode.TabIndex = 0;
            this.txtCode.Tag = "Code";
            // 
            // lblAuthorOrVersion
            // 
            this.lblAuthorOrVersion.Location = new System.Drawing.Point(12, 125);
            this.lblAuthorOrVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthorOrVersion.Name = "lblAuthorOrVersion";
            this.lblAuthorOrVersion.Size = new System.Drawing.Size(84, 27);
            this.lblAuthorOrVersion.TabIndex = 21;
            this.lblAuthorOrVersion.Text = "Author:";
            this.lblAuthorOrVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(217, 198);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 27);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(105, 198);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 27);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 27);
            this.label3.TabIndex = 14;
            this.label3.Text = "Price:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 27);
            this.label2.TabIndex = 13;
            this.label2.Text = "Description:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 27);
            this.label1.TabIndex = 12;
            this.label1.Text = "Code:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmNewProduct
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(341, 239);
            this.ControlBox = false;
            this.Controls.Add(this.rbSoftware);
            this.Controls.Add(this.rbBook);
            this.Controls.Add(this.txtAuthorOrVersion);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblAuthorOrVersion);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmNewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSoftware;
        private System.Windows.Forms.RadioButton rbBook;
        private System.Windows.Forms.TextBox txtAuthorOrVersion;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblAuthorOrVersion;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}