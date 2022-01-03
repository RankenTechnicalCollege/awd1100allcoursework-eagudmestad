namespace CloneCustomer
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
            this.lblCustomer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.btnClone = new System.Windows.Forms.Button();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(292, 201);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomer.Location = new System.Drawing.Point(12, 9);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(264, 40);
            this.lblCustomer.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Copies:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCopies
            // 
            this.txtCopies.Location = new System.Drawing.Point(76, 57);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(48, 20);
            this.txtCopies.TabIndex = 16;
            this.txtCopies.Tag = "Copies";
            // 
            // btnClone
            // 
            this.btnClone.Location = new System.Drawing.Point(140, 57);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(75, 23);
            this.btnClone.TabIndex = 15;
            this.btnClone.Text = "Clone";
            // 
            // lstCustomers
            // 
            this.lstCustomers.Location = new System.Drawing.Point(12, 89);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(264, 134);
            this.lstCustomers.TabIndex = 14;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnClone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(387, 235);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCopies);
            this.Controls.Add(this.btnClone);
            this.Controls.Add(this.lstCustomers);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clone Customer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.ListBox lstCustomers;
    }
}

