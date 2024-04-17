using System;
using System.Collections.Generic;

namespace Quanlyquanan.Model;

public partial class Food
{
    public int IdFood { get; set; }

    public string? NameFood { get; set; }

    public int? IdCategory { get; set; }

    public decimal Price { get; set; }

    public virtual ICollection<BillInfor> BillInfors { get; set; } = new List<BillInfor>();

    public virtual Category? IdCategoryNavigation { get; set; }
}
