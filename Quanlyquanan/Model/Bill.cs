using System;
using System.Collections.Generic;

namespace Quanlyquanan.Model;

public partial class Bill
{
    public int IdBill { get; set; }

    public decimal? TotalPrice { get; set; }

    public int? IdTable { get; set; }

    public DateTime? DateCheckIn { get; set; }

    public DateTime? DateCheckOut { get; set; }

    public bool? Status { get; set; }

    public virtual ICollection<BillInfor> BillInfors { get; set; } = new List<BillInfor>();

    public virtual Table? IdTableNavigation { get; set; }
}
