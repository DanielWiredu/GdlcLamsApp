using AppModels;
using AppModels.DailyReq;
using BusinessLogic.Repository.IRepository;
using Dapper;
using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Buffers;
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
                    Night,Approved,Adate,OnBoardAllowance,Processed,Stored
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
            parameters.Add("@Preparedby", request.Preparedby);
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
            parameters.Add("@Preparedby", request.Preparedby);
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
        public async Task<int> ApproveDailyReq(ApproveReqRequest request)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Adate", request.Adate);
            parameters.Add("@ApprovedBy", request.ApprovedBy);
            parameters.Add("@ReqNo", request.ReqNo);
            parameters.Add("@return_value", null, dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

            await _db.ExecuteSP(storedProcedure: "spApproveDailyReq", parameters);
            return parameters.Get<int>("@return_value");
        }
        public async Task<int> DisapproveDailyReq(DisapproveReqRequest request)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Processed", request.Processed);
            parameters.Add("@ReqNo", request.ReqNo);
            parameters.Add("@DisApprovedBy", request.DisApprovedBy);
            parameters.Add("@return_value", null, dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

            await _db.ExecuteSP(storedProcedure: "spDisapproveDailyReq", parameters);
            return parameters.Get<int>("@return_value");
        }
        public async Task<int> UpdateDailyReqHours(UpdateReqHoursRequest request)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@Normal", request.Normal);
            parameters.Add("@Overtime", request.Overtime);
            parameters.Add("@Hourby", request.Hourby);
            parameters.Add("@HourDate", request.HourDate);
            parameters.Add("@NormalHrsFrom", new TimeSpan());
            parameters.Add("@NormalHrsTo", new TimeSpan());
            parameters.Add("@OvertimeHrsFrom", new TimeSpan());
            parameters.Add("@OvertimeHrsTo", new TimeSpan());
            parameters.Add("@ReqNo", request.ReqNo);
            parameters.Add("@return_value", null, dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

            await _db.ExecuteSP(storedProcedure: "spUpdateDailyReqHours", parameters);
            return parameters.Get<int>("@return_value");
        }
        public async Task<IEnumerable<TblGphaLabourRequest>> GetGPHAPendingRequests(DateTime StartDate, DateTime EndDate, string SearchValue)
        {
            string query = @"SELECT *
                            FROM tblGPHA_LabourRequests
                            WHERE hasCostSheet = 0
                            AND GPHA_Approved = 0
                            AND rNeededOn BETWEEN @StartDate AND @EndDate
                            AND (
                                LabourRequestID LIKE '%' + @SearchValue + '%'
                                OR JobRequested LIKE '%' + @SearchValue + '%'
                                OR UnitDescription LIKE '%' + @SearchValue + '%'
                            )
                            ORDER BY Id DESC";
            return await _db.LoadData<TblGphaLabourRequest, dynamic>(query: query, new { StartDate = StartDate, EndDate = EndDate, SearchValue = SearchValue });
        }
        public async Task<IEnumerable<VmApprovedGPHARequest>> GetGPHAApprovedRequests(DateTime StartDate, DateTime EndDate, string SearchValue)
        {
            string query = @"SELECT r.LabourRequestID, r.RequestDate, r.UnitDescription, r.JobRequested, r.NumberRequested, r.rNeededOn, r.rDay, r.rShift,
                            r.CostSheetNo, c.CreatedDate as PreparedOn, r.GPHA_ApprovedDate as GphaApprovedDate, r.GDLC_Approved as GdlcApproved, r.GDLC_ApprovedDate as GdlcApprovedDate
                            FROM tblGPHA_LabourRequests r left join tblStaffReq c on r.CostSheetNo = c.ReqNo 
                            WHERE r.hasCostSheet=1 AND r.GPHA_Approved=1 AND (r.GPHA_ApprovedDate BETWEEN @StartDate AND @EndDate) 
                            AND (
                                r.LabourRequestID LIKE '%' + @SearchValue + '%'
                                OR r.JobRequested LIKE '%' + @SearchValue + '%'
                                OR r.UnitDescription LIKE '%' + @SearchValue + '%'
                            ) 
                            ORDER BY r.Id DESC";
            return await _db.LoadData<VmApprovedGPHARequest, dynamic>(query: query, new { StartDate = StartDate, EndDate = EndDate, SearchValue = SearchValue });
        }
        public async Task<IEnumerable<VmApprovedGPHARequest>> GetGPHARequests(
        DateTime StartDate,
        DateTime EndDate,
        string SearchValue,
        bool hasCostSheet,
        bool GPHA_Approved,
        bool GDLC_Approved)
        {
            string query = @"SELECT r.LabourRequestID, r.RequestDate, r.UnitDescription, r.JobRequested, r.NumberRequested, r.rNeededOn, r.rDay, r.rShift,
                    r.CostSheetNo, c.CreatedDate as PreparedOn, r.GPHA_ApprovedDate as GphaApprovedDate, r.GDLC_Approved as GdlcApproved, r.GDLC_ApprovedDate as GdlcApprovedDate
                    FROM tblGPHA_LabourRequests r 
                    LEFT JOIN tblStaffReq c ON r.CostSheetNo = c.ReqNo 
                    WHERE r.hasCostSheet = @hasCostSheet 
                    AND r.GPHA_Approved = @GPHA_Approved 
                    AND r.GDLC_Approved = @GDLC_Approved
                    AND (r.rNeededOn  BETWEEN @StartDate AND @EndDate) 
                    AND (
                        r.LabourRequestID LIKE '%' + @SearchValue + '%'
                        OR r.JobRequested LIKE '%' + @SearchValue + '%'
                        OR r.UnitDescription LIKE '%' + @SearchValue + '%'
                    ) 
                    ORDER BY r.Id DESC";

            return await _db.LoadData<VmApprovedGPHARequest, dynamic>(
                query: query,
                new { StartDate, EndDate, SearchValue, hasCostSheet, GPHA_Approved, GDLC_Approved }
            );
        }
        public async Task<int> AddDailyReqGPHARequest(RequisitionModel request)
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
            parameters.Add("@Weekends", request.Weekend);
            parameters.Add("@ShiftType", request.ShiftType);
            parameters.Add("@Night", request.Night);
            parameters.Add("@Preparedby", request.Preparedby);
            parameters.Add("@OnBoardAllowance", request.ShipSide);
            parameters.Add("@return_value", null, dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

            await _db.ExecuteSP(storedProcedure: "spAddDailyReq_GPHARequest", parameters);
            return parameters.Get<int>("@return_value");
        }
        public async Task<(int costSheets, int returnValue)> ProcessDailyReq(PayrollProcessRequest request)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@startdate", request.startdate);
            parameters.Add("@enddate", request.enddate);
            parameters.Add("@processedby", request.processedby);
            parameters.Add("@processedCostSheets", null, dbType: DbType.Int32, direction: ParameterDirection.Output);
            parameters.Add("@return_value", null, dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

            await _db.ExecuteSP(storedProcedure: "spProcessDailyReq", parameters);
            var costSheets = parameters.Get<int>("@processedCostSheets");
            var returnValue = parameters.Get<int>("@return_value");
            return (costSheets, returnValue);
        }
        public async Task<IEnumerable<GPHAJobAssignmentDto>> GetGPHAPendingApprovedRequests()
        {
            string query = @"SELECT TOP(100) * FROM GPHAJobAssignments WHERE Processed = 0";
            return await _db.LoadData<GPHAJobAssignmentDto, dynamic>(query: query, new { });
        }
        public async Task<TblGphaLabourRequest> GetGPHARequestByID(string LabourRequestID)
        {
            string query = @"SELECT * FROM tblGPHA_LabourRequests WHERE hasCostSheet = 1 AND GPHA_Approved = 0 AND LabourRequestID = @LabourRequestID";
            var result = await _db.LoadData<TblGphaLabourRequest, dynamic>(query: query, new { LabourRequestID });
            return result.FirstOrDefault();
        }
        public async Task<IEnumerable<GPHACostSheetDetailDto>> GetGPHACostSheetDetails(string costSheetId)
        {
            string query = @"SELECT * FROM GPHACostSheetDetails WHERE CostSheetId = @CostSheetId";
            return await _db.LoadData<GPHACostSheetDetailDto, dynamic>(query: query, new { CostSheetId = costSheetId });
        }
        public async Task<int> UpdateDailyReqGPHAHours(UpdateReqGPHAHoursRequest request)
        {
            return await _db.SaveData(query: "UPDATE tblStaffReq SET Normal=@Normal,Overtime=@Overtime,GPHA_RequestID=@GPHA_RequestID,ShiftType=@ShiftType WHERE ReqNo=@ReqNo", 
                new { request.Normal, request.Overtime, request.GPHA_RequestID, request.ShiftType, request.ReqNo });
        }
        public async Task<int> AddGPHASubStaff(AddSubStaffRequest request)
        {
            var sql = @"
                    IF NOT EXISTS 
                        (SELECT 1  FROM tblSubStaffReq  WHERE ReqNo = @ReqNo AND WorkerID = @WorkerID)
                    BEGIN
                        INSERT INTO tblSubStaffReq (ReqNo, WorkerID, TradegroupID, transport, Normal, Overtime) VALUES (@ReqNo, @WorkerID, @TradegroupID, @transport, @Normal, @Overtime)
                    END";
            return await _db.SaveData(query: sql, new { request.ReqNo, request.WorkerId, request.TradegroupID, request.transport, request.Normal, request.Overtime });
        }
        public async Task<int?> UpdateProcessedGPHARequests(List<string> requestNumbers)
        {
            using (var connection = _db.CreateConnection())
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        var sql1 = @"UPDATE tblGPHA_LabourRequests SET GPHA_Approved = 1, GPHA_ApprovedDate = GETUTCDATE() WHERE LabourRequestID IN @RequestNumbers";
                        var sql2 = @"UPDATE GPHAJobAssignments SET Processed = 1 WHERE RequestNumber IN @RequestNumbers";

                        var affectedRows1 = await connection.ExecuteAsync(sql1, new { RequestNumbers = requestNumbers }, transaction);
                        var affectedRows2 = await connection.ExecuteAsync(sql2, new { RequestNumbers = requestNumbers }, transaction);

                        transaction.Commit();
                        return affectedRows1 + affectedRows2;
                    }
                    catch
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public async Task<(int costSheets, int returnValue)> StoreDailyReq(PayrollProcessRequest request)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@startdate", request.startdate);
            parameters.Add("@enddate", request.enddate);
            parameters.Add("@storedby", request.processedby);
            parameters.Add("@storedCostSheets", null, dbType: DbType.Int32, direction: ParameterDirection.Output);
            parameters.Add("@return_value", null, dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

            await _db.ExecuteSP(storedProcedure: "spStoreDailyReq", parameters);
            var costSheets = parameters.Get<int>("@storedCostSheets");
            var returnValue = parameters.Get<int>("@return_value");
            return (costSheets, returnValue);
        }
    }
}
