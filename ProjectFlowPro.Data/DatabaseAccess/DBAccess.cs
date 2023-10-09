using Dapper;
using Npgsql;
using ProjectFlowPro.Data.Hardcodings.Common;
using ProjectFlowPro.Data.Models.TaskModels;

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

        public static async Task<TaskModel?> GetTaskById(string queryString, object? param = null)
        {
            using (var connection = new NpgsqlConnection(Environment.GetEnvironmentVariable(EnvironmentVariables.CONNECTION_STRING)))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<TaskModel?>(queryString, param);
                connection.Close();
                return result;
            }
        }
    }
}
