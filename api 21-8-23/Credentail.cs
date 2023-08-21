using System;
using System.Collections.Generic;

namespace TourismManagement.Models;

public partial class Credentail
{
    public int CId { get; set; }

    public string? CName { get; set; }

    public string? CPassword { get; set; }

    public string? CEmail { get; set; }

    public long? PhnNumber { get; set; }

    public virtual ICollection<BookingDetail> BookingDetails { get; set; } = new List<BookingDetail>();
}
