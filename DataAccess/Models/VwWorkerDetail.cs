using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwWorkerDetail
{
    public string WorkerId { get; set; } = null!;

    public string? WorkerType { get; set; }

    public string? Sname { get; set; }

    public string? Oname { get; set; }

    public string? Pname { get; set; }

    public DateTime? RegDate { get; set; }

    public string? PhoneNo { get; set; }

    public DateTime? DateBirth { get; set; }

    public string? Ssfno { get; set; }

    public string? Nhis { get; set; }

    public string? Nat { get; set; }

    public string? GangName { get; set; }

    public int? TradegroupId { get; set; }

    public string? TradegroupName { get; set; }

    public int? TradetypeId { get; set; }

    public string? TradetypeName { get; set; }

    public string? Kin { get; set; }

    public string? Addr1 { get; set; }

    public string? Ezwichid { get; set; }

    public string Sex { get; set; } = null!;

    public int? Age { get; set; }

    public string? Flags { get; set; }
}
