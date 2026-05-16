using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class DiscountCoupon
{
    public long CouponId { get; set; }

    public string? CouponCode { get; set; }

    public string? CouponDescription { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public bool? Status { get; set; }

    public DateTime? TimeStamp { get; set; }

    public decimal? DiscountPercent { get; set; }

    public long? PitemId { get; set; }

    public int? BrandId { get; set; }

    public long? CatId { get; set; }

    public string? ShippingCoupon { get; set; }
}
