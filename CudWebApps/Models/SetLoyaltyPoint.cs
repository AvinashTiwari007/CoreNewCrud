using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class SetLoyaltyPoint
{
    public long Id { get; set; }

    public long? LoyaltyPoints { get; set; }

    public DateTime? TimeStamp { get; set; }

    public string? Description { get; set; }

    public decimal? SaleValue { get; set; }
}
