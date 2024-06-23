using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblLoan
{
    public int AutoId { get; set; }

    public string LoanNo { get; set; } = null!;

    public string? WorkerId { get; set; }

    public int LoanSchemeId { get; set; }

    public DateTime LoanDate { get; set; }

    public double? LoanAmount { get; set; }

    public double? RepayAmount { get; set; }

    public double? MonthlyLimit { get; set; }

    public double? RepaidAmount { get; set; }

    public double? LoanBalance { get; set; }

    public bool? Repaid { get; set; }

    public bool? AutoDeduct { get; set; }

    public bool? Approved { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public virtual TblLoanScheme LoanScheme { get; set; } = null!;
}
