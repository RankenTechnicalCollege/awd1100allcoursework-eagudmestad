using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerMaintenance.Models.DataLayer
{
    
    public partial class Customers
    {
        public bool HasAddress => !string.IsNullOrEmpty(Address);
    }
}
