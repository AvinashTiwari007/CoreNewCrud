using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class GoQuicklyToLink
{
    public long LinkId { get; set; }

    public string? LinkName { get; set; }

    public string? LinkUrl { get; set; }

    public int? OrderId { get; set; }

    public bool? Status { get; set; }
}
