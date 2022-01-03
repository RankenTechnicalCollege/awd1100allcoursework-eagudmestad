using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CustomerMaintenance
{
    /// <summary>
    /// CustomerDB class
    /// </summary>
    public static class CustomerDB
	{
		private const string dir = @"C:\C#\Files\";
		private const string path = dir + "Customers.dat";

		public static void SaveCustomers(List<Customer> customers)
		{
			// create the output stream for a binary file
            BinaryWriter binaryOut =
                new BinaryWriter(
                new FileStream(path, FileMode.Create, FileAccess.Write));

			// write each customer
            foreach (Customer c in customers)
            {
                binaryOut.Write(c.FirstName);
                binaryOut.Write(c.LastName);
                binaryOut.Write(c.Email);
            }

			// write the end of the document
            binaryOut.Close();
        }

        public static List<Customer> GetCustomers()
		{
            // if the directory doesn't exist, create it
			if (!Directory.Exists(dir))
				Directory.CreateDirectory(dir);

            // create the array list for customers
            List<Customer> customers = new List<Customer>();

            // create the object for the input stream for a binary file
            BinaryReader binaryIn =
                new BinaryReader(
                new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            // read the data from the file and store it in the List<>
            while (binaryIn.PeekChar() != -1)
            {
                Customer c = new Customer();
                c.FirstName = binaryIn.ReadString();
                c.LastName = binaryIn.ReadString();
                c.Email = binaryIn.ReadString();
                customers.Add(c);
            }

            binaryIn.Close();

			return customers;
		}
	}
}
