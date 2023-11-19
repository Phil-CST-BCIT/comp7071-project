using System;
using System.Collections.Generic;

namespace comp7071_project.Models;

public partial class WorkItem
{
    public int Id { get; set; }

    public int MaintenanceRequestId { get; set; }

    public string? Status { get; set; }

    public virtual MaintenanceRequest MaintenanceRequest { get; set; } = null!;
}
