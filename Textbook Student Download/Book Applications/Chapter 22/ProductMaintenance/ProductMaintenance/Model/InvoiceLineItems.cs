using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductMaintenance.Model
{
    public partial class InvoiceLineItems
    {
        [Column("InvoiceID")]
        public int InvoiceId { get; set; }
        [StringLength(10)]
        public string ProductCode { get; set; }
        [Column(TypeName = "money")]
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "money")]
        public decimal ItemTotal { get; set; }

        [ForeignKey(nameof(InvoiceId))]
        [InverseProperty(nameof(Invoices.InvoiceLineItems))]
        public virtual Invoices Invoice { get; set; }
        [ForeignKey(nameof(ProductCode))]
        [InverseProperty(nameof(Products.InvoiceLineItems))]
        public virtual Products ProductCodeNavigation { get; set; }
    }
}
