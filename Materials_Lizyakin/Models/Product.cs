using System;
using System.Collections.Generic;

namespace Materials_Erofeev.Models;

public partial class Product
{
    public int Id { get; set; }

    public int IdTypeProduct { get; set; }

    public string Name { get; set; } = null!;

    public string Article { get; set; } = null!;

    public decimal MinCostForPartner { get; set; }

    public virtual ICollection<HistoryProduct> HistoryProducts { get; set; } = new List<HistoryProduct>();

    public virtual TypesProduct IdTypeProductNavigation { get; set; } = null!;
}
