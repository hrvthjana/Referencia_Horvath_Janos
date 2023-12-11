using System;
using System.Collections.Generic;

namespace ZH2_M29VLR.Models;

public partial class OrderDetail
{
    public string OrderId { get; set; } = null!;

    public DateTime OrderDate { get; set; }

    public DateTime ShipDate { get; set; }

    public string ShipMode { get; set; } = null!;
}
