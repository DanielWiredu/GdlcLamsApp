using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwLoan
{
    public int AutoId { get; set; }

    public string LoanNo { get; set; } = null!;

    public string? WorkerId { get; set; }

    public string? WorkerName { get; set; }

    public int LoanSchemeId { get; set; }

    public string? LoanScheme { get; set; }

    public DateTime LoanDate { get; set; }

    public double? LoanAmount { get; set; }

    public double? RepayAmount { get; set; }

    public double? MonthlyLimit { get; set; }

    public double? RepaidAmount { get; set; }

    public double? LoanBalance { get; set; }

    public bool? Repaid { get; set; }

    public bool? AutoDeduct { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? AccountNo { get; set; }

    public bool? Approved { get; set; }
}
