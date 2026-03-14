using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModels.Loans
{
    public class ApproveLoanRequest
    {
        public string LoanNo { get; set; } = null!;
        public DateTime ApprovedDate { get; set; }
        public string? ApprovedBy { get; set; }
    }
}
