using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwWeeklyActiveWorker
{
    public string WorkerId { get; set; } = null!;

    public DateTime Date { get; set; }

    public string? Sname { get; set; }

    public string? Oname { get; set; }

    public string? Pname { get; set; }

    public string? PhoneNo { get; set; }

    public string? TradegroupName { get; set; }

    public string? TradetypeName { get; set; }
}
