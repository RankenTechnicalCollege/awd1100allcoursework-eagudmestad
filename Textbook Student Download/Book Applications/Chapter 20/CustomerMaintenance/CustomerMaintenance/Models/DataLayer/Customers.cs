using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerMaintenance.Models.DataLayer
{
    public partial class Customers
    {
        public Customers()
        {
            Invoices = new HashSet<Invoices>();
        }

        [Key]
        [Column("CustomerID")]
        public int CustomerId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        [ConcurrencyCheck]
        public string Address { get; set; }

        [Required]
        [StringLength(20)]
        public string City { get; set; }

        [Required]
        [StringLength(2)]
        public string State { get; set; }

        [Required]
        [StringLength(15)]
        public string ZipCode { get; set; }

        //[Required]
        //[Column("rowversion")]
        //public byte[] Rowversion { get; set; }

        [ForeignKey(nameof(State))]
        [InverseProperty(nameof(States.Customers))]
        public virtual States StateNavigation { get; set; }

        [InverseProperty(nameof(DataLayer.Invoices.Customer))]
        public virtual ICollection<Invoices> Invoices { get; set; }
    }
}