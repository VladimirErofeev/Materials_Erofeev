using System;
using System.Collections.Generic;

namespace Materials_Erofeev.Models;

public partial class TypesSupplier
{
    public int Id { get; set; }

    public string TypeSupplier { get; set; } = null!;

    public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();
}
