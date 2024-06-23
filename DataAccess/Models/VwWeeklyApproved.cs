using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwWeeklyApproved
{
    public string ReqNo { get; set; } = null!;

    public string WorkerId { get; set; } = null!;

    public string? Job { get; set; }

    public DateTime Date { get; set; }

    public DateTime Adate { get; set; }

    public string? Preparedby { get; set; }

    public bool? Approved { get; set; }

    public string? Approvedby { get; set; }

    public DateTime TransDate { get; set; }

    public double Normal { get; set; }

    public double Overtime { get; set; }

    public string? Night { get; set; }

    public string? Weekends { get; set; }

    public string? Holiday { get; set; }

    public string? Transport { get; set; }

    public string? Sname { get; set; }

    public string? Oname { get; set; }

    public string? Pname { get; set; }

    public DateTime? DateBirth { get; set; }

    public string DlecodeCompanyName { get; set; } = null!;

    public string? ReportingPoint { get; set; }

    public string TradegroupName { get; set; } = null!;

    public double? Dbwage { get; set; }

    public double? DbwageWkend { get; set; }

    public double? HourOtimeWkday { get; set; }

    public double? HourOtimeWkend { get; set; }

    public double? Nawkday { get; set; }

    public double? Nawkend { get; set; }

    public double? TransportAmount { get; set; }

    public string? TradetypeName { get; set; }

    public string? VesselName { get; set; }

    public double? UnionDues { get; set; }

    public double? Welfare { get; set; }

    public double? Ssfemployee { get; set; }

    public double? ProvidentFundEmployee { get; set; }

    public double? ProvidentFundEmployer { get; set; }

    public double? TaxOnBasic { get; set; }

    public double? TaxOnOvertime { get; set; }

    public double? TaxOnProvidentFund { get; set; }

    public double? TaxOnTransport { get; set; }

    public bool OnBoardAllowance { get; set; }

    public double? OnBoardAllowanceAmt { get; set; }

    public double? Medicals { get; set; }
}
