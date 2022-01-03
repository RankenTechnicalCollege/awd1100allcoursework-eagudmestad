using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace CustomerMaintenance.Models.DataLayer
{
    public class ProductsMetadata
    {
        [Range(0.1, 1000000.0,
            ErrorMessage = "Price must be greater than zero.")]
        public decimal UnitPrice { get; set; }
    }
}
