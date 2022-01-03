using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmInvMaint : Form
    {
        public frmInvMaint()
        {
            InitializeComponent();
        }

        private List<InvItem> invItems = null;

        private void frmInvMaint_Load(object sender, EventArgs e)
        {
            invItems = InvItemDB.GetItems();
            LoadComboBox();
            FillItemListBox();
        }

        private void LoadComboBox()
        {
            cboFilterBy.DataSource = new string[] {
                "All", "Under $10", "$10 to $50", "Over $50"
            };
        }

        private void FillItemListBox()
        { 
            lstItems.Items.Clear();
            
            string filter = cboFilterBy.SelectedValue.ToString();
            IEnumerable<InvItem> filteredItems = null;

            // query expressions
            if (filter == "All")
                filteredItems =
                    from item in invItems
                    orderby item.Description
                    select item;
            else if (filter == "Under $10")
                filteredItems =
                    from item in invItems
                    where item.Price < 10
                    orderby item.Description
                    select item;
            else if (filter == "$10 to $50")
                filteredItems =
                    from item in invItems
                    where item.Price >= 10 && item.Price <= 50
                    orderby item.Description
                    select item;
            else if (filter == "Over $50")
                filteredItems =
                    from item in invItems
                    where item.Price > 50
                    orderby item.Description
                    select item;

            //// method-based
            //if (filter == "All")
            //    filteredItems = invItems
            //        .OrderBy(item => item.Description);
            //else if (filter == "Under $10")
            //    filteredItems = invItems
            //        .Where(item => item.Price < 10)
            //        .OrderBy(item => item.Description);
            //else if (filter == "$10 to $50")
            //    filteredItems = invItems
            //        .Where(item => item.Price >= 10 && item.Price <= 50)
            //        .OrderBy(item => item.Description);
            //else if (filter == "Over $50")
            //    filteredItems = invItems
            //        .Where(item => item.Price > 50)
            //        .OrderBy(item => item.Description);

            foreach (InvItem item in filteredItems)
            {
                lstItems.Items.Add(item.DisplayText);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewItem newItemForm = new frmNewItem();
            InvItem invItem = newItemForm.GetNewItem();
            if (invItem != null)
            {
                invItems.Add(invItem);
                InvItemDB.SaveItems(invItems);
                FillItemListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstItems.SelectedIndex;
            if (i != -1)
            {
                //InvItem invItem = (InvItem)invItems[i];
                string displayText = lstItems.Items[i].ToString();
                InvItem invItem = invItems
                                  .Where(item => item.DisplayText == displayText)
                                  .FirstOrDefault();

                string message = $"Are you sure you want to delete {invItem.Description}?";
                DialogResult button =
                    MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    invItems.Remove(invItem);
                    InvItemDB.SaveItems(invItems);
                    FillItemListBox();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillItemListBox();
        }
    }
}
