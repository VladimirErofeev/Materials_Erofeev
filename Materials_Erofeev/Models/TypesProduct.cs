using System;
using System.Collections.Generic;

namespace Materials_Erofeev.Models;

public partial class TypesProduct
{
    public int Id { get; set; }

    public string TypeProduct { get; set; } = null!;

    public decimal TypeCoefficent { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
