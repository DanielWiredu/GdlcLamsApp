using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblDisapproveWeekly
{
    public int AutoNum { get; set; }

    public string ReqNo { get; set; } = null!;

    public int? DlecodeCompanyId { get; set; }

    public string WorkerId { get; set; } = null!;

    public int? TradegroupId { get; set; }

    public int? TradetypeId { get; set; }

    public int? ReportpointId { get; set; }

    public string? Job { get; set; }

    public DateTime Date { get; set; }

    public DateTime Adate { get; set; }

    public string? Preparedby { get; set; }

    public bool? Approved { get; set; }

    public string? Approvedby { get; set; }

    public bool? Processed { get; set; }

    public string? Processedby { get; set; }

    public DateTime TransDate { get; set; }

    public double Normal { get; set; }

    public double Overtime { get; set; }

    public string? Night { get; set; }

    public string? Weekends { get; set; }

    public string? Holiday { get; set; }

    public double? Subsidy { get; set; }

    public double? Ppemedical { get; set; }

    public double? Bussing { get; set; }

    public double? UnionDues { get; set; }

    public double? Welfare { get; set; }

    public double? Medicals { get; set; }

    public double? Ssfemployee { get; set; }

    public double? Ssfemployer { get; set; }

    public double? ProvidentFundEmployee { get; set; }

    public double? ProvidentFundEmployer { get; set; }

    public double? AnnualBonus { get; set; }

    public double? AnnualLeave { get; set; }

    public double? PremiumShareHolder { get; set; }

    public double? PremiumNonShareHolder { get; set; }

    public double? PremiumWithoutTt { get; set; }

    public double? TaxOnBonus { get; set; }

    public double? TaxOnBasic { get; set; }

    public double? TaxOnOvertime { get; set; }

    public double? TaxOnProvidentFund { get; set; }

    public double? BasicRate { get; set; }

    public double? OvertimeRate { get; set; }

    public double? NightRate { get; set; }

    public double? BasicRateDle { get; set; }

    public double? OvertimeRateDle { get; set; }

    public double? NightRateDle { get; set; }

    public int? PresentAge { get; set; }

    public DateTime? ProcessedDate { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public double? TaxOnTransport { get; set; }

    public string? DlecompanyStatus { get; set; }

    public string? Transport { get; set; }

    public double? TransportAmount { get; set; }

    public int? VesselberthId { get; set; }

    public int? BankId { get; set; }

    public string? BankBranch { get; set; }

    public string? BankNumber { get; set; }

    public bool? Paid { get; set; }

    public string? Paidby { get; set; }

    public DateTime? PaidDate { get; set; }

    public DateTime? DateStored { get; set; }

    public bool? Stored { get; set; }

    public string? Storedby { get; set; }

    public double? NetTotal { get; set; }

    public DateTime? StartDateStored { get; set; }

    public DateTime? EndDateStored { get; set; }

    public string? Ezwichid { get; set; }

    public double? Vat { get; set; }

    public double? GetFund { get; set; }

    public double? Nhil { get; set; }

    public double? OnBoardAllowance { get; set; }

    public double? UnionLoan { get; set; }

    public int? BankBranchId { get; set; }

    public virtual TblStaffWreq ReqNoNavigation { get; set; } = null!;
}
