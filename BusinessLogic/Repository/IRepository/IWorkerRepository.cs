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
        Task<IEnumerable<VwWorker>> GetAll(string _searchValue);
        Task<IEnumerable<VwWorker>> Search(string _searchType, string _searchValue);
        Task<IEnumerable<TblTradeGroup>> GetTradeGroups();
        Task<IEnumerable<TblTradeType>> GetTradeTypeByGroup(int tradeGroupId);
    }
}
