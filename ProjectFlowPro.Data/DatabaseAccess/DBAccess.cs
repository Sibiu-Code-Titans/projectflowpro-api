﻿using Dapper;
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
    }
}