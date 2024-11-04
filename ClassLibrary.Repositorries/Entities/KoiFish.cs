using System;
using System.Collections.Generic;

namespace ClassLibrary.Repositorries.Entities;

public partial class KoiFish
{
    public int FishId { get; set; }

    public string? Name { get; set; }

    public string? Origin { get; set; }

    public string? Gender { get; set; }

    public int? Age { get; set; }

    public decimal? Size { get; set; }

    public decimal? Price { get; set; }

    public int? Stock { get; set; }

    public string? Image { get; set; }

    public virtual ICollection<CartDetail> CartDetails { get; set; } = new List<CartDetail>();

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
