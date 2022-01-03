namespace LunchOrder
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
            this.gbxMainCourse = new System.Windows.Forms.GroupBox();
            this.rdoSalad = new System.Windows.Forms.RadioButton();
            this.rdoPizza = new System.Windows.Forms.RadioButton();
            this.rdoHamburger = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalesTax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxAddOnItems = new System.Windows.Forms.GroupBox();
            this.chkAddOn3 = new System.Windows.Forms.CheckBox();
            this.chkAddOn2 = new System.Windows.Forms.CheckBox();
            this.chkAddOn1 = new System.Windows.Forms.CheckBox();
            this.gbxMainCourse.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbxAddOnItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMainCourse
            // 
            this.gbxMainCourse.Controls.Add(this.rdoSalad);
            this.gbxMainCourse.Controls.Add(this.rdoPizza);
            this.gbxMainCourse.Controls.Add(this.rdoHamburger);
            this.gbxMainCourse.Location = new System.Drawing.Point(22, 17);
            this.gbxMainCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxMainCourse.Name = "gbxMainCourse";
            this.gbxMainCourse.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxMainCourse.Size = new System.Drawing.Size(159, 98);
            this.gbxMainCourse.TabIndex = 0;
            this.gbxMainCourse.TabStop = false;
            this.gbxMainCourse.Text = "Main Course";
            // 
            // rdoSalad
            // 
            this.rdoSalad.AutoSize = true;
            this.rdoSalad.Location = new System.Drawing.Point(13, 73);
            this.rdoSalad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoSalad.Name = "rdoSalad";
            this.rdoSalad.Size = new System.Drawing.Size(91, 19);
            this.rdoSalad.TabIndex = 2;
            this.rdoSalad.Text = "Salad - $4.95";
            this.rdoSalad.UseVisualStyleBackColor = true;
            this.rdoSalad.CheckedChanged += new System.EventHandler(this.MainCourse_CheckedChanged);
            // 
            // rdoPizza
            // 
            this.rdoPizza.AutoSize = true;
            this.rdoPizza.Location = new System.Drawing.Point(13, 49);
            this.rdoPizza.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoPizza.Name = "rdoPizza";
            this.rdoPizza.Size = new System.Drawing.Size(89, 19);
            this.rdoPizza.TabIndex = 1;
            this.rdoPizza.Text = "Pizza - $5.95";
            this.rdoPizza.UseVisualStyleBackColor = true;
            this.rdoPizza.CheckedChanged += new System.EventHandler(this.MainCourse_CheckedChanged);
            // 
            // rdoHamburger
            // 
            this.rdoHamburger.AutoSize = true;
            this.rdoHamburger.Checked = true;
            this.rdoHamburger.Location = new System.Drawing.Point(13, 25);
            this.rdoHamburger.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoHamburger.Name = "rdoHamburger";
            this.rdoHamburger.Size = new System.Drawing.Size(124, 19);
            this.rdoHamburger.TabIndex = 0;
            this.rdoHamburger.TabStop = true;
            this.rdoHamburger.Text = "Hamburger - $6.95";
            this.rdoHamburger.UseVisualStyleBackColor = true;
            this.rdoHamburger.CheckedChanged += new System.EventHandler(this.MainCourse_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOrderTotal);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSalesTax);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSubtotal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(22, 133);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(260, 114);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(112, 76);
            this.txtOrderTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(106, 23);
            this.txtOrderTotal.TabIndex = 5;
            this.txtOrderTotal.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Order Total:";
            // 
            // txtSalesTax
            // 
            this.txtSalesTax.Location = new System.Drawing.Point(112, 50);
            this.txtSalesTax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSalesTax.Name = "txtSalesTax";
            this.txtSalesTax.ReadOnly = true;
            this.txtSalesTax.Size = new System.Drawing.Size(106, 23);
            this.txtSalesTax.TabIndex = 3;
            this.txtSalesTax.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tax (7.75%):";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(112, 23);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(106, 23);
            this.txtSubtotal.TabIndex = 1;
            this.txtSubtotal.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal:";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(334, 139);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(78, 25);
            this.btnPlaceOrder.TabIndex = 2;
            this.btnPlaceOrder.Text = "Place &Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(334, 222);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 25);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbxAddOnItems
            // 
            this.gbxAddOnItems.Controls.Add(this.chkAddOn3);
            this.gbxAddOnItems.Controls.Add(this.chkAddOn2);
            this.gbxAddOnItems.Controls.Add(this.chkAddOn1);
            this.gbxAddOnItems.Location = new System.Drawing.Point(202, 17);
            this.gbxAddOnItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxAddOnItems.Name = "gbxAddOnItems";
            this.gbxAddOnItems.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxAddOnItems.Size = new System.Drawing.Size(210, 98);
            this.gbxAddOnItems.TabIndex = 4;
            this.gbxAddOnItems.TabStop = false;
            this.gbxAddOnItems.Text = "Add-on items ($.75/each)";
            // 
            // chkAddOn3
            // 
            this.chkAddOn3.AutoSize = true;
            this.chkAddOn3.Location = new System.Drawing.Point(16, 73);
            this.chkAddOn3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkAddOn3.Name = "chkAddOn3";
            this.chkAddOn3.Size = new System.Drawing.Size(87, 19);
            this.chkAddOn3.TabIndex = 2;
            this.chkAddOn3.Text = "French fries";
            this.chkAddOn3.UseVisualStyleBackColor = true;
            this.chkAddOn3.CheckedChanged += new System.EventHandler(this.AddOn_CheckedChanged);
            // 
            // chkAddOn2
            // 
            this.chkAddOn2.AutoSize = true;
            this.chkAddOn2.Location = new System.Drawing.Point(16, 49);
            this.chkAddOn2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkAddOn2.Name = "chkAddOn2";
            this.chkAddOn2.Size = new System.Drawing.Size(179, 19);
            this.chkAddOn2.TabIndex = 1;
            this.chkAddOn2.Text = "Ketchup, mustard, and mayo";
            this.chkAddOn2.UseVisualStyleBackColor = true;
            this.chkAddOn2.CheckedChanged += new System.EventHandler(this.AddOn_CheckedChanged);
            // 
            // chkAddOn1
            // 
            this.chkAddOn1.AutoSize = true;
            this.chkAddOn1.Location = new System.Drawing.Point(16, 25);
            this.chkAddOn1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkAddOn1.Name = "chkAddOn1";
            this.chkAddOn1.Size = new System.Drawing.Size(179, 19);
            this.chkAddOn1.TabIndex = 0;
            this.chkAddOn1.Text = "Lettuce, tomator, and onions";
            this.chkAddOn1.UseVisualStyleBackColor = true;
            this.chkAddOn1.CheckedChanged += new System.EventHandler(this.AddOn_CheckedChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPlaceOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(433, 258);
            this.Controls.Add(this.gbxAddOnItems);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbxMainCourse);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lunch Order";
            this.gbxMainCourse.ResumeLayout(false);
            this.gbxMainCourse.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbxAddOnItems.ResumeLayout(false);
            this.gbxAddOnItems.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMainCourse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalesTax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rdoSalad;
        private System.Windows.Forms.RadioButton rdoPizza;
        private System.Windows.Forms.RadioButton rdoHamburger;
        private System.Windows.Forms.GroupBox gbxAddOnItems;
        private System.Windows.Forms.CheckBox chkAddOn3;
        private System.Windows.Forms.CheckBox chkAddOn2;
        private System.Windows.Forms.CheckBox chkAddOn1;
    }
}

