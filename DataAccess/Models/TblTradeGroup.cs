using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblTradeGroup
{
    public int TradegroupId { get; set; }

    public string TradegroupName { get; set; } = null!;

    public string? Dnotes { get; set; }

    public string? GphaGroupId { get; set; }
}
