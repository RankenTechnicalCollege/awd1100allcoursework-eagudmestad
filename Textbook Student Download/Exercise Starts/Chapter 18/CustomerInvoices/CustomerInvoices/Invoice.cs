using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInvoices
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public int CustomerID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal ProductTotal { get; set; }
        public decimal SalesTax { get; set; }
        public decimal Shipping { get; set; }
        public decimal InvoiceTotal { get; set; }
    }
}
