using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblTradeGroupRate
{
    public int Id { get; set; }

    public int TradegroupId { get; set; }

    public double? Dbwage { get; set; }

    public double? DbwageWkend { get; set; }

    public double? HourOtimeWkday { get; set; }

    public double? HourOtimeWkend { get; set; }

    public double? Nawkday { get; set; }

    public double? Nawkend { get; set; }

    public double? Transport { get; set; }

    public double? DbwageDle { get; set; }

    public double? DbwageWkendDle { get; set; }

    public double? HourOtimeWkdayDle { get; set; }

    public double? HourOtimeWkendDle { get; set; }

    public double? NawkdayDle { get; set; }

    public double? NawkendDle { get; set; }

    public double? Subsidy { get; set; }

    public double? Ppemedical { get; set; }

    public double? Bussing { get; set; }

    public DateTime? EffectiveDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public bool? UpdateStatus { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
