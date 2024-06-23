using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwWeeklyActiveVessel
{
    public string VesselName { get; set; } = null!;

    public DateTime TransDate { get; set; }
}
