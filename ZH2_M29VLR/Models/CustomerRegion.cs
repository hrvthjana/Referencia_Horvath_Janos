using System;
using System.Collections.Generic;

namespace ZH2_M29VLR.Models;

public partial class CustomerRegion
{
    public string State { get; set; } = null!;

    public string Region { get; set; } = null!;

    public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; } = new List<CustomerAddress>();
}
