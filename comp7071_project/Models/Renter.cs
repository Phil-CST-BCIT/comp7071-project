using System;
using System.Collections.Generic;

namespace comp7071_project.Models;

public partial class Renter
{
    public int Id { get; set; }

    public string Name { get; set; }
    
    public float Income { get; set; }

    public string? EmergencyContactEmail { get; set; }

    public string? FamilyDoctorEmail { get; set; }

    public virtual ICollection<MaintenanceRequest> MaintenanceRequests { get; set; } = new List<MaintenanceRequest>();
    public virtual ICollection<Asset> Assets { get; set; } = new List<Asset>();
}
