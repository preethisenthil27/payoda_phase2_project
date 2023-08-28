using System;
using System.Collections.Generic;

namespace TourismManagement.Models;

public partial class SpotDetail
{
    public int SpotId { get; set; }

    public string? SpotName { get; set; }

    public virtual ICollection<PackageDetail> PackageDetails { get; set; } = new List<PackageDetail>();
}
