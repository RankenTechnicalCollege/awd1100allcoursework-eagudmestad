using System.Data;
using Microsoft.Data.SqlClient;

namespace OrderOptionsMaintenance.Models
{
    public static class OrderOptionDB
    {
        public static OrderOption GetOrderOptions()
        {
            string selectStatement = "SELECT OptionID, SalesTaxRate, FirstBookShipCharge, AdditionalBookShipCharge " +
                                     "FROM OrderOptions";
            using SqlConnection connection = new SqlConnection(MMABooksDB.ConnectionString);
            using SqlCommand command = new SqlCommand(selectStatement, connection);
            connection.Open();

            OrderOption options = null;
            using SqlDataReader reader = command.ExecuteReader(
                CommandBehavior.SingleRow & CommandBehavior.CloseConnection);
            if (reader.Read())
            {
                options = new OrderOption
                {
                    OptionId = (int)reader["OptionID"],
                    SalesTaxRate = (decimal)reader["SalesTaxRate"],
                    FirstBookShipCharge = (decimal)reader["FirstBookShipCharge"],
                    AdditionalBookShipCharge = (decimal)reader["AdditionalBookShipCharge"]
                };
            }
            return options;
        }

        public static bool UpdateOrderOption(OrderOption oldOptions, OrderOption newOptions)
        {
            string updateStatement = "UPDATE OrderOptions SET " +
                "SalesTaxRate = @NewSalesTaxRate, " +
                "FirstBookShipCharge = @NewFirstBookShipCharge, " +
                "AdditionalBookShipCharge = @NewAdditionalBookShipCharge " +
                "WHERE OptionID = @OldOptionID " +
                "AND SalesTaxRate = @OldSalesTaxRate " +
                "AND FirstBookShipCharge = @OldFirstBookShipCharge " +
                "AND AdditionalBookShipCharge = @OldAdditionalBookShipCharge";
            using SqlConnection connection = new SqlConnection(MMABooksDB.ConnectionString);
            using SqlCommand command = new SqlCommand(updateStatement, connection);
            command.Parameters.AddWithValue("@NewSalesTaxRate", newOptions.SalesTaxRate);
            command.Parameters.AddWithValue("@NewFirstBookShipCharge", newOptions.FirstBookShipCharge);
            command.Parameters.AddWithValue("@NewAdditionalBookShipCharge", newOptions.AdditionalBookShipCharge);
            command.Parameters.AddWithValue("@OldOptionID", oldOptions.OptionId);
            command.Parameters.AddWithValue("@OldSalesTaxRate", oldOptions.SalesTaxRate);
            command.Parameters.AddWithValue("@OldFirstBookShipCharge", oldOptions.FirstBookShipCharge);
            command.Parameters.AddWithValue("@OldAdditionalBookShipCharge", oldOptions.AdditionalBookShipCharge);
            connection.Open();
            int count = command.ExecuteNonQuery();

            return (count > 0);
        }

        public static bool InsertError(OrderOption options)
        {
            string insertStatement = "INSERT INTO OrderOptions " +
                "(OptionID, SalesTaxRate, FirstBookShipCharge, AdditionalBookShipCharge)" +
                "VALUES(@OptionID, @SalesTaxRate, @FirstBookShipCharge, @AdditionalBookShipCharge)";
            using SqlConnection connection = new SqlConnection(MMABooksDB.ConnectionString);
            using SqlCommand command = new SqlCommand(insertStatement, connection);
            command.Parameters.AddWithValue("@OptionID", options.OptionId);
            command.Parameters.AddWithValue("@SalesTaxRate", options.SalesTaxRate);
            command.Parameters.AddWithValue("@FirstBookShipCharge", options.FirstBookShipCharge);
            command.Parameters.AddWithValue("@AdditionalBookShipCharge", options.AdditionalBookShipCharge);
            connection.Open();
            int count = command.ExecuteNonQuery();

            return (count > 0);
        }
    }
}