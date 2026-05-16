using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class Blog
{
    public long BlogId { get; set; }

    public string? BlogHeading { get; set; }

    public bool? UseUrl { get; set; }

    public string? ExUrl { get; set; }

    public bool? ShouldOpenAsFresh { get; set; }

    public string? BlogContents { get; set; }

    public bool? IsBlogActive { get; set; }

    public string? BlogUniqueUrl { get; set; }

    public int? BlogOrderId { get; set; }

    public DateTime? BlogLastUpdate { get; set; }

    public string? UploadImage { get; set; }

    public string? WindowTitle { get; set; }

    public string? MetaKeywords { get; set; }

    public string? MetaDescription { get; set; }

    public string? MetaAuthor { get; set; }

    public string? BlogStatus { get; set; }

    public DateTime? BlogPublishDate { get; set; }

    public int? CategoryId { get; set; }
}
