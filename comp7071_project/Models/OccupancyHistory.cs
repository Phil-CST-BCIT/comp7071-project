using System;
using System.Collections.Generic;

namespace comp7071_project.Models;

public partial class OccupancyHistory
{
    public int Id { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? LicensePlate { get; set; }

    public int AssetId { get; set; }
    public virtual Asset Asset { get; set; } = null!;
}
