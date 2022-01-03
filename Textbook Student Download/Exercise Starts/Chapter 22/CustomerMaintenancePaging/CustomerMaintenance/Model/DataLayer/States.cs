using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerMaintenance.Model.DataLayer
{
    public partial class States
    {
        public States()
        {
            Customers = new HashSet<Customers>();
        }

        [Key]
        [StringLength(2)]
        public string StateCode { get; set; }
        [Required]
        [StringLength(20)]
        public string StateName { get; set; }

        [InverseProperty(nameof(Model.DataLayer.Customers.StateNavigation))]
        public virtual ICollection<Customers> Customers { get; set; }
    }
}
