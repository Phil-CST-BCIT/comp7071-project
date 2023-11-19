using System;
using System.Collections.Generic;

namespace comp7071_project.Models;

public partial class MaintenanceRequest
{
    public int Id { get; set; }

    public int RenterId { get; set; }

    public int ApplianceId { get; set; }

    public DateTime? Date { get; set; }

    public string? Description { get; set; }

    public virtual Appliance Appliance { get; set; } = null!;

    public virtual ICollection<JobReport> JobReports { get; set; } = new List<JobReport>();

    public virtual Renter Renter { get; set; } = null!;

    public virtual ICollection<WorkItem> WorkItems { get; set; } = new List<WorkItem>();
}
