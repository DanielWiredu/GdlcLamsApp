using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblReportingPoint
{
    public int ReportingPointId { get; set; }

    public string ReportingPoint { get; set; } = null!;
}
