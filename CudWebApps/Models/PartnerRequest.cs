using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class PartnerRequest
{
    public long ReqId { get; set; }

    public string? FullName { get; set; }

    public string? CompanyName { get; set; }

    public string? ContactNo { get; set; }

    public string? EmailAddress { get; set; }

    public long? CityId { get; set; }

    public string? Subject { get; set; }

    public string? Message { get; set; }

    public string? Status { get; set; }

    public DateTime? RequestedOn { get; set; }
}
