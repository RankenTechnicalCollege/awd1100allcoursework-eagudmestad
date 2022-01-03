using System;
using System.Collections.Generic;
using System.Text;

namespace ProductMaintenance
{
    public class ProductList
	{
		private List<Product> products;

		public delegate void ChangeHandler(ProductList products);
		public event ChangeHandler Changed;

		public ProductList()
		{
			products = new List<Product>();
		}

        public int Count => products.Count;

		public Product this[int i]
		{
			get
			{
				if (i < 0)
				{
					throw new ArgumentOutOfRangeException("i");
				}
				else if (i >= products.Count)
				{
					throw new ArgumentOutOfRangeException("i");
				}
				return products[i];
			}
			set
			{
				products[i] = value;
				Changed(this);
			}
		}

		public Product this[string code]
		{
			get
			{
				foreach (Product p in products)
				{
					if (p.Code == code)
						return p;
				}
				return null;
			}
		}

		public void Fill() => products = ProductDB.GetProducts();

		public void Save() => ProductDB.SaveProducts(products);

		public void Add(Product product)
		{
			products.Add(product);
			Changed(this);
		}

		public void Add(string code, string description, decimal price)
		{
			Product p = new Product(code, description, price);
			products.Add(p);
			Changed(this);
		}

		public void Remove(Product product)
		{
			products.Remove(product);
			Changed(this);
		}

        public static ProductList operator +(ProductList pl, Product p)
        {
            pl.Add(p);
            return pl;
        }

        public static ProductList operator - (ProductList pl, Product p)
		{
			pl.Remove(p);
			return pl;
		}

	}
}
