using System.Configuration;

namespace ProductMaintenance.Models.DataLayer
{
    public static class MMABooksDB
    {
        public static string ConnectionString =>
            ConfigurationManager.ConnectionStrings["MMABooks"].ConnectionString;
    }
}