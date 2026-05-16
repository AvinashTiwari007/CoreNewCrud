using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class LinksInfo
{
    public long SLinkId { get; set; }

    public string? SLinkName { get; set; }

    public long? LinkTypeId { get; set; }

    public long? ParentLinkId { get; set; }

    public bool? UseUrl { get; set; }

    public string? ExUrl { get; set; }

    public bool? ShouldOpenAsFresh { get; set; }

    public string? LinkContents { get; set; }

    public bool? IsLinkActive { get; set; }

    public string? ArticleUniqueUrl { get; set; }

    public string? WindowTitle { get; set; }

    public string? MetaKeywords { get; set; }

    public string? MetaDescription { get; set; }

    public int? LinkOrderId { get; set; }

    public DateTime? LinkLastUpdate { get; set; }
}
