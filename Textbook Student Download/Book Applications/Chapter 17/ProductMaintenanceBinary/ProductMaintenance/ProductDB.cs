using System;
using System.IO;
using System.Collections.Generic;

namespace ProductMaintenance
{
    public class ProductDB
	{
		private const string dir = @"C:\C#\Files\";
		private const string path = dir + "Products.dat";

		public static List<Product> GetProducts()
		{
			// if the directory doesn't exist, create it
			if (!Directory.Exists(dir))
				Directory.CreateDirectory(dir);

			// create the object for the input stream for a binary file
			BinaryReader binaryIn = 
				new BinaryReader(
				new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

			// create the array list
			List<Product> products = new List<Product>();

			// read the data from the file and store it in the List<Product>
			while (binaryIn.PeekChar() != -1)
			{
				Product product = new Product();
				product.Code = binaryIn.ReadString();
				product.Description = binaryIn.ReadString();
				product.Price = binaryIn.ReadDecimal();
				products.Add(product);
			}
            binaryIn.Close();

			return products;
		}

		public static void SaveProducts(List<Product> products)
		{
			// create the output stream for a binary file that exists
			BinaryWriter binaryOut = 
				new BinaryWriter(
				new FileStream(path, FileMode.Create, FileAccess.Write));

			// write each product
			foreach (Product product in products)
			{
				binaryOut.Write(product.Code);
				binaryOut.Write(product.Description);
				binaryOut.Write(product.Price);
			}
			binaryOut.Close();
	   }
	}
}
