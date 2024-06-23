using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwSubStaffWreq
{
    public int AutoId { get; set; }

    public string ReqNo { get; set; } = null!;

    public DateTime TransDate { get; set; }

    public double Normal { get; set; }

    public double Overtime { get; set; }

    public string? Night { get; set; }

    public string? Weekends { get; set; }

    public string? Holiday { get; set; }

    public string? Remarks { get; set; }

    public int? VesselberthId { get; set; }

    public string? VesselName { get; set; }

    public string? Transport { get; set; }

    public bool OnBoardAllowance { get; set; }
}
