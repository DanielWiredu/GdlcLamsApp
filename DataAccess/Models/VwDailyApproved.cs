using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwDailyApproved
{
    public string ReqNo { get; set; } = null!;

    public string DlecodeCompanyName { get; set; } = null!;

    public string VesselName { get; set; } = null!;

    public string? Location { get; set; }

    public string? ReportingPoint { get; set; }

    public string? GangName { get; set; }

    public DateTime Date { get; set; }

    public string? Sname { get; set; }

    public string? Oname { get; set; }

    public string TradegroupName { get; set; } = null!;

    public string? CargoName { get; set; }

    public string? Pname { get; set; }

    public int? Age { get; set; }

    public double Normal { get; set; }

    public double Overtime { get; set; }

    public bool Weekends { get; set; }

    public bool Night { get; set; }

    public bool Approved { get; set; }

    public DateTime Adate { get; set; }

    public string? Preparedby { get; set; }

    public string? Approvedby { get; set; }

    public bool? OnBoardAllowance { get; set; }

    public string WorkerId { get; set; } = null!;

    public string Transport { get; set; } = null!;

    public double? Dbwage { get; set; }

    public double? DbwageWkend { get; set; }

    public double? HourOtimeWkday { get; set; }

    public double? HourOtimeWkend { get; set; }

    public double? Nawkday { get; set; }

    public double? Nawkend { get; set; }

    public double? TransportAmt { get; set; }

    public double? UnionDues { get; set; }

    public double? Welfare { get; set; }

    public double? Ssfemployee { get; set; }

    public double? ProvidentFundEmployee { get; set; }

    public double? ProvidentFundEmployer { get; set; }

    public double? TaxOnBasic { get; set; }

    public double? TaxOnOvertime { get; set; }

    public double? TaxOnProvidentFund { get; set; }

    public double? TaxOnTransport { get; set; }

    public double? OnBoardAllowanceAmt { get; set; }

    public double? Medicals { get; set; }
}
