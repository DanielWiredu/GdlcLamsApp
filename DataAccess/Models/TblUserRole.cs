using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblUserRole
{
    public int RoleId { get; set; }

    public string UserRole { get; set; } = null!;
}
