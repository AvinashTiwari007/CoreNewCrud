using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class Order
{
    public long OrderId { get; set; }

    public Guid? OrderGuid { get; set; }

    public string CustomerId { get; set; } = null!;

    public long? CustomerStateId { get; set; }

    public decimal OrderSubTotal { get; set; }

    public decimal? OrderTax { get; set; }

    public decimal? OrderShipping { get; set; }

    public int? PaymentMethodId { get; set; }

    public string? PaymentMethodName { get; set; }

    public string? Txid { get; set; }

    public string? Txcommand { get; set; }

    public string? Txresults { get; set; }

    public string? Txstate { get; set; }

    public DateTime? TxupdatedOn { get; set; }

    public string? Txstatus { get; set; }

    public string? AirWayBillNo { get; set; }

    public string? CourierInfo { get; set; }

    public bool? IsDeleted { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? LastUpdate { get; set; }

    public string? UpdatesHistory { get; set; }

    public string? CustomerPinCode { get; set; }

    public decimal? CouponDiscount { get; set; }

    public string? NoCouponSubTotal { get; set; }

    public string? CouponCode { get; set; }

    public decimal? LoyaltyDiscount { get; set; }

    public bool? LoyaltyApplied { get; set; }

    public string? PaymentStatus { get; set; }
}
