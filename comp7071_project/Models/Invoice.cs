using System;
using System.Collections.Generic;

namespace comp7071_project.Models;

public partial class Invoice
{
    public int Id { get; set; }

    public double? RentAmount { get; set; }

    public double? Tax { get; set; }

    public DateOnly? DueDate { get; set; }

    public virtual ICollection<LineItem> LineItems { get; set; } = new List<LineItem>();
}
