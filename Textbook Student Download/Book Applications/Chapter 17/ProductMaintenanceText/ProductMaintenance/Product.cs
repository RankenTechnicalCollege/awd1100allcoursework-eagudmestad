using System;

namespace ProductMaintenance
{
	public class Product
	{
		public Product()
		{
		}

        public Product(string Code, string Description, decimal Price)
        {
            this.Code = Code;
            this.Description = Description;
            this.Price = Price;
        }

		public string Code { get; set; }

		public string Description { get; set; }

		public decimal Price { get; set; }

		public string GetDisplayText(string sep) =>
			Code + sep + Price.ToString("c") + sep + Description;

    }
}
