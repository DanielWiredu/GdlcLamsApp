using AppModels.DailyReq;
using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Repository.IRepository
{
    public interface IDailyReqRepository
    {
        Task<IEnumerable<VwDailyReq>> ViewDailyReq(string searchValue);
        Task<IEnumerable<VwSubStaffReq>> GetSubStaffReq(string ReqNo);
        Task<string> GetNewReqNo(string userKey);
        Task<int> ToogleWorkerTransport(ToogleWorkerTransport request);
        Task<int> AddSubStaff(AddSubStaffRequest request);
        Task<TblStaffReq> GetDailyReq(string ReqNo);
        Task<(int AutoNo, int ReturnValue)> AddDailyReq(RequisitionModel request);
        Task<int> UpdateDailyReq(RequisitionModel request);
        Task<int> DeleteDailyReq(DeleteReqRequest request);
        Task<int> RemoveSubStaffReq(int AutoId);
    }
}
