using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwDailyApprovedCostSheet
{
    public int DlecodeCompanyId { get; set; }

    public string DlecodeCompanyName { get; set; } = null!;

    public string VesselName { get; set; } = null!;

    public string? Location { get; set; }

    public string? ReportingPoint { get; set; }

    public string? GangName { get; set; }

    public string WorkerId { get; set; } = null!;

    public string? Sname { get; set; }

    public string? Oname { get; set; }

    public string TradegroupName { get; set; } = null!;

    public string? CargoName { get; set; }

    public string? Pname { get; set; }

    public int AutoNum { get; set; }

    public string ReqNo { get; set; } = null!;

    public DateTime? Date { get; set; }

    public double? Normal { get; set; }

    public double? Overtime { get; set; }

    public string? Weekends { get; set; }

    public string? Night { get; set; }

    public DateTime? Adate { get; set; }

    public string? Preparedby { get; set; }

    public string? Approvedby { get; set; }

    public string Transport { get; set; } = null!;

    public double? UnionDues { get; set; }

    public double? Welfare { get; set; }

    public double? Medicals { get; set; }

    public double? Ssfemployee { get; set; }

    public double? ProvidentFundEmployee { get; set; }

    public double? TaxOnBasic { get; set; }

    public double? TaxOnProvidentFund { get; set; }

    public double? TaxOnOvertime { get; set; }

    public double? BasicRate { get; set; }

    public double? OvertimeRate { get; set; }

    public double? NightRate { get; set; }

    public int? PresentAge { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public double? TaxOnTransport { get; set; }

    public double? TransportAmount { get; set; }

    public double? OnBoardAllowance { get; set; }

    public double? NetTotal { get; set; }

    public string? Ezwichid { get; set; }

    public string? DlecompanyStatus { get; set; }

    public double? ProvidentFundEmployer { get; set; }

    public double? Ssfemployer { get; set; }

    public double? Ppemedical { get; set; }

    public double? Bussing { get; set; }

    public double? UnionLoan { get; set; }

    public string? WorkerType { get; set; }

    public string? BankNumber { get; set; }

    public string? PaymentOption { get; set; }

    public string? BranchName { get; set; }

    public string? SortCode { get; set; }
}
