using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class Hpheading
{
    public int HeadingId { get; set; }

    public string? Heading1 { get; set; }

    public string? Heading2 { get; set; }

    public long? ShowHeading1 { get; set; }

    public long? ShowHeading2 { get; set; }
}
