using System;
using System.Collections.Generic;
using System.Text;

namespace ProductMaintenance.Model
{
    partial class Products
    {
        public Products(string prodCode, string description, int quantity, decimal price)
        {
            this.ProductCode = prodCode;
            this.Description = description;
            this.OnHandQuantity = quantity;
            this.UnitPrice = price;
        }
    }
}