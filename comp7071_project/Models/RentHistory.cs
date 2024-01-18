using System;
using System.Collections.Generic;

namespace comp7071_project.Models;

public partial class RentHistory
{
    public int Id { get; set; }

    public int AssetId { get; set; }

    public DateOnly? Date { get; set; }

    public double? Amount { get; set; }

    public virtual Asset Asset { get; set; } = null!;
}
