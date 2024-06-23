using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblSubStaffReq
{
    public int AutoId { get; set; }

    public string ReqNo { get; set; } = null!;

    public string WorkerId { get; set; } = null!;

    public int? TradegroupId { get; set; }

    public string Transport { get; set; } = null!;

    public double? Normal { get; set; }

    public double? Overtime { get; set; }

    public virtual TblStaffReq ReqNoNavigation { get; set; } = null!;
}
