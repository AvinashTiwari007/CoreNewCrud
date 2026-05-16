using System;
using System.Collections.Generic;

namespace CudWebApps.Models;

public partial class PaymentReminderHistory
{
    public long Id { get; set; }

    public Guid? OrderGuid { get; set; }

    public string? CustomerId { get; set; }

    public DateTime? CreatedOn { get; set; }
}
