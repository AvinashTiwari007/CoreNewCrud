using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class Punit
{
    public string UnitCode { get; set; } = null!;

    public string? UnitName { get; set; }

    public string? UnitMultiName { get; set; }

    public string? UnitOneOrMultiName { get; set; }

    public virtual ICollection<Pitem> Pitems { get; set; } = new List<Pitem>();
}
