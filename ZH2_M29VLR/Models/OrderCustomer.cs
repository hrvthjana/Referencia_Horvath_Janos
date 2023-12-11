using System;
using System.Collections.Generic;

namespace ZH2_M29VLR.Models;

public partial class OrderCustomer
{
    public string? OrderId { get; set; }

    public string? CustomerId { get; set; }

    public virtual CustomerDetail? Customer { get; set; }

    public virtual OrderDetail? Order { get; set; }
}
