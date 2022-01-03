using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CustomerInvoices
{
    public static class CustomerDB
    {
        private const string Dir = @"C:\C#\Files\";
        private const string Path = Dir + "Customers18.txt";

        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            StreamReader textIn = new StreamReader(
                new FileStream(Path, FileMode.Open, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');
                Customer customer = new Customer();
                customer.CustomerID = Convert.ToInt32(columns[0]);
                customer.Name = columns[1];
                customers.Add(customer);
            }

            textIn.Close();
            return customers;
        }
    }
}
