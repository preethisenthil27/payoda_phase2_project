using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TourismManagement.Models;

public partial class PackageDetail
{
    public int PackageId { get; set; }

    public string? PackageName { get; set; }

    public string? PackageDescription { get; set; }

    public string? PackageDuration { get; set; }

    public long? PackagePrice { get; set; }

    public int? SpotId { get; set; }

    public int? RegionId { get; set; }


    [JsonIgnore]
    public virtual ICollection<BookingDetail> BookingDetails { get; set; } = new List<BookingDetail>();
    [JsonIgnore]

    public virtual RegionDetail? Region { get; set; }

    [JsonIgnore]

    public virtual SpotDetail? Spot { get; set; }


}
