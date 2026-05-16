using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class ShippingRegion
{
    public long ShipRegionId { get; set; }

    public string? ShipRegionName { get; set; }

    public bool? Status { get; set; }
}
