using System.Configuration;

namespace ProductMaintenance.Models.DataLayer
{
    public static class MMABooksDB
    {
        public static readonly string ConnectionString =
            ConfigurationManager.ConnectionStrings["MMABooks"].ConnectionString;
    }
}