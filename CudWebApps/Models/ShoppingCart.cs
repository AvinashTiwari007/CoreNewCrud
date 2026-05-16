using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class ShoppingCart
{
    public long ShopCartId { get; set; }

    public Guid? CustomerSessionGuid { get; set; }

    public long ItemId { get; set; }

    public short? ItemTypeId { get; set; }

    public decimal UnitPrice { get; set; }

    public string? TextOption { get; set; }

    public decimal? UnitShipping { get; set; }

    public short Quantity { get; set; }

    public decimal? Discount { get; set; }

    public decimal? SavedAmount { get; set; }

    public decimal PriceToPay { get; set; }

    public DateTime? AddedAt { get; set; }

    public long? OfferId { get; set; }

    public string? SaleType { get; set; }

    public virtual Pitem Item { get; set; } = null!;
}
