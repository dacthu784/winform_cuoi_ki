using System;
using System.Collections.Generic;

namespace Quanlyquanan.Model;

public partial class Category
{
    public int IdCategory { get; set; }

    public string? NameCategory { get; set; }

    public virtual ICollection<Food> Foods { get; set; } = new List<Food>();
}
