using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class FreeShippingAmount
{
    public long FreeShippingId { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? TimeStamp { get; set; }
}
