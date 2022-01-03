using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace InventoryMaintenance
{
    public static class InvItemDB
    {
        private const string Path = @"..\..\..\InventoryItems.dat";

        public static List<InvItem> GetItems()
        {
            // create the list
            List<InvItem> items = new List<InvItem>();

            // Add code here to read the binary file into the List<InvItem> object.

            return items;
        }

        public static void SaveItems(List<InvItem> items)
        {
            // Add code here to write the List<InvItems> object to a binary file.

        }
    }
}

