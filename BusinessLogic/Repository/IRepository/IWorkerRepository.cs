using AppModels.Workers;
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
        Task<IEnumerable<TblTradeGroupRate>> GetTradeGroupRates(int tradeGroupId);
        Task<IEnumerable<TblTradeType>> GetTradeTypeByGroup(int tradeGroupId);
        Task<IEnumerable<TblTradeType>> GetTradeTypes();
        Task<int> UpdateWorker(TblWorker worker);
        Task<(int AutoNo, int ReturnValue, string GPHAGroupId, string GPHAJobId)> AddWorker(TblWorker worker);
        Task<int> UpdateWorkerStatus(SetStatusRequest request);
    }
}
