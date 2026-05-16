using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class ProductReview
{
    public long Id { get; set; }

    public string? Review { get; set; }

    public string? Attachment { get; set; }

    public bool? HasReviewDisc { get; set; }

    public Guid? UserGuid { get; set; }

    public DateTime? CreatedOn { get; set; }

    public long? ProductId { get; set; }

    public Guid? ReviewGuid { get; set; }

    public double? Rating { get; set; }

    public bool? IsPublished { get; set; }
}
