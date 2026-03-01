using AppModels.Workers;
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
    public class WorkerRepository : IWorkerRepository
    {
        private readonly ISqlDataAccess _db;
        public WorkerRepository(ISqlDataAccess db)
        {
            _db = db;
        }
        public async Task<int> Add(TblWorker model) => await _db.SaveData(query: "Insert into tblLocation(Location) values(@Location)", new { model.Sname });


        public async Task<VwTblWorker> Find(string WorkerID)
        {
            var results = await _db.LoadData<VwTblWorker, dynamic>(query: "select *,Date_Birth as DateBirth from vwTblWorkers where WorkerID=@WorkerID", new { WorkerID = WorkerID });
            return results.FirstOrDefault();
        }

        public async Task<IEnumerable<VwWorker>> GetAll(string _searchValue) => await _db.LoadData<VwWorker, dynamic>(
            query: @"SELECT TOP(200) [WorkerID], [NationalID], [SName], [OName], [Date_Birth] AS DateBirth, [GangName], [SSFNo], [TradegroupNAME], [TradetypeNAME], [NHIS], [ezwichid], [RegDate], [PhoneNo], [Kin], BankNumber, [WorkerStatus] FROM [vwWorkers] 
                     WHERE WorkerID LIKE '%' + @SearchValue + '%' OR NationalID LIKE '%' + @SearchValue + '%' OR SName LIKE '%' + @SearchValue + '%' OR OName LIKE '%' + @SearchValue + '%' OR ezwichid LIKE '%' + @SearchValue + '%'", new { SearchValue = _searchValue });

        public async Task<IEnumerable<VwWorker>> Search(string _searchType, string _searchValue)
        {
            int searchLimit = 100;
            string query = $"SELECT top({searchLimit}) [WorkerID], [SName], [OName], [GangName], [SSFNo], [TradegroupID], [TradegroupNAME], [TradetypeNAME], [NHIS], [flags], [TradetypeID], NationalID, WorkerStatus FROM [vwWorkers] WHERE WorkerID LIKE '% ' @SearchValue + '%'";
            if (_searchType == "WorkerID")
                query = $"SELECT top({searchLimit})  [WorkerID], [SName], [OName], [GangName], [SSFNo], [TradegroupID], [TradegroupNAME], [TradetypeNAME], [NHIS], [flags], [TradetypeID], NationalID, WorkerStatus FROM [vwWorkers] WHERE WorkerID LIKE '%' + @SearchValue + '%'";
            else if (_searchType == "SSFNo")
                query = $"SELECT top({searchLimit})  [WorkerID], [SName], [OName], [GangName], [SSFNo], [TradegroupID], [TradegroupNAME], [TradetypeNAME], [NHIS], [flags], [TradetypeID], NationalID, WorkerStatus FROM [vwWorkers] WHERE SSFNo LIKE '%' + @SearchValue + '%'";
            else if (_searchType == "NHISNo")
                query = $"SELECT top({searchLimit})  [WorkerID], [SName], [OName], [GangName], [SSFNo], [TradegroupID], [TradegroupNAME], [TradetypeNAME], [NHIS], [flags], [TradetypeID], NationalID, WorkerStatus FROM [vwWorkers] WHERE NHIS LIKE '%' + @SearchValue + '%'";
            else if (_searchType == "Gang")
                query = $"SELECT top({searchLimit})  [WorkerID], [SName], [OName], [GangName], [SSFNo], [TradegroupID], [TradegroupNAME], [TradetypeNAME], [NHIS], [flags], [TradetypeID], NationalID, WorkerStatus FROM [vwWorkers] WHERE GangName LIKE '%' + @SearchValue + '%'";
            else if (_searchType == "Surname")
                query = $"SELECT top({searchLimit})  [WorkerID], [SName], [OName], [GangName], [SSFNo], [TradegroupID], [TradegroupNAME], [TradetypeNAME], [NHIS], [flags], [TradetypeID], NationalID, WorkerStatus FROM [vwWorkers] WHERE SName LIKE '%' + @SearchValue + '%' ORDER BY [OName]";
            else if (_searchType == "Othernames")
                query = $"SELECT top({searchLimit})  [WorkerID], [SName], [OName], [GangName], [SSFNo], [TradegroupID], [TradegroupNAME], [TradetypeNAME], [NHIS], [flags], [TradetypeID], NationalID, WorkerStatus FROM [vwWorkers] WHERE OName LIKE '%' + @SearchValue + '%' ORDER BY [SName]";
            return await _db.LoadData<VwWorker, dynamic>(query: query, new { SearchValue = _searchValue });
        }
        public async Task<IEnumerable<TblTradeGroup>> GetTradeGroups()
        {
            string query = $"SELECT * FROM tblTradeGroup";
            return await _db.LoadData<TblTradeGroup, dynamic>(query: query, new { });
        }
        public async Task<IEnumerable<TblTradeGroupRate>> GetTradeGroupRates(int tradeGroupId)
        {
            string query = $"SELECT * FROM [tblTradeGroupRates] WHERE TradeGroupId=@TradeGroupID";
            return await _db.LoadData<TblTradeGroupRate, dynamic>(query: query, new { TradeGroupID = tradeGroupId });
        }
        public async Task<IEnumerable<TblTradeType>> GetTradeTypeByGroup(int tradeGroupId)
        {
            string query = $"SELECT TradetypeID,TradetypeNAME FROM [tblTradeType] WHERE TradegroupID=@TradeGroupID";
            return await _db.LoadData<TblTradeType, dynamic>(query: query, new { TradeGroupID = tradeGroupId });
        }
        public async Task<IEnumerable<VwTradeType>> GetTradeTypes()
        {
            string query = $"SELECT * FROM [vwTradeType]";
            return await _db.LoadData<VwTradeType, dynamic>(query: query, new { });
        }
        public async Task<int> UpdateWorker(TblWorker worker)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@WorkerID", worker.WorkerId, DbType.String);
            parameters.Add("@WorkerType", worker.WorkerType, DbType.String);
            parameters.Add("@SName", worker.Sname, DbType.String);
            parameters.Add("@OName", worker.Oname, DbType.String);
            parameters.Add("@Pname", worker.Pname, DbType.String);
            parameters.Add("@Addr1", worker.Addr1, DbType.String);
            parameters.Add("@Addr2", worker.Addr2, DbType.String);
            parameters.Add("@PhoneNo", worker.PhoneNo, DbType.String);
            parameters.Add("@Date_Birth", worker.DateBirth, DbType.DateTime);
            parameters.Add("@nationalityID", worker.NationalityId, DbType.Int32);
            parameters.Add("@education", worker.Education, DbType.String);
            parameters.Add("@Kin", worker.Kin, DbType.String);
            parameters.Add("@Relation", worker.Relation, DbType.String);
            parameters.Add("@KinAddr", worker.KinAddr, DbType.String);
            parameters.Add("@KinAddrPhone", worker.KinAddrPhone, DbType.String);
            parameters.Add("@RegDate", worker.RegDate, DbType.DateTime);
            parameters.Add("@ContPer", worker.ContPer, DbType.String);
            parameters.Add("@Contaddr", worker.Contaddr, DbType.String);
            parameters.Add("@ContPhone", worker.ContPhone, DbType.String);
            parameters.Add("@SSFNo", worker.Ssfno, DbType.String);
            parameters.Add("@NHIS", worker.Nhis, DbType.String);
            parameters.Add("@NAT", worker.Nat, DbType.String);
            parameters.Add("@ShoeSize", worker.ShoeSize, DbType.String);
            parameters.Add("@Height", worker.Height, DbType.String);
            parameters.Add("@GangID", worker.GangId, DbType.Int32);
            parameters.Add("@BankID", worker.BankId, DbType.Int32);
            parameters.Add("@BankBranchId", worker.BankBranchId, DbType.Int32);
            parameters.Add("@BankNumber", worker.BankNumber, DbType.String);
            parameters.Add("@OfficialComm", worker.OfficialComm, DbType.String);
            parameters.Add("@Sex", worker.Sex, DbType.String);
            parameters.Add("@Tax", worker.Tax, DbType.Boolean);
            parameters.Add("@ChargePremium", worker.ChargePremium, DbType.Boolean);
            parameters.Add("@Pics", worker.Pics, DbType.Binary);
            parameters.Add("@WHO", worker.Who, DbType.String);
            parameters.Add("@WHOtime", DateTime.Now, DbType.DateTime);
            parameters.Add("@ezwichid", worker.Ezwichid, DbType.String);
            parameters.Add("@NationalID", worker.NationalId, DbType.String);
            parameters.Add("@TIN", worker.Tin, DbType.String);
            parameters.Add("@DepartmentId", worker.DepartmentId, DbType.Int32);
            parameters.Add("@PaymentOption", worker.PaymentOption, DbType.String);
            parameters.Add("@MedicalIDNo", worker.MedicalIdNo, DbType.String);
            parameters.Add("@AutoID", worker.AutoId, DbType.Int32);
            parameters.Add("@return_value", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

            await _db.ExecuteSP("spUpdateWorker", parameters);
            return parameters.Get<int>("@return_value");
        }
        public async Task<(int AutoNo, int ReturnValue, string GPHAGroupId, string GPHAJobId)> AddWorker(TblWorker worker)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@WorkerID", worker.WorkerId, DbType.String);
            parameters.Add("@WorkerType", worker.WorkerType, DbType.String);
            parameters.Add("@SName", worker.Sname, DbType.String);
            parameters.Add("@OName", worker.Oname, DbType.String);
            parameters.Add("@Pname", worker.Pname, DbType.String);
            parameters.Add("@Addr1", worker.Addr1, DbType.String);
            parameters.Add("@Addr2", worker.Addr2, DbType.String);
            parameters.Add("@PhoneNo", worker.PhoneNo, DbType.String);
            parameters.Add("@Date_Birth", worker.DateBirth, DbType.DateTime);
            parameters.Add("@nationalityID", worker.NationalityId, DbType.Int32);
            parameters.Add("@education", worker.Education, DbType.String);
            parameters.Add("@Kin", worker.Kin, DbType.String);
            parameters.Add("@Relation", worker.Relation, DbType.String);
            parameters.Add("@KinAddr", worker.KinAddr, DbType.String);
            parameters.Add("@KinAddrPhone", worker.KinAddrPhone, DbType.String);
            parameters.Add("@RegDate", worker.RegDate, DbType.DateTime);
            parameters.Add("@ContPer", worker.ContPer, DbType.String);
            parameters.Add("@Contaddr", worker.Contaddr, DbType.String);
            parameters.Add("@ContPhone", worker.ContPhone, DbType.String);
            parameters.Add("@SSFNo", worker.Ssfno, DbType.String);
            parameters.Add("@NHIS", worker.Nhis, DbType.String);
            parameters.Add("@NAT", worker.Nat, DbType.String);
            parameters.Add("@ShoeSize", worker.ShoeSize, DbType.String);
            parameters.Add("@Height", worker.Height, DbType.String);

            parameters.Add("@TradegroupID", worker.TradegroupId, DbType.Int32);
            parameters.Add("@TradetypeID", worker.TradetypeId, DbType.Int32);

            parameters.Add("@GangID", worker.GangId, DbType.Int32);
            parameters.Add("@BankID", worker.BankId, DbType.Int32);
            parameters.Add("@BankBranchId", worker.BankBranchId, DbType.Int32);
            parameters.Add("@BankNumber", worker.BankNumber, DbType.String);
            parameters.Add("@OfficialComm", worker.OfficialComm, DbType.String);
            parameters.Add("@flags", worker.Flags, DbType.String);
            parameters.Add("@Sex", worker.Sex, DbType.String);
            parameters.Add("@Tax", worker.Tax, DbType.Boolean);
            parameters.Add("@ChargePremium", worker.ChargePremium, DbType.Boolean);
            parameters.Add("@Pics", worker.Pics, DbType.Binary);
            parameters.Add("@WHO", worker.Who, DbType.String);
            parameters.Add("@WHOtime", DateTime.Now, DbType.DateTime);
            parameters.Add("@ezwichid", worker.Ezwichid, DbType.String);
            parameters.Add("@NationalID", worker.NationalId, DbType.String);
            parameters.Add("@TIN", worker.Tin, DbType.String);
            parameters.Add("@DepartmentId", worker.DepartmentId, DbType.Int32);
            parameters.Add("@PaymentOption", worker.PaymentOption, DbType.String);
            parameters.Add("@MedicalIDNo", worker.MedicalIdNo, DbType.String);

            parameters.Add("@GPHA_GroupId", dbType: DbType.String, direction: ParameterDirection.Output, size: 50);
            parameters.Add("@GPHA_JobId", dbType: DbType.String, direction: ParameterDirection.Output, size: 50);
            parameters.Add("@AutoID", dbType: DbType.Int32, direction: ParameterDirection.Output);
            parameters.Add("@return_value", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

            await _db.ExecuteSP("spAddWorker", parameters);
            var autoNo = parameters.Get<int>("@AutoID");
            var returnValue = parameters.Get<int>("@return_value");
            var gphaGroupId = parameters.Get<string>("@GPHA_GroupId");
            var gphaJobId = parameters.Get<string>("@GPHA_JobId");
            return (autoNo, returnValue, gphaGroupId, gphaJobId);
        }
        public async Task<int> UpdateWorkerStatus(SetStatusRequest request)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@WorkerID", request.WorkerID, DbType.String);
            parameters.Add("@flag", request.Flag, DbType.String);
            parameters.Add("@return_value", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);
            await _db.ExecuteSP("spSetWorkerStatus", parameters);
            return parameters.Get<int>("@return_value");
        }
        public async Task<int> AddTradeGroupRate(TblTradeGroupRate request)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@TradegroupID", request.TradegroupId, DbType.Int32);
            parameters.Add("@DBWage", request.Dbwage, DbType.Double);
            parameters.Add("@DBWageWkend", request.DbwageWkend, DbType.Double);
            parameters.Add("@DBWageHday", request.DBWageHday, DbType.Double);
            parameters.Add("@HourOtimeWkday", request.HourOtimeWkday, DbType.Double);
            parameters.Add("@HourOtimeWkend", request.HourOtimeWkend, DbType.Double);
            parameters.Add("@HourOtimeHday", request.HourOtimeHday, DbType.Double);
            parameters.Add("@NAWkday", request.Nawkday, DbType.Double);
            parameters.Add("@NAWkend", request.Nawkend, DbType.Double);
            parameters.Add("@NAHday", request.NAHday, DbType.Double);
            parameters.Add("@ShiftAllowance", request.ShiftAllowance, DbType.Double);
            parameters.Add("@Transport", request.Transport, DbType.Double);
            parameters.Add("@DBWageDLE", request.DbwageDle, DbType.Double);
            parameters.Add("@DBWageWkendDLE", request.DbwageWkendDle, DbType.Double);
            parameters.Add("@HourOtimeWkdayDLE", request.HourOtimeWkdayDle, DbType.Double);
            parameters.Add("@HourOtimeWkendDLE", request.HourOtimeWkendDle, DbType.Double);
            parameters.Add("@NAWkdayDLE", request.NawkdayDle, DbType.Double);
            parameters.Add("@NAWkendDLE", request.NawkendDle, DbType.Double);
            parameters.Add("@Subsidy", request.Subsidy, DbType.Double);
            parameters.Add("@PPEMedical", request.Ppemedical, DbType.Double);
            parameters.Add("@Bussing", request.Bussing, DbType.Double);
            parameters.Add("@EffectiveDate", request.EffectiveDate, DbType.DateTime);
            parameters.Add("@CreatedBy", request.CreatedBy, DbType.String);
            parameters.Add("@return_value", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);
            await _db.ExecuteSP("spAddTradeGroupRate", parameters);
            return parameters.Get<int>("@return_value");
        }
        public async Task<int> UpdateTradeGroupRate(TblTradeGroupRate request)
        {
            string query = @"UPDATE tblTradeGroupRates SET DBWage=@DBWage, DBWageWkend=@DBWageWkend, DBWageHday=@DBWageHday, HourOtimeWkday=@HourOtimeWkday, 
            HourOtimeWkend=@HourOtimeWkend, HourOtimeHday=@HourOtimeHday, NAWkday=@NAWkday, NAWkend=@NAWkend, NAHday=@NAHday, ShiftAllowance=@ShiftAllowance, 
            Transport=@Transport, DBWageDLE=@DBWageDLE, DBWageWkendDLE=@DBWageWkendDLE, HourOtimeWkdayDLE=@HourOtimeWkdayDLE, HourOtimeWkendDLE=@HourOtimeWkendDLE,
            NAWkdayDLE=@NAWkdayDLE, NAWkendDLE=@NAWkendDLE, Subsidy=@Subsidy, PPEMedical=@PPEMedical, Bussing=@Bussing, UpdateStatus=@UpdateStatus, 
            UpdatedBy=@UpdatedBy, UpdatedDate=@UpdatedDate WHERE ID=@ID";
            var parameters = new DynamicParameters();
            parameters.Add("@DBWage", request.Dbwage, DbType.Double);
            parameters.Add("@DBWageWkend", request.DbwageWkend, DbType.Double);
            parameters.Add("@DBWageHday", request.DBWageHday, DbType.Double);
            parameters.Add("@HourOtimeWkday", request.HourOtimeWkday, DbType.Double);
            parameters.Add("@HourOtimeWkend", request.HourOtimeWkend, DbType.Double);
            parameters.Add("@HourOtimeHday", request.HourOtimeHday, DbType.Double);
            parameters.Add("@NAWkday", request.Nawkday, DbType.Double);
            parameters.Add("@NAWkend", request.Nawkend, DbType.Double);
            parameters.Add("@NAHday", request.NAHday, DbType.Double);
            parameters.Add("@ShiftAllowance", request.ShiftAllowance, DbType.Double);
            parameters.Add("@Transport", request.Transport, DbType.Double);
            parameters.Add("@DBWageDLE", request.DbwageDle, DbType.Double);
            parameters.Add("@DBWageWkendDLE", request.DbwageWkendDle, DbType.Double);
            parameters.Add("@HourOtimeWkdayDLE", request.HourOtimeWkdayDle, DbType.Double);
            parameters.Add("@HourOtimeWkendDLE", request.HourOtimeWkendDle, DbType.Double);
            parameters.Add("@NAWkdayDLE", request.NawkdayDle, DbType.Double);
            parameters.Add("@NAWkendDLE", request.NawkendDle, DbType.Double);
            parameters.Add("@Subsidy", request.Subsidy, DbType.Double);
            parameters.Add("@PPEMedical", request.Ppemedical, DbType.Double);
            parameters.Add("@Bussing", request.Bussing, DbType.Double);
            parameters.Add("@UpdateStatus", 1, DbType.Int32);
            parameters.Add("@UpdatedBy", request.UpdatedBy, DbType.String);
            parameters.Add("@UpdatedDate", request.UpdatedDate, DbType.DateTime);
            parameters.Add("@ID", request.Id, DbType.Int32);
            parameters.Add("@return_value", dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);
            await _db.SaveData(query, parameters);
            return parameters.Get<int>("@return_value");
        }
    }
}
