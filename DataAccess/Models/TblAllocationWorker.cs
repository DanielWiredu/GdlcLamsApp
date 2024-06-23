using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblAllocationWorker
{
    public int AutoId { get; set; }

    public int BatchNo { get; set; }

    public string WorkerId { get; set; } = null!;

    public int TradegroupId { get; set; }

    public string Transport { get; set; } = null!;

    public virtual TblAllocationBatch BatchNoNavigation { get; set; } = null!;
}
