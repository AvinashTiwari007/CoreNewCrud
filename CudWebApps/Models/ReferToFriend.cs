using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class ReferToFriend
{
    public long Id { get; set; }

    public Guid? ReferrerGuid { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? ReferralGuid { get; set; }

    public bool? HasReferrerDisc { get; set; }

    public bool? HasReferralCoup { get; set; }
}
