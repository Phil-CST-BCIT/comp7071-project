using System;
using System.Collections.Generic;

namespace comp7071_project.Models;

public enum MaintenanceRequestStatus
{
    New,
    InProgress,
    Complete,
    Declined
}

public partial class MaintenanceRequest
{
    public int Id { get; set; }
    
    public DateOnly Date { get; set; }

    public string Description { get; set; }

    public MaintenanceRequestStatus Status { get; set; }

    public int ApplianceId { get; set; }
    public virtual Appliance Appliance { get; set; }

    public int RenterId { get; set; }
    public virtual Renter Renter { get; set; } = null!;

    public virtual ICollection<JobReport> JobReports { get; set; } = new List<JobReport>();
}
