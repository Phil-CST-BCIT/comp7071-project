using System;
using System.Collections.Generic;
using comp7071_project.Models;

public partial class Service
{
    public int Id { get; set; }

    public string Type { get; set; }

    public double Rate { get; set; }

    public List<LineItem> LineItems { get; } = new List<LineItem>();
}
