using System;
using System.Collections.Generic;

namespace EFDatabaseApproch.Models;

public partial class TblEmployee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Age { get; set; } = null!;

    public string Designation { get; set; } = null!;

    public int Salary { get; set; }
}
