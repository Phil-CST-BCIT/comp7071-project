using System;
using System.Collections.Generic;

namespace comp7071_project.Models;

public partial class Appliance
{
    public int Id { get; set; }

    public int AssetId { get; set; }

    public string? Make { get; set; }

    public string? Model { get; set; }

    public virtual Asset Asset { get; set; } = null!;

    public virtual ICollection<MaintenanceRequest> MaintenanceRequests { get; set; } = new List<MaintenanceRequest>();
}
