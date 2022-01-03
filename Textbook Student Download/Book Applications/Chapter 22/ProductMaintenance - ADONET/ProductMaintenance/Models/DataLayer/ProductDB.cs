using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace ProductMaintenance.Models.DataLayer
{
    public static class ProductDB
    {
        public static List<Product> GetProducts()
        {
            var products = new List<Product>(); // default return value
            string selectStatement =
                "SELECT ProductCode, Description, UnitPrice " +
                "FROM Products " +
                "ORDER BY Description";
            using SqlConnection connection = new SqlConnection(MMABooksDB.ConnectionString);
            using SqlCommand command = new SqlCommand(selectStatement, connection);
            connection.Open();

            using SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                var product = new Product { 
                    ProductCode = reader["ProductCode"].ToString(),
                    Description = reader["Description"].ToString(),
                    UnitPrice = (decimal)reader["UnitPrice"]
                };
                products.Add(product);
            }
            return products;
        }

        public static Product GetProduct(string productCode)
        {
            Product product = null; // default return value
            string selectStatement =
                "SELECT ProductCode, Description, UnitPrice " +
                "FROM Products " +
                "WHERE ProductCode = @ProductCode";
            using SqlConnection connection = new SqlConnection(MMABooksDB.ConnectionString);
            using SqlCommand command = new SqlCommand(selectStatement, connection);
            command.Parameters.AddWithValue("@ProductCode", productCode);
            connection.Open();

            using SqlDataReader reader = command.ExecuteReader(
                CommandBehavior.SingleRow & CommandBehavior.CloseConnection);
            if (reader.Read())
            {
                product = new Product
                {
                    ProductCode = reader["ProductCode"].ToString(),
                    Description = reader["Description"].ToString(),
                    UnitPrice = (decimal)reader["UnitPrice"]
                };
            }    
            return product;
        }

        public static void AddProduct(Product product)
        {
            string insertStatement =
                "INSERT Products (ProductCode, Description, UnitPrice) " +
                "VALUES (@ProductCode, @Description, @UnitPrice)";
            using SqlConnection connection = new SqlConnection(MMABooksDB.ConnectionString);
            using SqlCommand command = new SqlCommand(insertStatement, connection);
            command.Parameters.AddWithValue("@ProductCode", product.ProductCode);
            command.Parameters.AddWithValue("@Description", product.Description);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            connection.Open();
            command.ExecuteNonQuery();
        }

        public static bool UpdateProduct(Product oldProduct,
        Product newProduct)
        {
            string updateStatement =
              "UPDATE Products SET " +
                "Description = @NewDescription, " +
                "UnitPrice = @NewUnitPrice " +
              "WHERE ProductCode = @OldProductCode " +
                "AND Description = @OldDescription " +
                "AND UnitPrice = @OldUnitPrice";
            using SqlConnection connection = new SqlConnection(MMABooksDB.ConnectionString);
            using SqlCommand command = new SqlCommand(updateStatement, connection);
            command.Parameters.AddWithValue("@NewDescription", newProduct.Description);
            command.Parameters.AddWithValue("@NewUnitPrice", newProduct.UnitPrice);
            command.Parameters.AddWithValue("@OldProductCode", oldProduct.ProductCode);
            command.Parameters.AddWithValue("@OldDescription", oldProduct.Description);
            command.Parameters.AddWithValue("@OldUnitPrice", oldProduct.UnitPrice);
            connection.Open();
            int count = command.ExecuteNonQuery();

            return (count > 0);
        }

        public static bool DeleteProduct(Product product)
        {
            string deleteStatement =
              "DELETE FROM Products " +
              "WHERE ProductCode = @ProductCode " +
                "AND Description = @Description " +
                "AND UnitPrice = @UnitPrice";
            using SqlConnection connection = new SqlConnection(MMABooksDB.ConnectionString);
            using SqlCommand command = new SqlCommand(deleteStatement, connection);
            command.Parameters.AddWithValue("@ProductCode", product.ProductCode);
            command.Parameters.AddWithValue("@Description", product.Description);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            connection.Open();
            int count = command.ExecuteNonQuery();

            return (count > 0);
        }

        
        public static void SimulateConcurrentUpdate(string productCode)
        {
            string updateStatement =
                "UPDATE Products " +
                "SET UnitPrice = 0 " +
                "WHERE ProductCode = @ProductCode";
            using SqlConnection connection = new SqlConnection(MMABooksDB.ConnectionString);
            using SqlCommand command = new SqlCommand(updateStatement, connection);
            command.Parameters.AddWithValue("@ProductCode", productCode);
            connection.Open();
            command.ExecuteNonQuery();
        }

        public static void SimulateConcurrentDelete(string productCode)
        {
            string deleteStatement =
                "DELETE Products " +
                "WHERE ProductCode = @ProductCode";
            using SqlConnection connection = new SqlConnection(MMABooksDB.ConnectionString);
            using SqlCommand command = new SqlCommand(deleteStatement, connection);
            command.Parameters.AddWithValue("@ProductCode", productCode);
            connection.Open();
            command.ExecuteNonQuery();
        }
        
    }
}