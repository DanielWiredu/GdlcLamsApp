
using System.Data;

namespace DataAccess.DbAccess
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> LoadData<T, U>(string query, U parameters, string connectionId = "Default", CommandType cmdType = CommandType.Text);
        Task<int> SaveData<T>(string query, T parameters, string connectionId = "Default", CommandType cmdType = CommandType.Text);
    }
}