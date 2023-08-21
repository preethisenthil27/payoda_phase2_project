using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TourismManagement.Models;

public partial class BookingDetail
{
    public int BookingId { get; set; }

    public DateTime? BookingDate { get; set; }

    public int? NoOfPersons { get; set; }

    public long? BookingPrice { get; set; }

    [JsonIgnore]
    public int? PackageId { get; set; }

    [JsonIgnore]
    public int? CId { get; set; }

    [JsonIgnore]
    public virtual Credentail? CIdNavigation { get; set; }
    [JsonIgnore]
    public virtual PackageDetail? Package { get; set; }
}
