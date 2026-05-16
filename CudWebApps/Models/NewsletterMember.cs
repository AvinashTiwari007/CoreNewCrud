using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class NewsletterMember
{
    public long SubsId { get; set; }

    public Guid? SubsGuid { get; set; }

    public string SubsEmail { get; set; } = null!;

    public DateTime? SubsDate { get; set; }

    public string? Status { get; set; }

    public DateTime? UnSubsDate { get; set; }
}
