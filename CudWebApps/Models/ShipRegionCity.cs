using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class ShipRegionCity
{
    public long ShipRegionCityId { get; set; }

    public string? Code { get; set; }

    public long? ShipRegionId { get; set; }
}
