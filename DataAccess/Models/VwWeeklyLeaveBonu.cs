using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwWeeklyLeaveBonu
{
    public string ReqNo { get; set; } = null!;

    public string WorkerId { get; set; } = null!;

    public string? Sname { get; set; }

    public string? Oname { get; set; }

    public string? Pname { get; set; }

    public double Normal { get; set; }

    public double? BasicRate { get; set; }

    public DateTime Adate { get; set; }

    public int? TradegroupId { get; set; }

    public bool? Approved { get; set; }

    public double? AnnualBonus { get; set; }

    public double? AnnualLeave { get; set; }

    public double? BasicRateDle { get; set; }

    public string? BankNumber { get; set; }

    public string? BankBranch { get; set; }

    public string? Ezwichid { get; set; }

    public string? BankName { get; set; }

    public double? TaxOnBonus { get; set; }

    public string? BranchName { get; set; }

    public string? SortCode { get; set; }
}
