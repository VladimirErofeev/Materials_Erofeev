using System;
using System.Collections.Generic;

namespace Materials_Erofeev.Models;

public partial class HistorySupply
{
    public int Id { get; set; }

    public int IdSupplier { get; set; }

    public int IdMaterial { get; set; }

    public int AmountOnePackage { get; set; }

    public int AmountOfPackages { get; set; }

    public DateTime Date { get; set; }

    public decimal CostPerPackage { get; set; }

    public short QualitySupply { get; set; }

    public virtual Material IdMaterialNavigation { get; set; } = null!;

    public virtual Supplier IdSupplierNavigation { get; set; } = null!;
}
