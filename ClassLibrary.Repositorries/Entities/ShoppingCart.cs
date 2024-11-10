using System;
using System.Collections.Generic;

namespace ClassLibrary.Repositorries.Entities;

public partial class ShoppingCart
{
    public int CartId { get; set; }

    public int? CustomerId { get; set; }

    public virtual ICollection<CartDetail> CartDetails { get; set; } = new List<CartDetail>();

    public virtual Customer? Customer { get; set; }
}
