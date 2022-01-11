namespace LectureDemo
{
    partial class Form1
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
            this.txtNumberOne = new System.Windows.Forms.TextBox();
            this.txtNumberTwo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumberOne
            // 
            this.txtNumberOne.Location = new System.Drawing.Point(119, 37);
            this.txtNumberOne.Name = "txtNumberOne";
            this.txtNumberOne.Size = new System.Drawing.Size(100, 20);
            this.txtNumberOne.TabIndex = 0;
            // 
            // txtNumberTwo
            // 
            this.txtNumberTwo.Location = new System.Drawing.Point(299, 37);
            this.txtNumberTwo.Name = "txtNumberTwo";
            this.txtNumberTwo.Size = new System.Drawing.Size(100, 20);
            this.txtNumberTwo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "X";
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(119, 81);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(280, 116);
            this.btnMultiply.TabIndex = 3;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(119, 244);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnMultiply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 312);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumberTwo);
            this.Controls.Add(this.txtNumberOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumberOne;
        private System.Windows.Forms.TextBox txtNumberTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Label lblResult;
    }
}

