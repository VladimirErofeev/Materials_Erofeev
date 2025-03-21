using System;
using System.Collections.Generic;

namespace Materials_Erofeev.Models;

public partial class TypesPartner
{
    public int Id { get; set; }

    public string TypePartner { get; set; } = null!;

    public virtual ICollection<Partner> Partners { get; set; } = new List<Partner>();
}
