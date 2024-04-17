using System;
using System.Collections.Generic;

namespace Quanlyquanan.Model;

public partial class TypeAccount
{
    public int IdTypeAccount { get; set; }

    public string? NameTypeAccount { get; set; }

    public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
}
