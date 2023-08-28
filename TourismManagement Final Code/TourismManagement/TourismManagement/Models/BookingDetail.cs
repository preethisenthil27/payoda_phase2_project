using System;
using System.Collections.Generic;

namespace TourismManagement.Models;

public partial class BookingDetail
{
    public int BookingId { get; set; }

    public DateTime? BookingDate { get; set; }

    public int? NoOfPersons { get; set; }

    public int? PackageId { get; set; }

    public int? CId { get; set; }

    public virtual Credentail? CIdNavigation { get; set; }

    public virtual PackageDetail? Package { get; set; }
}
