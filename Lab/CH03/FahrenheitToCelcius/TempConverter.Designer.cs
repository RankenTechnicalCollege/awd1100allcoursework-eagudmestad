namespace FahrenheitToCelcius
{
    partial class frmTempConverter
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblCelcius = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Enter the degrees in Fahrenheit:";
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(245, 14);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(100, 20);
            this.txtFahrenheit.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(71, 53);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(226, 71);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert to Celcius";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblCelcius
            // 
            this.lblCelcius.AutoSize = true;
            this.lblCelcius.Location = new System.Drawing.Point(71, 156);
            this.lblCelcius.Name = "lblCelcius";
            this.lblCelcius.Size = new System.Drawing.Size(0, 13);
            this.lblCelcius.TabIndex = 3;
            // 
            // frmTempConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 224);
            this.Controls.Add(this.lblCelcius);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.label1);
            this.Name = "frmTempConverter";
            this.Text = "Temp Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblCelcius;
    }
}

