using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblHospital
{
    public int HospitalId { get; set; }

    public string HospitalName { get; set; } = null!;
}
