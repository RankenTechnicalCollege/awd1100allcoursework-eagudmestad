using System;

namespace ProductMaintenance
{
    public class Product
    {
        public Product() { }

        public Product(string code, string description, decimal price)
        {
            this.Code = code;
            this.Description = description;
            this.Price = price;
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public virtual string GetDisplayText(string sep) =>
            Code + sep + Price.ToString("c") + sep + Description;
    }
}