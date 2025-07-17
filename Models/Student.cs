using System;
using System.Collections.Generic;

namespace EFDatabaseApproch.Models;

public partial class Student
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Gender { get; set; }

    public string? Address { get; set; }

    public long? MobileNumber { get; set; }
}
