namespace Payment
{
    partial class frmPayment
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
            this.lstCreditCardType = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.chkDefault = new System.Windows.Forms.CheckBox();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.cboExpirationYear = new System.Windows.Forms.ComboBox();
            this.cboExpirationMonth = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoBillCustomer = new System.Windows.Forms.RadioButton();
            this.rdoCreditCard = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCreditCardType
            // 
            this.lstCreditCardType.FormattingEnabled = true;
            this.lstCreditCardType.ItemHeight = 15;
            this.lstCreditCardType.Location = new System.Drawing.Point(135, 97);
            this.lstCreditCardType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstCreditCardType.Name = "lstCreditCardType";
            this.lstCreditCardType.Size = new System.Drawing.Size(251, 79);
            this.lstCreditCardType.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(300, 318);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 27);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(195, 317);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(88, 27);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "&OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chkDefault
            // 
            this.chkDefault.Checked = true;
            this.chkDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDefault.Location = new System.Drawing.Point(14, 272);
            this.chkDefault.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkDefault.Name = "chkDefault";
            this.chkDefault.Size = new System.Drawing.Size(215, 28);
            this.chkDefault.TabIndex = 4;
            this.chkDefault.Text = "Set as default billing method";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(135, 189);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(251, 23);
            this.txtCardNumber.TabIndex = 1;
            this.txtCardNumber.Text = "1111390008727492";
            // 
            // cboExpirationYear
            // 
            this.cboExpirationYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExpirationYear.FormattingEnabled = true;
            this.cboExpirationYear.Location = new System.Drawing.Point(274, 226);
            this.cboExpirationYear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboExpirationYear.Name = "cboExpirationYear";
            this.cboExpirationYear.Size = new System.Drawing.Size(112, 23);
            this.cboExpirationYear.TabIndex = 3;
            // 
            // cboExpirationMonth
            // 
            this.cboExpirationMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExpirationMonth.FormattingEnabled = true;
            this.cboExpirationMonth.Location = new System.Drawing.Point(135, 226);
            this.cboExpirationMonth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboExpirationMonth.Name = "cboExpirationMonth";
            this.cboExpirationMonth.Size = new System.Drawing.Size(121, 23);
            this.cboExpirationMonth.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "Expiration date:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Card number:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "Credit card type:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoBillCustomer);
            this.groupBox1.Controls.Add(this.rdoCreditCard);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(373, 65);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Billing";
            // 
            // rdoBillCustomer
            // 
            this.rdoBillCustomer.Location = new System.Drawing.Point(209, 28);
            this.rdoBillCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoBillCustomer.Name = "rdoBillCustomer";
            this.rdoBillCustomer.Size = new System.Drawing.Size(112, 28);
            this.rdoBillCustomer.TabIndex = 1;
            this.rdoBillCustomer.Text = "Bill customer";
            // 
            // rdoCreditCard
            // 
            this.rdoCreditCard.Checked = true;
            this.rdoCreditCard.Location = new System.Drawing.Point(19, 28);
            this.rdoCreditCard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdoCreditCard.Name = "rdoCreditCard";
            this.rdoCreditCard.Size = new System.Drawing.Size(93, 28);
            this.rdoCreditCard.TabIndex = 0;
            this.rdoCreditCard.TabStop = true;
            this.rdoCreditCard.Text = "Credit card";
            this.rdoCreditCard.CheckedChanged += new System.EventHandler(this.rdoCreditCard_CheckedChanged);
            // 
            // frmPayment
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(410, 358);
            this.ControlBox = false;
            this.Controls.Add(this.lstCreditCardType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkDefault);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.cboExpirationYear);
            this.Controls.Add(this.cboExpirationMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCreditCardType;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox chkDefault;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.ComboBox cboExpirationYear;
        private System.Windows.Forms.ComboBox cboExpirationMonth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoBillCustomer;
        private System.Windows.Forms.RadioButton rdoCreditCard;
    }
}