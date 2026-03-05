
using System.Data;

namespace DataAccess.DbAccess
{
    public interface ISqlDataAccess
    {
        IDbConnection CreateConnection(string _connectionString = "Default");
        Task<IEnumerable<T>> LoadData<T, U>(string query, U parameters, string connectionId = "Default", CommandType cmdType = CommandType.Text);
        Task<int> SaveData<T>(string query, T parameters, string connectionId = "Default", CommandType cmdType = CommandType.Text);
        Task ExecuteSP<T>(string storedProcedure, T parameters, string connectionId = "Default");
    }
}