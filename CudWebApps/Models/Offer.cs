using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class Offer
{
    public long OfferId { get; set; }

    public decimal? OfferPrice { get; set; }

    public string? ItemUnit { get; set; }

    public long? Quantity { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? ExpiringDate { get; set; }

    public bool? Status { get; set; }

    public string? OfferDescription { get; set; }

    public decimal? ShippingDelhiNcrcharges { get; set; }

    public decimal? ShippingNorthIndiaCharges { get; set; }

    public decimal? ShippingRoicharges { get; set; }

    public string? CreatedFor { get; set; }

    public virtual ICollection<ApplyOffer> ApplyOffers { get; set; } = new List<ApplyOffer>();
}
