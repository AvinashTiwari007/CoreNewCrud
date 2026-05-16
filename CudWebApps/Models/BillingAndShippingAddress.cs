using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class BillingAndShippingAddress
{
    public long PrimaryKey { get; set; }

    public string? UserId { get; set; }

    public string? Name { get; set; }

    public string? StreetAddress { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Zip { get; set; }

    public string? Country { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? ShipName { get; set; }

    public string? ShipStreetAddress { get; set; }

    public string? ShipCity { get; set; }

    public string? ShipState { get; set; }

    public string? ShipZip { get; set; }

    public string? ShipCountry { get; set; }

    public string? ShipEmail { get; set; }

    public string? ShipPhone { get; set; }
}
