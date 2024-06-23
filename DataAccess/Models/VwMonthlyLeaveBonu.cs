using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwMonthlyLeaveBonu
{
    public string ReqNo { get; set; } = null!;

    public string WorkerId { get; set; } = null!;

    public DateTime Date { get; set; }

    public DateTime Adate { get; set; }

    public int? Dtotal { get; set; }

    public double? BasicRate { get; set; }

    public string? Sname { get; set; }

    public string? Oname { get; set; }

    public string? Pname { get; set; }

    public DateOnly? PayPeriod { get; set; }

    public double? BasicRateDle { get; set; }

    public string? BankName { get; set; }

    public string? BankNumber { get; set; }

    public string? BranchName { get; set; }

    public double? AnnualBonus { get; set; }

    public double? AnnualLeave { get; set; }

    public double? TaxOnBonus { get; set; }

    public string? SortCode { get; set; }

    public string? PaymentOption { get; set; }

    public int DlecodeCompanyId { get; set; }
}
