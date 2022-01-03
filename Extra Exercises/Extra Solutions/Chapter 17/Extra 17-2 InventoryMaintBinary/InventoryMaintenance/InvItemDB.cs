using System;
using System.Collections.Generic;
using System.IO;
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

            // create the object for the input stream for a binary file
            BinaryReader binaryIn =
                new BinaryReader(
                new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read));

            // read the data from the file and store it in the List<InvItem>
            while (binaryIn.PeekChar() != -1)
            {
                InvItem item = new InvItem();
                item.ItemNo = binaryIn.ReadInt32();
                item.Description = binaryIn.ReadString();
                item.Price = binaryIn.ReadDecimal();
                items.Add(item);
            }

            // close the input stream for the binary file
            binaryIn.Close();

            return items;
        }

        public static void SaveItems(List<InvItem> items)
        {
            // create the output stream for a binary file that exists
            BinaryWriter binaryOut =
                new BinaryWriter(
                new FileStream(Path, FileMode.Create, FileAccess.Write));

            // write each item
            foreach (InvItem item in items)
            {
                binaryOut.Write(item.ItemNo);
                binaryOut.Write(item.Description);
                binaryOut.Write(item.Price);
            }

            // close the output stream
            binaryOut.Close();
        }
    }
}

