using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CustomerMaintenance.Models.DataLayer
{
    public static class CustomerDB
    {
        public static Customer GetCustomer(int customerID)
        {
            Customer customer = null; // default return value
            string selectStatement =
                "SELECT CustomerID, Name, Address, City, State, ZipCode " +
                "FROM Customers " +
                "WHERE CustomerID = @CustomerID";
            using SqlConnection connection = new SqlConnection(MMABooksDB.ConnectionString);
            using SqlCommand command = new SqlCommand(selectStatement, connection);
            command.Parameters.AddWithValue("@CustomerID", customerID);
            connection.Open();

            using SqlDataReader reader = command.ExecuteReader(
                CommandBehavior.SingleRow & CommandBehavior.CloseConnection);
            if (reader.Read())
            {
                customer = new Customer
                {
                    CustomerId = (int)reader["CustomerID"],
                    Name = reader["Name"].ToString(),
                    Address = reader["Address"].ToString(),
                    City = reader["City"].ToString(),
                    StateCode = reader["State"].ToString(),
                    ZipCode = reader["ZipCode"].ToString()
                };
            }
                        
            return customer;
        }

        public static void AddCustomer(Customer customer)
        {
            string insertStatement =
                "INSERT Customers (Name, Address, City, State, ZipCode) " +
                "VALUES (@Name, @Address, @City, @State, @ZipCode)";
            using SqlConnection connection = new SqlConnection(MMABooksDB.ConnectionString);
            using SqlCommand command = new SqlCommand(insertStatement, connection);
            command.Parameters.AddWithValue("@Name", customer.Name);
            command.Parameters.AddWithValue("@Address", customer.Address);
            command.Parameters.AddWithValue("@City", customer.City);
            command.Parameters.AddWithValue("@State", customer.StateCode);
            command.Parameters.AddWithValue("@ZipCode", customer.ZipCode);
            connection.Open();
            int count = command.ExecuteNonQuery();

            if (count > 0)
            {
                // get newly created CustomerId from database
                command.CommandText = "SELECT IDENT_CURRENT('Customers') "
                                    + "FROM Customers";
                customer.CustomerId = Convert.ToInt32(command.ExecuteScalar());
            }
        }

        public static bool UpdateCustomer(Customer oldCustomer,
        Customer newCustomer)
        {
            string updateStatement =
              "UPDATE Customers SET " +
                "Name = @NewName, " +
                "Address = @NewAddress, " +
                "City = @NewCity, " +
                "State = @NewState, " +
                "ZipCode = @NewZipCode " +
              "WHERE CustomerID = @oldCustomerID " +
                "AND Name = @OldName " +
                "AND Address = @OldAddress " +
                "AND City = @OldCity " +
                "AND State = @OldState " +
                "AND ZipCode = @OldZipCode";
            using SqlConnection connection = new SqlConnection(MMABooksDB.ConnectionString);
            using SqlCommand command = new SqlCommand(updateStatement, connection);
            command.Parameters.AddWithValue("@NewName", newCustomer.Name);
            command.Parameters.AddWithValue("@NewAddress", newCustomer.Address);
            command.Parameters.AddWithValue("@NewCity", newCustomer.City);
            command.Parameters.AddWithValue("@NewState", newCustomer.StateCode);
            command.Parameters.AddWithValue("@NewZipCode", newCustomer.ZipCode);
            command.Parameters.AddWithValue("@OldCustomerID", oldCustomer.CustomerId);
            command.Parameters.AddWithValue("@OldName", oldCustomer.Name);
            command.Parameters.AddWithValue("@OldAddress", oldCustomer.Address);
            command.Parameters.AddWithValue("@OldCity", oldCustomer.City);
            command.Parameters.AddWithValue("@OldState", oldCustomer.StateCode);
            command.Parameters.AddWithValue("@OldZipCode", oldCustomer.ZipCode);
            connection.Open();
            int count = command.ExecuteNonQuery();

            return (count > 0);
        }

        public static bool DeleteCustomer(Customer customer)
        {
            string deleteStatement =
              "DELETE FROM Customers " +
              "WHERE CustomerID = @CustomerID " +
                "AND Name = @Name " +
                "AND Address = @Address " +
                "AND City = @City " +
                "AND State = @State " +
                "AND ZipCode = @ZipCode";
            using SqlConnection connection = new SqlConnection(MMABooksDB.ConnectionString);
            using SqlCommand command = new SqlCommand(deleteStatement, connection);
            command.Parameters.AddWithValue("@CustomerID", customer.CustomerId);
            command.Parameters.AddWithValue("@Name", customer.Name);
            command.Parameters.AddWithValue("@Address", customer.Address);
            command.Parameters.AddWithValue("@City", customer.City);
            command.Parameters.AddWithValue("@State", customer.StateCode);
            command.Parameters.AddWithValue("@ZipCode", customer.ZipCode);
            connection.Open();
            int count = command.ExecuteNonQuery();

            return (count > 0);
        }

        /*
        public static void SimulateConcurrentUpdate(int customerId)
        {
            string updateStatement =
                "UPDATE Customers " +
                "SET Address = '123 Main' " +
                "WHERE CustomerID = @CustomerID";
            using SqlConnection connection = new SqlConnection(MMABooksDB.ConnectionString);
            using SqlCommand command = new SqlCommand(updateStatement, connection);
            command.Parameters.AddWithValue("@CustomerID", customerId);
            connection.Open();
            command.ExecuteNonQuery();
        }

        public static void SimulateConcurrentDelete(int customerId)
        {
            string deleteStatement =
                "DELETE Customers " +
                "WHERE CustomerID = @CustomerID";
            using SqlConnection connection = new SqlConnection(MMABooksDB.ConnectionString);
            using SqlCommand command = new SqlCommand(deleteStatement, connection);
            command.Parameters.AddWithValue("@CustomerID", customerId);
            connection.Open();
            command.ExecuteNonQuery();
        }
        */
    }
}