using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblVessel
{
    public int VesselId { get; set; }

    public string VesselName { get; set; } = null!;
}
