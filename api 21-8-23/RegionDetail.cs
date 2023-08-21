using System;
using System.Collections.Generic;

namespace TourismManagement.Models;

public partial class RegionDetail
{
    public int RegionId { get; set; }

    public string? RegionName { get; set; }

    public virtual ICollection<PackageDetail> PackageDetails { get; set; } = new List<PackageDetail>();
}
