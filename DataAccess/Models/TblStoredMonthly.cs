using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblStoredMonthly
{
    public int AutoNum { get; set; }

    public string ReqNo { get; set; } = null!;

    public int DlecodeCompanyId { get; set; }

    public string WorkerId { get; set; } = null!;

    public int? TradegroupId { get; set; }

    public int? TradetypeId { get; set; }

    public int? ReportpointId { get; set; }

    public int? LocationId { get; set; }

    public string? Job { get; set; }

    public DateTime Date { get; set; }

    public DateTime Adate { get; set; }

    public string? Preparedby { get; set; }

    public bool? Approved { get; set; }

    public string? Approvedby { get; set; }

    public bool? Processed { get; set; }

    public string? Processedby { get; set; }

    public int? Dwkday { get; set; }

    public int? Dwkend { get; set; }

    public int? Dtotal { get; set; }

    public double? Hrwkday { get; set; }

    public double? Hrwkend { get; set; }

    public int? Nwkday { get; set; }

    public int? Nwkend { get; set; }

    public string? Yyyymm { get; set; }

    public DateTime? PeriodStart { get; set; }

    public DateTime? PeriodEnd { get; set; }

    public string? Transport { get; set; }

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

    public double? TaxOnTransport { get; set; }

    public double? TaxOnProvidentFund { get; set; }

    public double? BasicRate { get; set; }

    public double? OtwkdayRate { get; set; }

    public double? OtwkendRate { get; set; }

    public double? BasicRateDle { get; set; }

    public double? OtwkdayRateDle { get; set; }

    public double? OtwkendRateDle { get; set; }

    public int? PresentAge { get; set; }

    public DateTime? ProcessedDate { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? DlecompanyStatus { get; set; }

    public double? TransportAmount { get; set; }

    public int? BankId { get; set; }

    public int? BankBranchId { get; set; }

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

    public double? Loans { get; set; }

    public string? PaymentOption { get; set; }

    public virtual TblStaffMreq ReqNoNavigation { get; set; } = null!;
}
