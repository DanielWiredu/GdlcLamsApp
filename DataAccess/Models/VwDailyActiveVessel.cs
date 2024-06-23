using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwDailyActiveVessel
{
    public string VesselName { get; set; } = null!;

    public DateTime Date { get; set; }
}
