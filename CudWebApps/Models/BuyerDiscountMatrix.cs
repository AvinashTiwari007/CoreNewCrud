using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class BuyerDiscountMatrix
{
    public long MatRowId { get; set; }

    public string BuyerType { get; set; } = null!;

    public string DiscountColor { get; set; } = null!;

    public double? DiscountPercentage { get; set; }

    public DateTime? LastUpdatedOn { get; set; }
}
