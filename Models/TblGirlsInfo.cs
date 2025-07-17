using System;
using System.Collections.Generic;

namespace EFDatabaseApproch.Models;

public partial class TblGirlsInfo
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public int? Salary { get; set; }
}
