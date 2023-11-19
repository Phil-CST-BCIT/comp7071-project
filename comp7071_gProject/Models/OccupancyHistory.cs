using System;
using System.Collections.Generic;

namespace comp7071_project.Models;

public partial class OccupancyHistory
{
    public int Id { get; set; }

    public int AssetId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? LicensePlate { get; set; }

    public virtual Asset Asset { get; set; } = null!;
}
