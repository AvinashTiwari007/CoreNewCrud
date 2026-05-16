using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class PitemComment
{
    public long ComId { get; set; }

    public long ItemId { get; set; }

    public string ComName { get; set; } = null!;

    public string ComEmail { get; set; } = null!;

    public string ComComments { get; set; } = null!;

    public DateTime? ComDate { get; set; }

    public string? ComActStatus { get; set; }
}
