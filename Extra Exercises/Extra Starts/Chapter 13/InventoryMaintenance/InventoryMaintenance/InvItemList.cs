using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMaintenance
{
    public class InvItemList
    {
        private List<InvItem> invItems;

        public InvItemList()
        {
            invItems = new List<InvItem>();
        }

        public int Count => invItems.Count;

        public InvItem GetItemByIndex(int i) => invItems[i];

        public void Add(InvItem invItem) => invItems.Add(invItem);

        public void Add(int itemNo, string description, decimal price)
        {
            InvItem i = new InvItem(itemNo, description, price);
            invItems.Add(i);
        }

        public void Remove(InvItem invItem) => invItems.Remove(invItem);

        public void Fill() => invItems = InvItemDB.GetItems();

        public void Save() => InvItemDB.SaveItems(invItems);
    }
}
