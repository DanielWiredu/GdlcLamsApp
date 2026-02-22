using AppModels.DailyReq;
using BusinessLogic.Repository.IRepository;
using Dapper;
using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data;
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
        public async Task<string> GetNewReqNo(string userKey)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@userKey", userKey);
            parameters.Add("@DailyReqNo", null, dbType: DbType.String, size: 10, direction: ParameterDirection.Output);
            parameters.Add("@return_value", null, dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

            await _db.ExecuteSP(storedProcedure: "spGetNewDailyReqNo", parameters);
            return parameters.Get<string>("@DailyReqNo");
        }
        public async Task<int> ToogleWorkerTransport(ToogleWorkerTransport request)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@AutoId", request.AutoId);
            parameters.Add("@transport", request.transport);
            parameters.Add("@return_value", null, dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

            await _db.ExecuteSP(storedProcedure: "spToogleWorkerTransport", parameters);
            return parameters.Get<int>("@return_value");
        }
        public async Task<int> AddSubStaff(AddSubStaffRequest request)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ReqNo", request.ReqNo);
            parameters.Add("@WorkerId", request.WorkerId);
            parameters.Add("@TradegroupID", request.TradegroupID);
            parameters.Add("@transport", request.transport);
            parameters.Add("@TradetypeID", request.TradetypeID);
            parameters.Add("@return_value", null, dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

            await _db.ExecuteSP(storedProcedure: "spAddSubStaffReq", parameters);
            return parameters.Get<int>("@return_value");
        }
        public async Task<TblStaffReq> GetDailyReq(string ReqNo)
        {
            var results = await _db.LoadData<TblStaffReq, dynamic>(query: @"select AutoNo,ReqNo,DLEcodeCompanyID,VesselberthID,
                locationID,ReportpointID,cargoID,gangID,job,GPHA_RequestID as GphaRequestId,date_ as [Date],Normal,Overtime,Weekends,ShiftType,
                    Night,Approved,Adate,OnBoardAllowance
                        from tblStaffReq where ReqNo=@ReqNo or GPHA_RequestID=@ReqNo", new { ReqNo = ReqNo });
            return results.FirstOrDefault();
        }
        public async Task<(int AutoNo, int ReturnValue)> AddDailyReq(RequisitionModel request)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ReqNo", request.RequestNo);
            parameters.Add("@DLEcodeCompanyID", request.CompanyId);
            parameters.Add("@VesselberthID", request.VesselId);
            parameters.Add("@locationID", request.LocationId);
            parameters.Add("@ReportpointID", request.ReportingPointId);
            parameters.Add("@cargoID", request.CargoId);
            parameters.Add("@gangID", request.GangId);
            parameters.Add("@job", request.JobDescription);
            parameters.Add("@GPHA_RequestID", request.GphaRequestId);
            parameters.Add("@date_", request.RequisitionDate);
            parameters.Add("@Normal", request.NormalHours);
            parameters.Add("@Overtime", request.OvertimeHours);
            parameters.Add("@Weekends", request.Weekend);
            parameters.Add("@ShiftType", request.ShiftType);
            parameters.Add("@Night", request.Night);
            parameters.Add("@Adate", request.ApprovedDate);
            parameters.Add("@Preparedby", "UserID");
            parameters.Add("@OnBoardAllowance", request.ShipSide);
            parameters.Add("@NormalHrsFrom", new TimeSpan());
            parameters.Add("@NormalHrsTo", new TimeSpan());
            parameters.Add("@OvertimeHrsFrom", new TimeSpan());
            parameters.Add("@OvertimeHrsTo", new TimeSpan());
            parameters.Add("@AutoNo", dbType: DbType.Int32, direction: ParameterDirection.Output);
            parameters.Add("@return_value", null, dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

            await _db.ExecuteSP(storedProcedure: "spAddDailyReq", parameters);
            var autoNo = parameters.Get<int>("@AutoNo");
            var returnValue = parameters.Get<int>("@return_value");
            return (autoNo, returnValue);
        }
        public async Task<int> UpdateDailyReq(RequisitionModel request)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@DLEcodeCompanyID", request.CompanyId);
            parameters.Add("@VesselberthID", request.VesselId);
            parameters.Add("@locationID", request.LocationId);
            parameters.Add("@ReportpointID", request.ReportingPointId);
            parameters.Add("@cargoID", request.CargoId);
            parameters.Add("@gangID", request.GangId);
            parameters.Add("@job", request.JobDescription);
            parameters.Add("@GPHA_RequestID", request.GphaRequestId);
            parameters.Add("@date_", request.RequisitionDate);
            parameters.Add("@Normal", request.NormalHours);
            parameters.Add("@Overtime", request.OvertimeHours);
            parameters.Add("@Weekends", request.Weekend);
            parameters.Add("@ShiftType", request.ShiftType);
            parameters.Add("@Night", request.Night);
            parameters.Add("@Adate", request.ApprovedDate);
            parameters.Add("@Preparedby", "UserID");
            parameters.Add("@OnBoardAllowance", request.ShipSide);
            parameters.Add("@ReqNo", request.RequestNo);
            parameters.Add("@return_value", null, dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

            await _db.ExecuteSP(storedProcedure: "spUpdateDailyReq", parameters);
            return parameters.Get<int>("@return_value");
        }
        public async Task<int> DeleteDailyReq(DeleteReqRequest request)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@ReqNo", request.ReqNo);
            parameters.Add("@DeleteBy", request.DeleteBy);
            parameters.Add("@return_value", null, dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

            await _db.ExecuteSP(storedProcedure: "spDeleteDailyReq", parameters);
            return parameters.Get<int>("@return_value");
        }
        public async Task<int> RemoveSubStaffReq(int AutoId) => await _db.SaveData(query: "DELETE FROM tblSubStaffReq WHERE AutoId=@AutoId", new { AutoId = AutoId });
    }
}
