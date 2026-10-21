using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Cafe.Mortgage.Api.ServiceInterface.Data
{
    public class SqlHelper
    {
        private SqlConnection _connection = null;

        public SqlHelper(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        // Execute a query that does not return results (e.g., INSERT, UPDATE, DELETE)
        public int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            using (var command = new SqlCommand(query, _connection))
            {
                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                _connection.Open();
                return command.ExecuteNonQuery();
            }
        }

        // Execute a query that returns a single value (e.g., COUNT, MAX)
        public object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            using (var command = new SqlCommand(query, _connection))
            {
                if (parameters != null)
                    command.Parameters.AddRange(parameters);

                _connection.Open();
                return command.ExecuteScalar();
            }
        }

        // Execute a query that returns a DataTable (e.g., SELECT)
        public DataTable ExecuteQuery(string query, params SqlParameter[] parameters)
        {
            using (var command = new SqlCommand(query, _connection))
            {
                using (var adapter = new SqlDataAdapter(command))
                {
                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
            }
        }
    }
}
