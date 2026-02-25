using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Repository.IRepository
{
    public interface IWorkerRepository
    {
        Task<VwTblWorker> Find(string WorkerID);
        Task<IEnumerable<VwWorker>> GetAll(string _searchValue);
        Task<IEnumerable<VwWorker>> Search(string _searchType, string _searchValue);
        Task<IEnumerable<TblTradeGroup>> GetTradeGroups();
        Task<IEnumerable<TblTradeType>> GetTradeTypeByGroup(int tradeGroupId);
        Task<int> UpdateWorker(TblWorker worker);
        Task<(int AutoNo, int ReturnValue, string GPHAGroupId, string GPHAJobId)> AddWorker(TblWorker worker);
    }
}
