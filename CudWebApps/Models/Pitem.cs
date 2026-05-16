using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class Pitem
{
    public long Id { get; set; }

    public long? CatId { get; set; }

    public Guid? SellerGuid { get; set; }

    public int? BrandId { get; set; }

    public string? Name { get; set; }

    public string? Pcode { get; set; }

    public string? Erpcode { get; set; }

    public string? BriefDescrip { get; set; }

    public decimal? ItemUnitPrice { get; set; }

    public decimal? ItemUnitOfferedPrice { get; set; }

    public string? ItemUnit { get; set; }

    public double? Discount { get; set; }

    public string? DiscountTags { get; set; }

    public long? MinOrderQuantity { get; set; }

    public long? OrderInMultiple { get; set; }

    public long? StockAvailable { get; set; }

    /// <summary>
    /// Dimensional LENGTH in inches as per product specification, later converted to required units for the calculation of logistics requirement
    /// </summary>
    public double? DimLn { get; set; }

    /// <summary>
    /// Dimensional BREADTH in inches as per product specification, later converted to required units for the calculation of logistics requirement
    /// </summary>
    public double? DimBr { get; set; }

    /// <summary>
    /// Dimensional HEIGHT in inches as per product specification, later converted to required units for the calculation of logistics requirement
    /// </summary>
    public double? DimHt { get; set; }

    /// <summary>
    /// Weight as per product specification, later converted to required unit for the calculation of logistics requirement
    /// </summary>
    public double? Weight { get; set; }

    public DateTime? ExpiringOn { get; set; }

    public string? FeaturesDescrip { get; set; }

    public string? SpecificationsDescrip { get; set; }

    public string? ShippingProviderCode { get; set; }

    public decimal? ShippingHomeCountryCharges { get; set; }

    public string? ShippingHomeCountryDeliveryNote { get; set; }

    public decimal? ShippingHomeCityCharges { get; set; }

    public string? ShippingHomeCityDeliveryNote { get; set; }

    public bool? IsBestDeal { get; set; }

    public bool? IsLatestArrival { get; set; }

    public decimal? NRating { get; set; }

    public long? NRateCounts { get; set; }

    public long? ReadCounts { get; set; }

    public bool? Status { get; set; }

    public string? ArticleUniqueUrl { get; set; }

    public string? WindowTitle { get; set; }

    public string? MetaKeywords { get; set; }

    public string? MetaDescription { get; set; }

    public DateTime? AddedOn { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? IsHotPick { get; set; }

    public decimal? OfferedPrice { get; set; }

    public decimal? ShippingDelhiNcrcharges { get; set; }

    public decimal? ShippingNorthIndiaCharges { get; set; }

    public decimal? ShippingRoicharges { get; set; }

    public decimal? Vat { get; set; }

    public bool? ShowOnHomePage { get; set; }

    public bool? IsExclusive { get; set; }

    public bool? InHeading1 { get; set; }

    public bool? InHeading2 { get; set; }

    public string? Video { get; set; }

    public bool? IsBestSeller { get; set; }

    public virtual Pbrand? Brand { get; set; }

    public virtual Pcategory? Cat { get; set; }

    public virtual Punit? ItemUnitNavigation { get; set; }

    public virtual ICollection<PitemPicture> PitemPictures { get; set; } = new List<PitemPicture>();

    public virtual UsersInfo? Seller { get; set; }

    public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; } = new List<ShoppingCart>();
}
