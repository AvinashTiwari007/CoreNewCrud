using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class Codamount
{
    public long Codid { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? TimeStamp { get; set; }
}
