using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class Wishlist
{
    public long WishlistId { get; set; }

    public long? PitemId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public Guid? CustomerSessionGuid { get; set; }
}
