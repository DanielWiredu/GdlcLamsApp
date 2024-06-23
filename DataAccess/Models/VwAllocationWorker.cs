using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwAllocationWorker
{
    public int BatchNo { get; set; }

    public int AutoId { get; set; }

    public string WorkerId { get; set; } = null!;

    public string? Sname { get; set; }

    public string? Oname { get; set; }

    public string? TradetypeName { get; set; }

    public string? TradegroupName { get; set; }

    public string? Ezwichid { get; set; }

    public string Transport { get; set; } = null!;

    public int? TradetypeId { get; set; }
}
