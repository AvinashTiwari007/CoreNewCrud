using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class Pbrand
{
    public int BrandId { get; set; }

    public string BrandName { get; set; } = null!;

    public string? BrandAbout { get; set; }

    public string? BrandLogo { get; set; }

    public bool? Status { get; set; }

    public int? OrderId { get; set; }

    public bool? ShowOnHomePage { get; set; }

    public string? Brandtype { get; set; }

    public virtual ICollection<Pitem> Pitems { get; set; } = new List<Pitem>();
}
