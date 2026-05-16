using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class BlogCategory
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
