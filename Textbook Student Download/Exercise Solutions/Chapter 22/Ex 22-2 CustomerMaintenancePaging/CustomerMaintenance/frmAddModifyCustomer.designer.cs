using System.Windows.Forms;
namespace CustomerMaintenance
{
    public partial class frmAddModifyCustomer : Form
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
            System.Windows.Forms.Label ZipCodeLabel;
            System.Windows.Forms.Label StateNameLabel;
            System.Windows.Forms.Label CityLabel;
            System.Windows.Forms.Label Address1Label;
            System.Windows.Forms.Label NameLabel;
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboStates = new System.Windows.Forms.ComboBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ZipCodeLabel = new System.Windows.Forms.Label();
            StateNameLabel = new System.Windows.Forms.Label();
            CityLabel = new System.Windows.Forms.Label();
            Address1Label = new System.Windows.Forms.Label();
            NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ZipCodeLabel
            // 
            ZipCodeLabel.AutoSize = true;
            ZipCodeLabel.Location = new System.Drawing.Point(255, 99);
            ZipCodeLabel.Name = "ZipCodeLabel";
            ZipCodeLabel.Size = new System.Drawing.Size(52, 13);
            ZipCodeLabel.TabIndex = 8;
            ZipCodeLabel.Text = "Zip code:";
            // 
            // StateNameLabel
            // 
            StateNameLabel.AutoSize = true;
            StateNameLabel.Location = new System.Drawing.Point(19, 99);
            StateNameLabel.Name = "StateNameLabel";
            StateNameLabel.Size = new System.Drawing.Size(35, 13);
            StateNameLabel.TabIndex = 6;
            StateNameLabel.Text = "State:";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new System.Drawing.Point(19, 73);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new System.Drawing.Size(27, 13);
            CityLabel.TabIndex = 4;
            CityLabel.Text = "City:";
            // 
            // Address1Label
            // 
            Address1Label.AutoSize = true;
            Address1Label.Location = new System.Drawing.Point(19, 47);
            Address1Label.Name = "Address1Label";
            Address1Label.Size = new System.Drawing.Size(48, 13);
            Address1Label.TabIndex = 2;
            Address1Label.Text = "Address:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new System.Drawing.Point(19, 21);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new System.Drawing.Size(38, 13);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name:";

            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(313, 96);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(80, 20);
            this.txtZipCode.TabIndex = 9;
            this.txtZipCode.Tag = "Zip code";

            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(93, 70);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(300, 20);
            this.txtCity.TabIndex = 5;
            this.txtCity.Tag = "City";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(93, 44);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(300, 20);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.Tag = "Address";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(93, 18);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Tag = "Name";
            // 
            // cboStates
            // 
            this.cboStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStates.FormattingEnabled = true;
            this.cboStates.Location = new System.Drawing.Point(93, 97);
            this.cboStates.Name = "cboStates";
            this.cboStates.Size = new System.Drawing.Size(150, 21);
            this.cboStates.TabIndex = 7;
            this.cboStates.Tag = "State";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(22, 151);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 10;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(317, 150);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddModifyCustomer
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(412, 190);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.cboStates);
            this.Controls.Add(ZipCodeLabel);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(StateNameLabel);
            this.Controls.Add(CityLabel);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(Address1Label);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(NameLabel);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmAddModifyCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmAddModifyCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;            
        }

        #endregion
        internal System.Windows.Forms.TextBox txtZipCode;
        internal System.Windows.Forms.TextBox txtCity;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cboStates;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        
    }
}