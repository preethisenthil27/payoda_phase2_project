using System;
using System.Collections.Generic;

namespace HolidayPackages.Models;

public partial class PackageTable
{
    public int PId { get; set; }

    public int? RId { get; set; }

    public string? PName { get; set; }

    public string? PDuration { get; set; }

    public int? PPrice { get; set; }

    public string? SpotDesc { get; set; }

    public string? PDesc1 { get; set; }

    public string? PDesc2 { get; set; }

    public string? PDesc3 { get; set; }

    public virtual ICollection<BookingTable> BookingTables { get; set; } = new List<BookingTable>();

    public virtual RegionTable? RIdNavigation { get; set; }
}
