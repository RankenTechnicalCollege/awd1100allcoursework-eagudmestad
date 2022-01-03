using System;
using System.Windows.Forms;
using System.Linq;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace CustomerMaintenance.Models.DataLayer
{
    public static class Error
    {
        public static EntityState HandleConcurrency(DbUpdateConcurrencyException ex,
            MMABooksContext context, Customers customer)
        {
            ex.Entries.Single().Reload();

            var state = context.Entry(customer).State;
            if (state == EntityState.Detached)
            {
                MessageBox.Show("Another user has deleted that customer.",
                    "Concurrency Error");
            }
            else
            {
                string message = "Another user has updated that customer.\n" +
                    "The current database values will be displayed.";
                MessageBox.Show(message, "Concurrency Error");
            }
            return state;
        }

        public static void HandleData(DbUpdateException ex)
        {
            string errorMessage = "";
            var sqlException = (SqlException)ex.InnerException;
            for (int i = 0; i < sqlException.Errors.Count; i++)
            {
                var errorNum = sqlException.Errors[i].Number;
                errorMessage += "ERROR CODE:  " + errorNum + " " +
                                sqlException.Errors[i].Message + "\n";
            }
            MessageBox.Show(errorMessage);
        }

        public static void HandleGeneral(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString());
        }
    }

    public static class Concurrency
    {
        public static void SimulateUpdate(MMABooksContext context, int customerId)
        {
            context.Database.ExecuteSqlRaw(
                "UPDATE Customers " +
                "SET address = '2 Main St' " +
                "WHERE CustomerId = " + customerId);
        }

        public static void SimulateDelete(MMABooksContext context, int customerId)
        {
            context.Database.ExecuteSqlRaw(
                "DELETE Customers " +
                "WHERE CustomerId = " + customerId);
        }
    }
}
