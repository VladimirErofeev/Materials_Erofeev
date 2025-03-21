using System;
using System.Collections.Generic;

namespace Materials_Erofeev.Models;

public partial class Material
{
    public int Id { get; set; }

    public int IdTypeMaterial { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? Image { get; set; }

    public virtual ICollection<HistorySupply> HistorySupplies { get; set; } = new List<HistorySupply>();

    public virtual TypesMaterial IdTypeMaterialNavigation { get; set; } = null!;
}
