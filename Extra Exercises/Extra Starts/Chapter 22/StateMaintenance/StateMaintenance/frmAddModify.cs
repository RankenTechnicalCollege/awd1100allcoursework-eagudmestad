using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using StateMaintenance.Models;

namespace StateMaintenance
{
    public partial class frmAddModify : Form
    {
        public frmAddModify()
        {
            InitializeComponent();
        }

        public State State { get; set; }
        public bool AddState { get; set; }

        private void frmAddModify_Load(object sender, EventArgs e)
        {
            if (AddState)
            {
                this.Text = "Add State";
                txtStateCode.Enabled = true;
                this.State = new State();
            }
            else
            {
                this.Text = "Modify State";
                txtStateCode.Enabled = false;   // don't modify existing primary key
                DisplayState();
            }
        }

        private void DisplayState()
        {
            txtStateCode.Text = this.State.StateCode;
            txtStateName.Text = this.State.StateName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                LoadData();
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtStateCode) &&
                   Validator.IsPresent(txtStateName);
        }

        private void LoadData()
        {
            this.State.StateCode = txtStateCode.Text;
            this.State.StateName = txtStateName.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
