using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class ShippingPolicy
{
    public long PolocyId { get; set; }

    public string? PolicyName { get; set; }

    public decimal? Cost1 { get; set; }

    public decimal? Cost2 { get; set; }

    public decimal? Cost3 { get; set; }

    public bool? Status { get; set; }

    public long? PitmId { get; set; }
}
