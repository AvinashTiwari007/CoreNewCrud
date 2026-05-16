using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class ContactU
{
    public int ContactId { get; set; }

    public string? Name { get; set; }

    public string? EmailId { get; set; }

    public string? MobileNo { get; set; }

    public string? Message { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public DateTime? InsertedOn { get; set; }

    public string? Fax { get; set; }
}
