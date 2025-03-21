using System;
using System.Collections.Generic;

namespace Materials_Erofeev.Models;

public partial class HistoryProduct
{
    public int Id { get; set; }

    public int IdPartner { get; set; }

    public int IdProduct { get; set; }

    public int Amount { get; set; }

    public DateTime Date { get; set; }

    public virtual Partner IdPartnerNavigation { get; set; } = null!;

    public virtual Product IdProductNavigation { get; set; } = null!;
}
