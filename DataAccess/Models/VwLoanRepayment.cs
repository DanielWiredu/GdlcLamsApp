using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwLoanRepayment
{
    public string LoanNo { get; set; } = null!;

    public string? LoanScheme { get; set; }

    public string? WorkerId { get; set; }

    public string? WorkerName { get; set; }

    public DateTime LoanDate { get; set; }

    public double? LoanAmount { get; set; }

    public double? RepayAmount { get; set; }

    public double? RepaidAmount { get; set; }

    public double? LoanBalance { get; set; }

    public DateTime? RepayDate { get; set; }

    public double? LoanRepayAmt { get; set; }

    public string? ReqNo { get; set; }

    public bool? Approved { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public double? MonthlyLimit { get; set; }
}
