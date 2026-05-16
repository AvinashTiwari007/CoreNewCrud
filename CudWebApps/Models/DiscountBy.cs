using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class DiscountBy
{
    public long DisctId { get; set; }

    public long? DisctById { get; set; }

    public decimal? DiscountPercentage { get; set; }

    public bool? Status { get; set; }

    public string? DidctByName { get; set; }
}
