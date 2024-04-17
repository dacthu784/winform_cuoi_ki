using System;
using System.Collections.Generic;

namespace Quanlyquanan.Model;

public partial class BillInfor
{
    public int Id { get; set; }

    public int? IdBill { get; set; }

    public int? IdFood { get; set; }

    public decimal? Count { get; set; }

    public virtual Bill? IdBillNavigation { get; set; }

    public virtual Food? IdFoodNavigation { get; set; }
}
