using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class Pcategory
{
    public long Id { get; set; }

    public long? ParentCategoryId { get; set; }

    public string? Path { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? CategoryBrief { get; set; }

    public string? BannerImage { get; set; }

    public string? BannerUrl { get; set; }

    public string? CategoryThumb { get; set; }

    public string? BgImagePath { get; set; }

    public string? BgImageColor { get; set; }

    public string? CategoryDescription { get; set; }

    public string? ArticleUniqueUrl { get; set; }

    public string? WindowTitle { get; set; }

    public string? MetaKeywords { get; set; }

    public string? MetaDescription { get; set; }

    public int? OrderId { get; set; }

    public bool? Status { get; set; }

    public long? NumActiveProducts { get; set; }

    public string? LinkId { get; set; }

    public bool? ShowOnHomePage { get; set; }

    public virtual ICollection<Pitem> Pitems { get; set; } = new List<Pitem>();
}
