using System;
using System.Collections.Generic;

namespace comp7071_project.Models;

public enum AssetStatus
{
    Inventory,
    Deployed,
    WrittenOff
}

public partial class Asset
{
    public int Id { get; set; }

    public string Type { get; set; }

    public AssetStatus Status { get; set; }

    public string Location { get; set; }

    public virtual ICollection<Appliance> Appliances { get; set; } = new List<Appliance>();
    public virtual ICollection<Damage> Damages { get; set; } = new List<Damage>();

    public virtual ICollection<OccupancyHistory> OccupancyHistories { get; set; } = new List<OccupancyHistory>();

    public virtual ICollection<RentHistory> RentHistories { get; set; } = new List<RentHistory>();
    
    public int? RenterId { get; set; }
    public Renter? Renter { get; set; }
}
