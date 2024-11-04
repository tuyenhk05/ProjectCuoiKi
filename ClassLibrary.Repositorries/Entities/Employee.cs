using System;
using System.Collections.Generic;

namespace ClassLibrary.Repositorries.Entities;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? FullName { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }
}
