using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class TblNationality
{
    public int Id { get; set; }

    public string Nationality { get; set; } = null!;
}
