using System;
using System.Collections.Generic;

namespace HolidayPackages.Models;

public partial class RegionTable
{
    public int RId { get; set; }

    public string? RName { get; set; }

    public virtual ICollection<PackageTable> PackageTables { get; set; } = new List<PackageTable>();
}
