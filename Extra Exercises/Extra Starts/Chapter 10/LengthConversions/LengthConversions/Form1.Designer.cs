namespace LengthConversions
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
            this.cboConversions = new System.Windows.Forms.ComboBox();
            this.lblFromLength = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblToLength = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtCalculatedLength = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversion:";
            // 
            // cboConversions
            // 
            this.cboConversions.FormattingEnabled = true;
            this.cboConversions.Location = new System.Drawing.Point(99, 21);
            this.cboConversions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboConversions.Name = "cboConversions";
            this.cboConversions.Size = new System.Drawing.Size(175, 23);
            this.cboConversions.TabIndex = 1;
            // 
            // lblFromLength
            // 
            this.lblFromLength.AutoSize = true;
            this.lblFromLength.Location = new System.Drawing.Point(20, 53);
            this.lblFromLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFromLength.Name = "lblFromLength";
            this.lblFromLength.Size = new System.Drawing.Size(38, 15);
            this.lblFromLength.TabIndex = 2;
            this.lblFromLength.Text = "Miles:";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(99, 52);
            this.txtLength.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(106, 23);
            this.txtLength.TabIndex = 3;
            // 
            // lblToLength
            // 
            this.lblToLength.AutoSize = true;
            this.lblToLength.Location = new System.Drawing.Point(20, 83);
            this.lblToLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToLength.Name = "lblToLength";
            this.lblToLength.Size = new System.Drawing.Size(66, 15);
            this.lblToLength.TabIndex = 4;
            this.lblToLength.Text = "Kilometers:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(57, 116);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(78, 25);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(194, 116);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 25);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtCalculatedLength
            // 
            this.txtCalculatedLength.Location = new System.Drawing.Point(99, 81);
            this.txtCalculatedLength.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCalculatedLength.Name = "txtCalculatedLength";
            this.txtCalculatedLength.ReadOnly = true;
            this.txtCalculatedLength.Size = new System.Drawing.Size(106, 23);
            this.txtCalculatedLength.TabIndex = 8;
            this.txtCalculatedLength.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(294, 151);
            this.Controls.Add(this.txtCalculatedLength);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblToLength);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblFromLength);
            this.Controls.Add(this.cboConversions);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboConversions;
        private System.Windows.Forms.Label lblFromLength;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblToLength;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtCalculatedLength;
    }
}

