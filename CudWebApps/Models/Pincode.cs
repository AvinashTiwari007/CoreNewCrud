using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class Pincode
{
    public long PrimaryKey { get; set; }

    public string? LocCode { get; set; }

    public string? Pincode1 { get; set; }

    public string? Branch { get; set; }

    public string? Region { get; set; }

    public string? Zone { get; set; }

    public string? RoutingCode { get; set; }

    public string? ActiveFlag { get; set; }

    public string? City { get; set; }

    public long? CityId { get; set; }
}
