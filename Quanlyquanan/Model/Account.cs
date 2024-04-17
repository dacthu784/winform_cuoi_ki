using System;
using System.Collections.Generic;

namespace Quanlyquanan.Model;

public partial class Account
{
    public int Id { get; set; }

    public string? DisplayName { get; set; }

    public string? UsersName { get; set; }

    public string? Passwords { get; set; }

    public int? IdRole { get; set; }

    public virtual TypeAccount? IdRoleNavigation { get; set; }
}
