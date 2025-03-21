using System;
using System.Collections.Generic;

namespace Materials_Erofeev.Models;

public partial class Partner
{
    public int Id { get; set; }

    public int IdTypePartner { get; set; }

    public string Name { get; set; } = null!;

    public string LegalAdress { get; set; } = null!;

    public string Tin { get; set; } = null!;

    public string FullnameDirector { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public short Rating { get; set; }

    public virtual ICollection<HistoryProduct> HistoryProducts { get; set; } = new List<HistoryProduct>();

    public virtual TypesPartner IdTypePartnerNavigation { get; set; } = null!;
}
