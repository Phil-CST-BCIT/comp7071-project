using System;
using System.Collections.Generic;

namespace comp7071_project.Models;

public partial class JobReport
{
    public int Id { get; set; }

    public int MaintenanceRequestId { get; set; }

    public string? Description { get; set; }

    public DateOnly? DateCompleted { get; set; }

    public virtual MaintenanceRequest MaintenanceRequest { get; set; } = null!;
}
