using System;
using System.Collections.Generic;

namespace comp7071_project.Models;

public partial class LineItem
{
    public int ServiceId { get; set; }

    public int InvoiceId { get; set; }

    public int? Hours { get; set; }

    public virtual Invoice Invoice { get; set; } = null!;

    public virtual Service Service { get; set; } = null!;
}
