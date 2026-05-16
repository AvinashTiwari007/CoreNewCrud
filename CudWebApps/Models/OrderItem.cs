using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class OrderItem
{
    public long OrderItemId { get; set; }

    public long OrderId { get; set; }

    public long ItemId { get; set; }

    public short ItemTypeId { get; set; }

    public decimal UnitPrice { get; set; }

    public string? TextOption { get; set; }

    public decimal? UnitShipping { get; set; }

    public int Quantity { get; set; }

    public decimal? Discount { get; set; }

    public decimal? SavedAmount { get; set; }

    public string PriceToPay { get; set; } = null!;
}
