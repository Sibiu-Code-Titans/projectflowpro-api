using Dapper;
using Npgsql;
using ProjectFlowPro.Data.Hardcodings.Common;

namespace ProjectFlowPro.Data.DatabaseAccess
{
    public static class DBAccess
    {
        public static async Task<List<T>> GetAll<T>(string queryString, object? param = null)
        {
            using (var connection = new NpgsqlConnection(Environment.GetEnvironmentVariable(EnvironmentVariables.CONNECTION_STRING)))
            {
                connection.Open();
                var listOfEntities = await connection.QueryAsync<T>(queryString, param);
                connection.Close();
                return listOfEntities.ToList();
            }
        }

        public static async Task<int> Insert(string queryString, object? param = null)
        {
            using (var connection = new NpgsqlConnection(Environment.GetEnvironmentVariable(EnvironmentVariables.CONNECTION_STRING)))
            {
                connection.Open();
                var result = await connection.QuerySingleAsync<int>(queryString, param);
                connection.Close();
                return result;
            }
        }

        public static async Task<T> Get<T>(string queryString, object? param = null)
        {
            using (var connection = new NpgsqlConnection(Environment.GetEnvironmentVariable(EnvironmentVariables.CONNECTION_STRING)))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<T>(queryString, param);
                connection.Close();
                return result;
            }
        }

        public static async Task<int> Delete(string queryString, object? param = null)
        {
            using (var connection = new NpgsqlConnection(Environment.GetEnvironmentVariable(EnvironmentVariables.CONNECTION_STRING)))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(queryString, param);
                connection.Close();
                return result;
            }
        }
    }
}
