using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CustomerMaintenanceCustomerMaintenance.Models.DataLayer
{
    public class CustomersMetadata
    {
        [RegularExpression("^[0-9]{5}(?:-[0-9]{4})?$",
            ErrorMessage = "Zip code is not valid.")]
        public string ZipCode { get; set; }
    }
}
