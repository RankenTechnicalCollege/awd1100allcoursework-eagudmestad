namespace ChangeCalculator
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
            this.txtChange = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuarters = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDimes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNickels = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPennies = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount of change due (0-99):";
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(202, 20);
            this.txtChange.Margin = new System.Windows.Forms.Padding(2);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(54, 23);
            this.txtChange.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(139, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quarters:";
            // 
            // txtQuarters
            // 
            this.txtQuarters.Location = new System.Drawing.Point(202, 49);
            this.txtQuarters.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuarters.Name = "txtQuarters";
            this.txtQuarters.ReadOnly = true;
            this.txtQuarters.Size = new System.Drawing.Size(54, 23);
            this.txtQuarters.TabIndex = 3;
            this.txtQuarters.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(152, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dimes:";
            // 
            // txtDimes
            // 
            this.txtDimes.Location = new System.Drawing.Point(202, 77);
            this.txtDimes.Margin = new System.Windows.Forms.Padding(2);
            this.txtDimes.Name = "txtDimes";
            this.txtDimes.ReadOnly = true;
            this.txtDimes.Size = new System.Drawing.Size(54, 23);
            this.txtDimes.TabIndex = 5;
            this.txtDimes.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(148, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nickels:";
            // 
            // txtNickels
            // 
            this.txtNickels.Location = new System.Drawing.Point(202, 105);
            this.txtNickels.Margin = new System.Windows.Forms.Padding(2);
            this.txtNickels.Name = "txtNickels";
            this.txtNickels.ReadOnly = true;
            this.txtNickels.Size = new System.Drawing.Size(54, 23);
            this.txtNickels.TabIndex = 7;
            this.txtNickels.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(146, 135);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pennies:";
            // 
            // txtPennies
            // 
            this.txtPennies.Location = new System.Drawing.Point(202, 133);
            this.txtPennies.Margin = new System.Windows.Forms.Padding(2);
            this.txtPennies.Name = "txtPennies";
            this.txtPennies.ReadOnly = true;
            this.txtPennies.Size = new System.Drawing.Size(54, 23);
            this.txtPennies.TabIndex = 9;
            this.txtPennies.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(78, 169);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(78, 25);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(178, 169);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 25);
            this.btnExit.TabIndex = 2;
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
            this.ClientSize = new System.Drawing.Size(280, 216);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtPennies);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNickels);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDimes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQuarters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuarters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDimes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNickels;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPennies;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}

