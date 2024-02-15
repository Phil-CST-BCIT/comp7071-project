using System;
using System.Collections.Generic;

namespace comp7071_project.Models;

public partial class Damage
{
    public int Id { get; set; }
    
    public string Description { get; set; }

    public DateOnly DateReported { get; set; }

    public int AssetId { get; set; }
    public virtual Asset Asset { get; set; } = null!;
}