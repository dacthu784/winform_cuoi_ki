using System;
using System.Collections.Generic;

namespace Quanlyquanan.Model;

public partial class Table
{
    public int IdTable { get; set; }

    public string? NameTable { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();
}
