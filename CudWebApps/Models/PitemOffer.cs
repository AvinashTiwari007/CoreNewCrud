using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class PitemOffer
{
    public long OfferId { get; set; }

    public decimal? OfferPrice { get; set; }

    public string? ItemUnit { get; set; }

    public long? Quantity { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? ExpiringDate { get; set; }

    public bool? Status { get; set; }

    public string? OfferDescription { get; set; }

    public long? ItemId { get; set; }
}
