using System;
using System.Collections.Generic;

namespace TourismManagement.Models;

public partial class PackageDetail
{
    public int PackageId { get; set; }

    public string? PackageName { get; set; }

    public string? ImageUrl { get; set; }

    public string? PackageDescription1 { get; set; }

    public string? PackageDescription2 { get; set; }

    public string? PackageDescription3 { get; set; }

    public string? SpotName { get; set; }

    public int? RegionId { get; set; }

    public long? PackagePrice { get; set; }

    public string? PackageDuration { get; set; }

    public virtual ICollection<BookingDetail> BookingDetails { get; set; } = new List<BookingDetail>();

    public virtual RegionDetail? Region { get; set; }
}
