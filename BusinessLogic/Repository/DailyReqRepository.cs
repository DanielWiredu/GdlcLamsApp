using BusinessLogic.Repository.IRepository;
using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Repository
{
    public class DailyReqRepository : IDailyReqRepository
    {
        private readonly ISqlDataAccess _db;
        public DailyReqRepository(ISqlDataAccess db)
        {
            _db = db;
        }
        public async Task<IEnumerable<VwDailyReq>> ViewDailyReq(string searchValue)
        {
            string query = @"SELECT TOP (50) AutoNo, ReqNo, date_ as Date, Approved, DLEcodeCompanyName, VesselName, ReportingPoint, Submitted, GPHA_RequestID as GphaRequestId FROM vwDailyReq 
                                WHERE (ReqNo LIKE '%' + @searchValue + '%' OR GPHA_RequestID LIKE '%' + @searchValue + '%') ORDER BY AutoNo DESC";
            return await _db.LoadData<VwDailyReq, dynamic>(query, new { searchValue = searchValue });
        }
        public async Task<IEnumerable<VwSubStaffReq>> GetSubStaffReq(string ReqNo)
        {
            string query = @"SELECT * FROM vwSubStaffReq WHERE (ReqNo = @ReqNo)";
            return await _db.LoadData<VwSubStaffReq, dynamic>(query, new { ReqNo = ReqNo });
        }
    }
}
