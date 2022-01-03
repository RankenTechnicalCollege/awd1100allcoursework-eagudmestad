using System.Configuration;

namespace OrderOptionsMaintenance.Models
{
    public static class MMABooksDB
    {
        public static string ConnectionString =>
            ConfigurationManager.ConnectionStrings["MMABooks"].ConnectionString;
    }
}