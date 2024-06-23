using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwMonthlyApprovedCostSheet
{
    public int AutoNum { get; set; }

    public string ReqNo { get; set; } = null!;

    public string WorkerId { get; set; } = null!;

    public string? Job { get; set; }

    public DateTime Date { get; set; }

    public DateTime Adate { get; set; }

    public int? Dwkday { get; set; }

    public int? Dwkend { get; set; }

    public int? Dtotal { get; set; }

    public double? Hrwkday { get; set; }

    public double? Hrwkend { get; set; }

    public int? Nwkday { get; set; }

    public int? Nwkend { get; set; }

    public double? UnionDues { get; set; }

    public double? Welfare { get; set; }

    public double? Ssfemployee { get; set; }

    public double? ProvidentFundEmployee { get; set; }

    public double? TaxOnBasic { get; set; }

    public double? TaxOnOvertime { get; set; }

    public double? TaxOnTransport { get; set; }

    public double? TaxOnProvidentFund { get; set; }

    public double? BasicRate { get; set; }

    public double? OtwkdayRate { get; set; }

    public double? OtwkendRate { get; set; }

    public int? PresentAge { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public double? TransportAmount { get; set; }

    public double? OnBoardAllowance { get; set; }

    public double? Loans { get; set; }

    public string DlecodeCompanyName { get; set; } = null!;

    public string TradegroupName { get; set; } = null!;

    public string? BankName { get; set; }

    public string? Sname { get; set; }

    public string? Oname { get; set; }

    public string? Pname { get; set; }

    public string? Ssfno { get; set; }

    public string? Location { get; set; }

    public string? ReportingPoint { get; set; }

    public string? LoanNo { get; set; }

    public string? LoanScheme { get; set; }

    public double? RepayAmount { get; set; }

    public string? Yyyymm { get; set; }

    public DateTime? PayPeriod { get; set; }

    public double? Vat { get; set; }

    public double? Ssfemployer { get; set; }

    public string? Transport { get; set; }

    public int DlecodeCompanyId { get; set; }

    public double? LoanBalance { get; set; }

    public double? Medicals { get; set; }

    public double? ProvidentFundEmployer { get; set; }
}
