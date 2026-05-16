using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class ApplyOffer
{
    public long ApplyOfferId { get; set; }

    public long? OfferId { get; set; }

    public long? ItemId { get; set; }

    public virtual Offer? Offer { get; set; }
}
