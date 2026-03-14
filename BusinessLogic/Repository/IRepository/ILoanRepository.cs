using AppModels.Loans;
using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Repository.IRepository
{
    public interface ILoanRepository
    {
        Task<int> AddLoanScheme(TblLoanScheme model);
        Task<IEnumerable<TblLoanScheme>> GetAllLoanSchemes();
        Task<int> RemoveLoanScheme(int Id);
        Task<int> UpdateLoanScheme(TblLoanScheme model);
        Task<IEnumerable<VwLoan>> GetLoans(string _searchValue);
        Task<int> DeleteLoan(string LoanNo);
        Task<TblLoan?> GetLoan(string LoanNo);
        Task<(int ReturnValue, string LoanNo)> AddLoan(AddLoanRequest loan);
        Task<int> UpdateLoan(UpdateLoanRequest loan);
        Task<int> GetOutstandingLoans(string workerId);
        Task<int> ApproveLoan(ApproveLoanRequest loan);
    }
}
