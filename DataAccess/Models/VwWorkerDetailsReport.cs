using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwWorkerDetailsReport
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

    public string? TradegroupName { get; set; }

    public string? TradetypeName { get; set; }

    public string? Kin { get; set; }

    public string? Address { get; set; }

    public string? Ezwichid { get; set; }

    public string Sex { get; set; } = null!;

    public int? Age { get; set; }

    public string? Flags { get; set; }

    public string? Nationality { get; set; }

    public string? BankName { get; set; }

    public string? Education { get; set; }

    public string? Relation { get; set; }

    public string? KinAddr { get; set; }

    public string? KinAddrPhone { get; set; }

    public string? ContPer { get; set; }

    public string? Contaddr { get; set; }

    public string? ContPhone { get; set; }

    public string? ShoeSize { get; set; }

    public string? Height { get; set; }

    public string? BankBranch { get; set; }

    public string? BankNumber { get; set; }

    public string? OfficialComm { get; set; }

    public byte[]? Pics { get; set; }

    public string? NationalId { get; set; }
}
