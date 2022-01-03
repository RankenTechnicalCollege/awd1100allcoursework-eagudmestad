using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryMaintenance
{
    public class Supply : InvItem
    {
        public Supply() { }

        public Supply(int itemNo, string description, decimal price, string manufacturer) :
            base(itemNo, description, price)
        {
            Manufacturer = manufacturer;
        }

        public string Manufacturer { get; set; }

        public override string GetDisplayText() =>
            $"{ItemNo}    {Manufacturer} {Description} ({Price:c})";
    }
}
