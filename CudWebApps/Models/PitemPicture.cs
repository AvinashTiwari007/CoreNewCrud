using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class PitemPicture
{
    public long Id { get; set; }

    public long? PitemId { get; set; }

    public string? PimageUrl { get; set; }

    public string? Caption { get; set; }

    public int? OrderId { get; set; }

    public virtual Pitem? Pitem { get; set; }
}
