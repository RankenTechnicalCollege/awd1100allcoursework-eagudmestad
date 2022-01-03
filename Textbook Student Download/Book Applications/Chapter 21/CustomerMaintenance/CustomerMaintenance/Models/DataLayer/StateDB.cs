using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CustomerMaintenance.Models.DataLayer
{
    public static class StateDB
    {
        public static List<State> GetStates()
        {
            List<State> states = new List<State>();
            string selectStatement = "SELECT StateCode, StateName "
                                   + "FROM States "
                                   + "ORDER BY StateName";
            using SqlConnection connection = new SqlConnection(MMABooksDB.ConnectionString);
            using SqlCommand command = new SqlCommand(selectStatement, connection);
            connection.Open();

            using SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                State s = new State() { 
                    StateCode = reader["StateCode"].ToString(),
                    StateName = reader["StateName"].ToString()
                };
                states.Add(s);
            }

            return states;
        }

        public static State GetState(string stateCode)
        {
            State state = null; // default return value
            string selectStatement = "SELECT StateCode, StateName "
                                   + "FROM States "
                                   + "WHERE StateCode = @StateCode";
            using SqlConnection connection = new SqlConnection(MMABooksDB.ConnectionString);
            using SqlCommand command = new SqlCommand(selectStatement, connection);
            command.Parameters.AddWithValue("@StateCode", stateCode);
            connection.Open();

            using SqlDataReader reader = command.ExecuteReader(
                CommandBehavior.SingleRow & CommandBehavior.CloseConnection);
            if (reader.Read())
            {
                state = new State()
                {
                    StateCode = reader["StateCode"].ToString(),
                    StateName = reader["StateName"].ToString()
                };
            }

            return state;
        }
    }
}