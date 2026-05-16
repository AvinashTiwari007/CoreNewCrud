using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class MyLoyaltyPoint
{
    public long LoyaltyPointId { get; set; }

    public int? LoyaltyPoints { get; set; }

    public decimal? Value { get; set; }

    public DateTime? DateStamp { get; set; }

    public string? UserId { get; set; }

    public long? OrderId { get; set; }

    public bool? IsExpired { get; set; }

    public string? Action { get; set; }

    public string? Remarks { get; set; }
}
