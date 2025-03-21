using System;
using System.Collections.Generic;

namespace Materials_Erofeev.Models;

public partial class TypesMaterial
{
    public int Id { get; set; }

    public string TypeMaterial { get; set; } = null!;

    public virtual ICollection<Material> Materials { get; set; } = new List<Material>();
}
