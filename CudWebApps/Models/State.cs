using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class State
{
    public long StateId { get; set; }

    public string? StateName { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();
}
