namespace ProductMaintenance.Models.DataLayer
{
    public class Product
    {
        public string ProductCode { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public int OnHandQuantity { get; set; }
    }
}
