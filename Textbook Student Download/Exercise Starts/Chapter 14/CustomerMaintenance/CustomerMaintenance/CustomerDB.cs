using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    public static class CustomerDB
	{
		private const string dir = @"C:\C#\Files\";
		private const string path = dir + "CustomersX14.txt";

        public static List<Customer> GetCustomers()
		{
			// if the directory doesn't exist, create it
			if (!Directory.Exists(dir))
				Directory.CreateDirectory(dir);

			// create the object for the input stream for a text file
			StreamReader textIn = 
				new StreamReader(
					new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

			// create the array list for customers
            List<Customer> customers = new List<Customer>();

			// read the data from the file and store it in the ArrayList
			while (textIn.Peek() != -1)
			{
				string row = textIn.ReadLine();
				string[] columns = row.Split('|');
                if (columns[0] == "Wholesale")
                {
                    customers.Add(GetWholesale(columns));
                }
                else
                {
                    customers.Add(GetRetail(columns));
                }
			}

			textIn.Close();

			return customers;
		}

        public static WholesaleCustomer GetWholesale(string[] columns)
        {
            WholesaleCustomer customer = new WholesaleCustomer();
            customer.FirstName = columns[1];
            customer.LastName = columns[2];
            customer.Email = columns[3];
            customer.Company = columns[4];
            return customer;
        }

        public static RetailCustomer GetRetail(string[] columns)
        {
            RetailCustomer customer = new RetailCustomer();
            customer.FirstName = columns[1];
            customer.LastName = columns[2];
            customer.Email = columns[3];
            customer.HomePhone = columns[4];
            return customer;
        }

        public static void SaveCustomers(List<Customer> customers)
        {
            // create the output stream for a text file that exists
            StreamWriter textOut =
                new StreamWriter(
                new FileStream(path, FileMode.Create, FileAccess.Write));

            // write each customer
            foreach (Customer customer in customers)
            {
                if (customer.GetType().Name == "WholesaleCustomer")
                {
                    WriteWholesale((WholesaleCustomer)customer, textOut);
                }
                else if (customer.GetType().Name == "RetailCustomer")
                {
                    WriteRetail((RetailCustomer)customer, textOut);
                }
            }
            // write the end of the document
            textOut.Close();
        }

        public static void WriteWholesale(WholesaleCustomer customer, StreamWriter textOut)
        {
            textOut.Write("Wholesale" + "|");
            textOut.Write(customer.FirstName + "|");
            textOut.Write(customer.LastName + "|");
            textOut.Write(customer.Email + "|");
            textOut.WriteLine(customer.Company);
        }

        public static void WriteRetail(RetailCustomer customer, StreamWriter textOut)
        {
            textOut.Write("Retail" + "|");
            textOut.Write(customer.FirstName + "|");
            textOut.Write(customer.LastName + "|");
            textOut.Write(customer.Email + "|");
            textOut.WriteLine(customer.HomePhone);

        }
    }
}
