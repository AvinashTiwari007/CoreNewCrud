using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class NewsLetterTemplate
{
    public long Nlid { get; set; }

    public string? Nlsubject { get; set; }

    public string? Nlbody { get; set; }

    public DateTime? NlcreateDate { get; set; }

    public DateTime? NlupdateDate { get; set; }
}
