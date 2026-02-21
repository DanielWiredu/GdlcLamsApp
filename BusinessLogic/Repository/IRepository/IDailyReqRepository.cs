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
    }
}
