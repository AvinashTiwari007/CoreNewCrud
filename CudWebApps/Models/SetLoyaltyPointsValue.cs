using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class SetLoyaltyPointsValue
{
    public long Id { get; set; }

    public long? MinLoyaltyPoints { get; set; }

    public decimal? LoyaltyPointsValue { get; set; }

    public DateTime? TimeStamp { get; set; }

    public string? Description { get; set; }
}
