using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CustomerInvoices
{
    public static class InvoiceDB
    {
        private const string Dir = @"C:\C#\Files\";
        private const string Path = Dir + "Invoices.txt";

        public static List<Invoice> GetInvoices()
        {
            List<Invoice> invoices = new List<Invoice>();

            StreamReader textIn = new StreamReader(
                new FileStream(Path, FileMode.Open, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');
                Invoice invoice = new Invoice();
                invoice.InvoiceID = Convert.ToInt32(columns[0]);
                invoice.CustomerID = Convert.ToInt32(columns[1]);
                invoice.InvoiceDate = Convert.ToDateTime(columns[2]);
                invoice.ProductTotal = Convert.ToDecimal(columns[3]);
                invoice.SalesTax = Convert.ToDecimal(columns[4]);
                invoice.Shipping = Convert.ToDecimal(columns[5]);
                invoice.InvoiceTotal = Convert.ToDecimal(columns[6]);
                invoices.Add(invoice);
            }

            textIn.Close();
            return invoices;
        }
    }
}
