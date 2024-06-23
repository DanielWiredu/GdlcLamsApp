using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace DataAccess.DbAccess
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;
        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public async Task<IEnumerable<T>> LoadData<T, U>(string query, U parameters, string connectionId = "Default", CommandType cmdType = CommandType.Text)
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));
            return await connection.QueryAsync<T>(query, parameters, commandType: cmdType);
        }

        public async Task<int> SaveData<T>(string query, T parameters, string connectionId = "Default", CommandType cmdType = CommandType.Text)
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));
            return await connection.ExecuteAsync(query, parameters, commandType: cmdType);
        }
    }
}
