using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwMonthlyLeaveBonusPaySlip
{
    public string WorkerId { get; set; } = null!;

    public string? WorkerName { get; set; }

    public int DlecodeCompanyId { get; set; }

    public string DlecodeCompanyName { get; set; } = null!;

    public DateTime Date { get; set; }

    public DateTime Adate { get; set; }

    public int? Dtotal { get; set; }

    public double? BasicRate { get; set; }

    public double? MonthlyBasic { get; set; }

    public int? Payyear { get; set; }

    public int? Paymonth { get; set; }

    public string? BankName { get; set; }

    public string? BankNumber { get; set; }

    public string? BranchName { get; set; }

    public double? AnnualBonus { get; set; }

    public double? AnnualLeave { get; set; }

    public double? TaxOnBonus { get; set; }

    public string? SortCode { get; set; }

    public string? PaymentOption { get; set; }

    public double? ProvidentFundEmployee { get; set; }

    public double? ProvidentFundEmployer { get; set; }
}
