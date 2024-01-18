using System;
using System.Collections.Generic;

namespace comp7071_project.Models;

public partial class Asset
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public string? Status { get; set; }

    public string? Location { get; set; }

    public virtual ICollection<Appliance> Appliances { get; set; } = new List<Appliance>();

    public virtual Application? Application { get; set; }

    public virtual ICollection<Damage> Damages { get; set; } = new List<Damage>();

    public virtual ICollection<OccupancyHistory> OccupancyHistories { get; set; } = new List<OccupancyHistory>();

    public virtual ICollection<RentHistory> RentHistories { get; set; } = new List<RentHistory>();
}
