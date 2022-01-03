//using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerMaintenance.Models.DataLayer
{
    //need to include the Microsoft.Aspnet.MVC.core to do metadata stuff
    //[ModelMetadataType(typeof(ProductsMetadata))]
    public partial class Products
    {
        public bool HasDescription => !string.IsNullOrEmpty(Description);
    }

}
