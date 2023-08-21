using System;
using System.Collections.Generic;

namespace HolidayPackages.Models;

public partial class BookingTable
{
    public int BId { get; set; }

    public DateTime? BDate { get; set; }

    public int? PId { get; set; }

    public int? NoPersons { get; set; }

    public string? Email { get; set; }

    public TimeSpan? BTime { get; set; }

    public virtual PackageTable? PIdNavigation { get; set; }
}
