using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblCargo
{
    public int CargoId { get; set; }

    public string CargoName { get; set; } = null!;
}
