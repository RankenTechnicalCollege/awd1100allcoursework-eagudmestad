using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using StateMaintenance.Models;

namespace StateMaintenance
{
    public partial class frmStateMaintenance : Form
    {
        public frmStateMaintenance()
        {
            InitializeComponent();
        }

        MMABooksContext context = new MMABooksContext();
        State selectedState = null;

        // private constants for the index values of the Modify and Delete button columns
        private const int ModifyIndex = 2;
        private const int DeleteIndex = 3;

        // private constants and variables for paging
        private const int MaxRows = 10;
        private int totalRows = 0;
        private int pages = 0;
        private int pageNumber = 1;

        private void frmStateMaintenance_Load(object sender, EventArgs e)
        {
            totalRows = context.States.Count();
            pages = totalRows / MaxRows;
            if (totalRows % MaxRows != 0)
            {
                pages += 1;
            }

            pageNumber = 1;

            DisplayStates();
        }

        private void DisplayStates()
        {
            dgvStates.Columns.Clear();

            int skip = MaxRows * (pageNumber - 1);

            totalRows = context.States.Count();
            int take = MaxRows;
            if (pageNumber == pages)
            {
                take = totalRows - skip;
            }
            if (totalRows <= MaxRows)
            {
                take = totalRows;
            }

            dgvStates.DataSource = context.States
                                    .OrderBy(s => s.StateName)
                                    .Select(s => new { s.StateCode, s.StateName })
                                    .Skip(skip)
                                    .Take(take)
                                    .ToList();

            // add column for modify button
            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Modify"
            };
            dgvStates.Columns.Insert(ModifyIndex, modifyColumn);

            // add column for delete button
            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            dgvStates.Columns.Insert(DeleteIndex, deleteColumn);

            // format the column headers
            dgvStates.EnableHeadersVisualStyles = false;
            dgvStates.ColumnHeadersDefaultCellStyle.Font =
                new Font("Arial", 9, FontStyle.Bold);
            dgvStates.ColumnHeadersDefaultCellStyle.BackColor = Color.Goldenrod;
            dgvStates.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // format the odd numbered rows
            dgvStates.AlternatingRowsDefaultCellStyle.BackColor =
                Color.PaleGoldenrod;

            // format the first column
            dgvStates.Columns[0].HeaderText = "Code";
            dgvStates.Columns[0].Width = 60;

            // format the second column
            dgvStates.Columns[1].HeaderText = "State Name";
            dgvStates.Columns[1].Width = 136;

            EnableDisableButtons();
        }

        private void EnableDisableButtons()
        {
            if (pageNumber == 1)
            {
                btnFirst.Enabled = false;
                btnPrevious.Enabled = false;
            }
            else
            {
                btnFirst.Enabled = true;
                btnPrevious.Enabled = true;
            }

            if (pageNumber == pages)
            {
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
                btnLast.Enabled = true;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            DisplayStates();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            pageNumber -= 1;
            DisplayStates();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pageNumber += 1;
            DisplayStates();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            pageNumber = pages;
            DisplayStates();
        }

        private void dgvStates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ModifyIndex || e.ColumnIndex == DeleteIndex)
            {
                string code = dgvStates.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                selectedState = context.States.Find(code);
            }
            if (e.ColumnIndex == ModifyIndex)
                ModifyState();
            else if (e.ColumnIndex == DeleteIndex)
                DeleteState();
        }

        private void ModifyState()
        {
            var modifyForm = new frmAddModify()
            {
                AddState = false,
                State = selectedState
            };
            DialogResult result = modifyForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    selectedState = modifyForm.State;
                    context.SaveChanges();
                    DisplayStates();
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        private void DeleteState()
        {
            DialogResult result =
                MessageBox.Show($"Delete {selectedState.StateName.Trim()}?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    context.States.Remove(selectedState);
                    context.SaveChanges(true);
                    DisplayStates();
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new frmAddModify
            {
                AddState = true
            };
            DialogResult result = addForm.ShowDialog();
            if (result == DialogResult.OK)
            { 
                try
                {
                    selectedState = addForm.State;
                    context.States.Add(selectedState);
                    context.SaveChanges();
                    DisplayStates();
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        private void HandleDatabaseError(DbUpdateException ex)
        {
            string errorMessage = "";
            var sqlException = (SqlException)ex.InnerException;
            foreach (SqlError error in sqlException.Errors)
            {
                errorMessage += "ERROR CODE: " + error.Number + " " +
                error.Message + "\n";
            }
            MessageBox.Show(errorMessage);
        }

        private void HandleGeneralError(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
