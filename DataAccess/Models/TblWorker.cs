using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblWorker
{
    public int AutoId { get; set; }

    public string WorkerId { get; set; } = null!;

    public string WorkerType { get; set; } = null!;

    public string? Sname { get; set; }

    public string? Oname { get; set; }

    public string? Pname { get; set; }

    public string? Addr1 { get; set; }

    public string? Addr2 { get; set; }

    public string? PhoneNo { get; set; }

    public DateTime? DateBirth { get; set; }

    public int? NationalityId { get; set; }

    public string? Education { get; set; }

    public string? Kin { get; set; }

    public string? Relation { get; set; }

    public string? KinAddr { get; set; }

    public string? KinAddrPhone { get; set; }

    public DateTime? RegDate { get; set; }

    public string? ContPer { get; set; }

    public string? Contaddr { get; set; }

    public string? ContPhone { get; set; }

    public string? Ssfno { get; set; }

    public string? Nhis { get; set; }

    public string? Nat { get; set; }

    public string? ShoeSize { get; set; }

    public string? Height { get; set; }

    public int? TradegroupId { get; set; }

    public int? TradetypeId { get; set; }

    public int? GangId { get; set; }

    public int? BankId { get; set; }

    public int? BankBranchId { get; set; }

    public string? BankBranch { get; set; }

    public string? BankNumber { get; set; }

    public string? OfficialComm { get; set; }

    public string? Flags { get; set; }

    public string? Sex { get; set; }

    public bool Tax { get; set; }

    public bool ChargePremium { get; set; }

    public byte[]? Pics { get; set; }

    public string? Subheader { get; set; }

    public string? Who { get; set; }

    public DateTime? Whotime { get; set; }

    public string? Ezwichid { get; set; }

    public string? NationalId { get; set; }

    public string? Tin { get; set; }

    public int? DepartmentId { get; set; }

    public string? PaymentOption { get; set; }

    public bool? OnlinePush { get; set; }

    public bool? UpdateStatus { get; set; }
    public string MedicalIdNo { get; set; }
}
