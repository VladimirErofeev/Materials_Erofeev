using System;
using System.Collections.Generic;

namespace Materials_Erofeev.Models;

public partial class Supplier
{
    public int Id { get; set; }

    public int IdTypeSupplier { get; set; }

    public string Name { get; set; } = null!;

    public string Tin { get; set; } = null!;

    public bool IsWorking { get; set; }

    public virtual ICollection<HistorySupply> HistorySupplies { get; set; } = new List<HistorySupply>();

    public virtual TypesSupplier IdTypeSupplierNavigation { get; set; } = null!;
}
