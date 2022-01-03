namespace Reservations
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtArrivalDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDepartureDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNights = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAvgPrice = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arrival date:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtArrivalDate
            // 
            this.txtArrivalDate.Location = new System.Drawing.Point(166, 28);
            this.txtArrivalDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtArrivalDate.Name = "txtArrivalDate";
            this.txtArrivalDate.Size = new System.Drawing.Size(106, 23);
            this.txtArrivalDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Departure date:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDepartureDate
            // 
            this.txtDepartureDate.Location = new System.Drawing.Point(166, 57);
            this.txtDepartureDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDepartureDate.Name = "txtDepartureDate";
            this.txtDepartureDate.Size = new System.Drawing.Size(106, 23);
            this.txtDepartureDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of nights:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNights
            // 
            this.txtNights.Location = new System.Drawing.Point(166, 86);
            this.txtNights.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNights.Name = "txtNights";
            this.txtNights.ReadOnly = true;
            this.txtNights.Size = new System.Drawing.Size(106, 23);
            this.txtNights.TabIndex = 5;
            this.txtNights.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Total price:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(166, 116);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(106, 23);
            this.txtTotalPrice.TabIndex = 7;
            this.txtTotalPrice.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 147);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Avg. price per night:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAvgPrice
            // 
            this.txtAvgPrice.Location = new System.Drawing.Point(166, 145);
            this.txtAvgPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAvgPrice.Name = "txtAvgPrice";
            this.txtAvgPrice.ReadOnly = true;
            this.txtAvgPrice.Size = new System.Drawing.Size(106, 23);
            this.txtAvgPrice.TabIndex = 9;
            this.txtAvgPrice.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(51, 192);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(78, 25);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(166, 192);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 25);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(312, 238);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtAvgPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNights);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDepartureDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtArrivalDate);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArrivalDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDepartureDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNights;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAvgPrice;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

