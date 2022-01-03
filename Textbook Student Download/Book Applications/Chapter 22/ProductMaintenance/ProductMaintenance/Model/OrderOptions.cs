using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductMaintenance.Model
{
    public partial class OrderOptions
    {
        [Column(TypeName = "decimal(18, 4)")]
        public decimal SalesTaxRate { get; set; }
        [Column(TypeName = "money")]
        public decimal FirstBookShipCharge { get; set; }
        [Column(TypeName = "money")]
        public decimal AdditionalBookShipCharge { get; set; }
    }
}
