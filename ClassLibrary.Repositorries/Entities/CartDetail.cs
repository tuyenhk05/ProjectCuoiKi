using System;
using System.Collections.Generic;

namespace ClassLibrary.Repositorries.Entities;

public partial class CartDetail
{
    public int CartDetailId { get; set; }

    public int? CartId { get; set; }

    public int? FishId { get; set; }

    public int? Quantity { get; set; }

    public virtual ShoppingCart? Cart { get; set; }

    public virtual KoiFish? Fish { get; set; }
    public int AccId { get; internal set; }
}
