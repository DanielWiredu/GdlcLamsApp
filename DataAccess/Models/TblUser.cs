using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblUser
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;

    public byte[] UserPassword { get; set; } = null!;

    public string Userroles { get; set; } = null!;

    public string Fullname { get; set; } = null!;

    public string? Gender { get; set; }

    public string? MaritalStatus { get; set; }

    public string? ContactNo { get; set; }

    public string? Email { get; set; }

    public string? PostType { get; set; }

    public string? Address { get; set; }

    public string? Branch { get; set; }

    public bool Active { get; set; }

    public string UserKey { get; set; } = null!;
}
