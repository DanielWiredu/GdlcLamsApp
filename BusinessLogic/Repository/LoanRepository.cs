using AppModels.DailyReq;
using AppModels.Loans;
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
    public class LoanRepository : ILoanRepository
    {
        private readonly ISqlDataAccess _db;
        public LoanRepository(ISqlDataAccess db)
        {
            _db = db;
        }
        public async Task<int> AddLoanScheme(TblLoanScheme model) => await _db.SaveData(query: "INSERT INTO [tblLoanSchemes]([LoanScheme], [AccountNo]) VALUES (@LoanScheme, @AccountNo)", new { model.LoanScheme, model.AccountNo });
        public async Task<IEnumerable<TblLoanScheme>> GetAllLoanSchemes() => await _db.LoadData<TblLoanScheme, dynamic>(query: "Select * from tblLoanSchemes", new { });
        public async Task<int> RemoveLoanScheme(int Id) => await _db.SaveData(query: "Delete from tblLoanSchemes where Id=@Id", new { Id = Id });
        public async Task<int> UpdateLoanScheme(TblLoanScheme model) => await _db.SaveData(query: "Update tblLoanSchemes set LoanScheme=@LoanScheme, AccountNo=@AccountNo where Id=@Id", new { model.Id, model.LoanScheme, model.AccountNo });
        public async Task<IEnumerable<VwLoan>> GetLoans(string _searchValue)
        {
            string query = @"SELECT TOP (200) AutoId, LoanNo, LoanDate, WorkerId, WorkerName, LoanScheme, LoanAmount, RepaidAmount, LoanBalance, MonthlyLimit, Approved FROM vwLoans 
                            WHERE (LoanNo LIKE '%' + @SearchValue + '%') OR (WorkerId LIKE '%' + @SearchValue + '%') OR (WorkerName LIKE '%' + @SearchValue + '%') ORDER BY AutoId DESC";     
            return await _db.LoadData<VwLoan, dynamic>(query: query, new { SearchValue = _searchValue });
        }
        public async Task<int> DeleteLoan(string LoanNo) => await _db.SaveData(query: "Delete from tblLoans where LoanNo=@LoanNo", new { LoanNo = LoanNo });
        public async Task<TblLoan?> GetLoan(string LoanNo) => (await _db.LoadData<TblLoan, dynamic>(query: "Select * from tblLoans where LoanNo=@LoanNo", new { LoanNo = LoanNo })).FirstOrDefault();
        public async Task<(int ReturnValue, string LoanNo)> AddLoan(AddLoanRequest loan)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@LoanNo", null, dbType: DbType.String, size: 20, direction: ParameterDirection.Output);
            parameters.Add("@WorkerId", loan.WorkerId);
            parameters.Add("@LoanSchemeId", loan.LoanSchemeId);
            parameters.Add("@LoanDate", loan.LoanDate);
            parameters.Add("@LoanAmount", loan.LoanAmount);
            parameters.Add("@RepayAmount", loan.RepayAmount);
            parameters.Add("@MonthlyLimit", loan.MonthlyLimit);
            parameters.Add("@AutoDeduct", loan.AutoDeduct);
            parameters.Add("@CreatedBy", loan.CreatedBy);
            parameters.Add("@return_value", null, dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

            await _db.ExecuteSP(storedProcedure: "spAddLoan", parameters);
            return (parameters.Get<int>("@return_value"), parameters.Get<string>("@LoanNo"));
        }
        public async Task<int> UpdateLoan(UpdateLoanRequest loan)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@LoanNo", loan.LoanNo);
            parameters.Add("@WorkerId", loan.WorkerId);
            parameters.Add("@LoanSchemeId", loan.LoanSchemeId);
            parameters.Add("@LoanDate", loan.LoanDate);
            parameters.Add("@LoanAmount", loan.LoanAmount);
            parameters.Add("@RepayAmount", loan.RepayAmount);
            parameters.Add("@MonthlyLimit", loan.MonthlyLimit);
            parameters.Add("@RepaidAmount", loan.RepaidAmount);
            parameters.Add("@AutoDeduct", loan.AutoDeduct);
            parameters.Add("@UpdatedBy", loan.UpdatedBy);
            parameters.Add("@return_value", null, dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

            await _db.ExecuteSP(storedProcedure: "spUpdateLoan", parameters);
            return parameters.Get<int>("@return_value");
        }
        public async Task<int> GetOutstandingLoans(string workerId) => (await _db.LoadData<int, dynamic>(
            query: @"select isnull(count(loanno),0) as loans from tblLoans where workerid=@WorkerId and loanbalance > 0", new { WorkerId = workerId })).FirstOrDefault();
        public async Task<int> ApproveLoan(ApproveLoanRequest loan)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@loanNo", loan.LoanNo);
            parameters.Add("@approvedDate", loan.ApprovedDate);
            parameters.Add("@approvedBy", loan.ApprovedBy);
            parameters.Add("@return_value", null, dbType: DbType.Int32, direction: ParameterDirection.ReturnValue);

            await _db.ExecuteSP(storedProcedure: "spApproveLoan", parameters);
            return parameters.Get<int>("@return_value");
        }
    }
}
