using System;
using System.Collections.Generic;

namespace comp7071_project.Models;

public partial class Service
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public double? Rate { get; set; }

    public virtual ICollection<LineItem> LineItems { get; set; } = new List<LineItem>();
}
