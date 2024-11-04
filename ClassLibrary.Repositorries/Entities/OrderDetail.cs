using System;
using System.Collections.Generic;

namespace ClassLibrary.Repositorries.Entities;

public partial class OrderDetail
{
    public int OrderDetailId { get; set; }

    public int? OrderId { get; set; }

    public int? FishId { get; set; }

    public int? Quantity { get; set; }

    public decimal? Price { get; set; }

    public virtual KoiFish? Fish { get; set; }

    public virtual Order? Order { get; set; }
}
