using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModels.Loans
{
    public class UpdateLoanRequest
    {
        public string LoanNo { get; set; } = null!;
        public string WorkerId { get; set; }
        public int LoanSchemeId { get; set; }
        public DateTime LoanDate { get; set; }
        public double LoanAmount { get; set; }
        public double RepayAmount { get; set; }
        public double MonthlyLimit { get; set; }
        public double RepaidAmount { get; set; }
        public bool AutoDeduct { get; set; }
        public string? UpdatedBy { get; set; }
    }
}
