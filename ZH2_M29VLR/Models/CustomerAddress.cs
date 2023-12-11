using System;
using System.Collections.Generic;

namespace ZH2_M29VLR.Models;

public partial class CustomerAddress
{
    public int PostalCode { get; set; }

    public string? State { get; set; }

    public string City { get; set; } = null!;

    public virtual ICollection<CustomerDetail> CustomerDetails { get; set; } = new List<CustomerDetail>();

    public virtual CustomerRegion? StateNavigation { get; set; }
}
