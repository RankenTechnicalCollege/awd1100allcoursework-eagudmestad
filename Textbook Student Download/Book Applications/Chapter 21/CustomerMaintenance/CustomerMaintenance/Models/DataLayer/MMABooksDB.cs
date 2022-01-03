using System.Configuration;

namespace CustomerMaintenance.Models.DataLayer
{
    public static class MMABooksDB
    {
        public static string ConnectionString =>
            ConfigurationManager.ConnectionStrings["MMABooks"].ConnectionString;
    }
}