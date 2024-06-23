using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblTradeType
{
    public int TradetypeId { get; set; }

    public string? TradetypeName { get; set; }

    public string? Trnote { get; set; }

    public int? TradegroupId { get; set; }

    public string? Prefixname { get; set; }

    public string? GphaJobId { get; set; }
}
