using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace InventoryMaintenance
{
    public static class InvItemDB
    {
        private const string Path = @"..\..\..\InventoryItems.txt";
        private const string Separator = "|";

        public static List<InvItem> GetItems()
        {
            // create the list
            List<InvItem> items = new List<InvItem>();

            // create the object for the input stream for a text file
            StreamReader textIn =
                new StreamReader(
                new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read));

            // read the data from the file and store it in the list
            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split(Separator);
                InvItem item = new InvItem();
                item.ItemNo = Convert.ToInt32(columns[0]);
                item.Description = columns[1];
                item.Price = Convert.ToDecimal(columns[2]);
                items.Add(item);
            }

            // close the input stream for the text file
            textIn.Close();

            return items;
        }

        public static void SaveItems(List<InvItem> items)
        {
            // create the output stream for a text file that exists
            StreamWriter textOut =
                new StreamWriter(
                new FileStream(Path, FileMode.Create, FileAccess.Write));

            // write each item
            foreach (InvItem item in items)
            {
                textOut.Write(item.ItemNo + Separator);
                textOut.Write(item.Description + Separator);
                textOut.WriteLine(item.Price);
            }

            // close the output stream for the text file
            textOut.Close();
        }
    }
}

