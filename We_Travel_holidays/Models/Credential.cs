using System;
using System.Collections.Generic;

namespace HolidayPackages.Models;

public partial class Credential
{
    public int CId { get; set; }

    public string? CName { get; set; }

    public string? PassWord { get; set; }

    public string? Email { get; set; }

    public string? PhNumber { get; set; }
}
