namespace StringHandling
{
    partial class Form1
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
            this.btnEditPhoneNumber = new System.Windows.Forms.Button();
            this.btnParseName = new System.Windows.Forms.Button();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(292, 78);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(63, 20);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEditPhoneNumber
            // 
            this.btnEditPhoneNumber.Location = new System.Drawing.Point(292, 44);
            this.btnEditPhoneNumber.Name = "btnEditPhoneNumber";
            this.btnEditPhoneNumber.Size = new System.Drawing.Size(154, 19);
            this.btnEditPhoneNumber.TabIndex = 10;
            this.btnEditPhoneNumber.Text = "Edit Phone Number";
            this.btnEditPhoneNumber.Click += new System.EventHandler(this.btnEditPhoneNumber_Click);
            // 
            // btnParseName
            // 
            this.btnParseName.Location = new System.Drawing.Point(292, 9);
            this.btnParseName.Name = "btnParseName";
            this.btnParseName.Size = new System.Drawing.Size(154, 20);
            this.btnParseName.TabIndex = 8;
            this.btnParseName.Text = "Parse Name";
            this.btnParseName.Click += new System.EventHandler(this.btnParseName_Click);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(132, 44);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(87, 20);
            this.txtPhoneNumber.TabIndex = 9;
            this.txtPhoneNumber.Text = "(559) 440-9071";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(132, 9);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(147, 20);
            this.txtFullName.TabIndex = 5;
            this.txtFullName.Text = "joel ray murach";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter phone number:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter full name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(468, 108);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEditPhoneNumber);
            this.Controls.Add(this.btnParseName);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "String Handling";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEditPhoneNumber;
        private System.Windows.Forms.Button btnParseName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

