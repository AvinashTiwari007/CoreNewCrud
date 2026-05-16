using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class OrderReview
{
    public long Id { get; set; }

    public Guid? OrderId { get; set; }

    public string? Rating { get; set; }

    public string? Review { get; set; }

    public string? Attachment { get; set; }

    public bool? HasReviewDisc { get; set; }

    public Guid? UserGuid { get; set; }
}
