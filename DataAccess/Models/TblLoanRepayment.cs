using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblLoanRepayment
{
    public int AutoId { get; set; }

    public string LoanNo { get; set; } = null!;

    public string WorkerId { get; set; } = null!;

    public DateTime? RepayDate { get; set; }

    public double? RepayAmount { get; set; }

    public string? ReqNo { get; set; }

    public bool? Approved { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? ManualReceiptNo { get; set; }
}
